using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixFilter
{
    public partial class MatrixFilter : Form
    {
        private const int countFilter = 9;
        private TextBox[] numFilter;
        private TextBox[] rgbFilter;
        private bool withColor;
        private float[] matrix;
        private Bitmap loadedImage;
        private Bitmap currentPicture;

        public MatrixFilter()
        {
            InitializeComponent();
            numFilter = new TextBox[countFilter];
            numFilter[0] = numFilter1x1;
            numFilter[1] = numFilter1x2;
            numFilter[2] = numFilter1x3;
            numFilter[3] = numFilter2x1;
            numFilter[4] = numFilter2x2;
            numFilter[5] = numFilter2x3;
            numFilter[6] = numFilter3x1;
            numFilter[7] = numFilter3x2;
            numFilter[8] = numFilter3x3;
            rgbFilter = new TextBox[3];
            rgbFilter[0] = redFilter;
            rgbFilter[1] = greenFilter;
            rgbFilter[2] = blueFilter;
            withColor = false;
            matrix = new float[countFilter];
            loadedImage = null;
            currentPicture = null;
        }

        private void numFilterx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32)
            {
                if (e.KeyChar >= 44 && e.KeyChar <= 45)
                {
                    
                }
                else if ( e.KeyChar < 48 || e.KeyChar > 57 )
                {
                    e.KeyChar = (char)0;
                }
            }
        }

        private void buttonNormalize_Click(object sender, EventArgs e)
        {
            float[] matrix = new float[countFilter];
            float sum = 0f;
            for (int i = 0; i < countFilter; i++)
            {
                matrix[i] = new float();
                try
                {
                    matrix[i] = (float)Convert.ToDouble(numFilter[i].Text);
                }
                catch
                {
                    matrix[i] = 0f;
                }
                sum += Math.Abs(matrix[i]);
            }
            if (sum == 0f)
            {
                for (int i = 0; i < countFilter; i++)
                {
                    numFilter[i].Text = matrix[i].ToString();
                }
            }
            else
            {
                for (int i = 0; i < countFilter; i++)
                {
                    matrix[i] = matrix[i] / sum;
                    numFilter[i].Text = matrix[i].ToString();
                }
            }
            
        }

        private void radioButtonWithoutColor_CheckedChanged(object sender, EventArgs e)
        {
            withColor = false;
            redFilter.Enabled = false;
            greenFilter.Enabled = false;
            blueFilter.Enabled = false;
        }

        private void radioButtonWithColor_CheckedChanged(object sender, EventArgs e)
        {
            withColor = true;
            redFilter.Enabled = true;
            greenFilter.Enabled = true;
            blueFilter.Enabled = true;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            buttonFilter.Enabled = false;
            buttonLoad.Enabled = false;
            buttonSave.Enabled = false;
            buttonRestore.Enabled = false;
            Progress<int> progressValue = new Progress<int>(a => progress.Value = a);
            Progress<int> progressMaximum = new Progress<int>(a => progress.Maximum = a);
            Progress<bool> buttonEnabler = new Progress<bool>(a => { buttonLoad.Enabled = a; buttonSave.Enabled = a; buttonRestore.Enabled = a; buttonFilter.Enabled = a; } );
            Task.Run( () => StartFilter(progressValue, progressMaximum, buttonEnabler) );
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileOk += (s, cea) => {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                picture.Image = Image.FromStream(fileStream);
                fileStream.Close();
                buttonSave.Enabled = true;
                buttonFilter.Enabled = true;
                loadedImage = new Bitmap(picture.Image); 
            };
            openFileDialog.Filter = "Изображение | *.png; *.jpg; *.bmp";
            openFileDialog.ShowDialog();
            openFileDialog.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileOk += (s, cea) => {
                picture.Image.Save(saveFileDialog.FileName);
            };
            saveFileDialog.Filter = "Изображение | *.png";
            saveFileDialog.ShowDialog();
            saveFileDialog.Dispose();
        }

        private int progressOffset;
        private int[] currentProgress;
        private Color[,] buffPicture, middlePicture;
        private int leftBound, rightBound, topBound, bottomBound;
        private float red, green, blue;
        private int threads;

        private void StartFilter(IProgress<int> progressValue, IProgress<int> progressMaximum, IProgress<bool> buttonEnabler)
        {
            do
            {
                for (int i = 0; i < countFilter; i++)
                {
                    matrix[i] = new float();
                    try
                    {
                        matrix[i] = (float)Convert.ToDouble(numFilter[i].Text);
                    }
                    catch
                    {
                        matrix[i] = 0f;
                    }
                }

                currentPicture = new Bitmap(picture.Image);
                leftBound = 1;
                rightBound = currentPicture.Width - 1;
                topBound = 1;
                bottomBound = currentPicture.Height - 1;

                int maximum = (rightBound - leftBound) * (bottomBound - topBound) + picture.Image.Width * picture.Image.Height;
                progressMaximum.Report(maximum);

                buffPicture = new Color[picture.Image.Width, picture.Image.Height];
                middlePicture = new Color[picture.Image.Width, picture.Image.Height];
                Bitmap buff = new Bitmap(picture.Image);
                Color pixel;
                for (int x = 0; x < buff.Width; x++)
                {
                    for (int y = 0; y < buff.Height; y++)
                    {
                        pixel = buff.GetPixel(x, y);
                        buffPicture[x, y] = Color.FromArgb(pixel.R, pixel.G, pixel.B);
                    }
                    progressValue.Report(x * buff.Height);
                }

                progressOffset = picture.Image.Width * picture.Image.Height;

                red = (float)Convert.ToDouble(rgbFilter[0].Text);
                green = (float)Convert.ToDouble(rgbFilter[1].Text);
                blue = (float)Convert.ToDouble(rgbFilter[2].Text);

                threads = Environment.ProcessorCount;
                currentProgress = new int[threads];
                Task[] tasks = new Task[threads];
                for (int i = 0; i < threads; i++)
                {
                    currentProgress[i] = 0;
                    tasks[i] = Task.Factory.StartNew(a => Filter((int)a), i);
                }

                Task.Run(() => UpdateProgress(progressValue, progressMaximum, buttonEnabler));

                Task.WaitAll(tasks);

                for (int x = 0; x < buff.Width; x++)
                {
                    for (int y = 0; y < buff.Height; y++)
                    {
                        currentPicture.SetPixel(x, y, middlePicture[x, y]);
                    }
                }

                picture.Image = currentPicture;
                progressValue.Report(0);
            }
            while (checkBoxCycleFilter.Checked);
            buttonEnabler.Report(true);
        }

        private void Filter(int offset)
        {
            Color leftTopPixel, topPixel, rightTopPixel, leftPixel, centerPixel, rightPixel, leftBottomPixel, bottomPixel, rightBottomPixel, pixel;
            if (withColor)
            {
                for (int x = leftBound; x < rightBound; x++)
                {
                    for (int y = topBound + offset; y < bottomBound; y += threads)
                    {
                        leftTopPixel = buffPicture[x - 1, y - 1];
                        topPixel = buffPicture[x, y - 1];
                        rightTopPixel = buffPicture[x + 1, y - 1];
                        leftPixel = buffPicture[x - 1, y];
                        centerPixel = buffPicture[x, y];
                        rightPixel = buffPicture[x + 1, y];
                        leftBottomPixel = buffPicture[x - 1, y + 1];
                        bottomPixel = buffPicture[x, y + 1];
                        rightBottomPixel = buffPicture[x + 1, y + 1];
                        pixel = Color.FromArgb
                        (
                            (byte)Math.Round((leftTopPixel.R * matrix[0] + topPixel.R * matrix[1] + rightTopPixel.R * matrix[2] + leftPixel.R * matrix[3] + centerPixel.R * matrix[4] + rightPixel.R * matrix[5] + leftBottomPixel.R * matrix[6] + bottomPixel.R * matrix[7] + rightBottomPixel.R * matrix[8]) * red / 100f),
                            (byte)Math.Round((leftTopPixel.G * matrix[0] + topPixel.G * matrix[1] + rightTopPixel.G * matrix[2] + leftPixel.G * matrix[3] + centerPixel.G * matrix[4] + rightPixel.G * matrix[5] + leftBottomPixel.G * matrix[6] + bottomPixel.G * matrix[7] + rightBottomPixel.G * matrix[8]) * green / 100f),
                            (byte)Math.Round((leftTopPixel.B * matrix[0] + topPixel.B * matrix[1] + rightTopPixel.B * matrix[2] + leftPixel.B * matrix[3] + centerPixel.B * matrix[4] + rightPixel.B * matrix[5] + leftBottomPixel.B * matrix[6] + bottomPixel.B * matrix[7] + rightBottomPixel.B * matrix[8]) * blue / 100f)
                        );
                        middlePicture[x, y] = pixel;
                        currentProgress[offset]++;
                    }
                }
            }
            else
            {
                for (int x = leftBound; x < rightBound; x++)
                {
                    for (int y = topBound + offset; y < bottomBound; y += threads)
                    {
                        leftTopPixel = buffPicture[x - 1, y - 1];
                        topPixel = buffPicture[x, y - 1];
                        rightTopPixel = buffPicture[x + 1, y - 1];
                        leftPixel = buffPicture[x - 1, y];
                        centerPixel = buffPicture[x, y];
                        rightPixel = buffPicture[x + 1, y];
                        leftBottomPixel = buffPicture[x - 1, y + 1];
                        bottomPixel = buffPicture[x, y + 1];
                        rightBottomPixel = buffPicture[x + 1, y + 1];
                        pixel = Color.FromArgb
                        (
                            (byte)(leftTopPixel.R * matrix[0] + topPixel.R * matrix[1] + rightTopPixel.R * matrix[2] + leftPixel.R * matrix[3] + centerPixel.R * matrix[4] + rightPixel.R * matrix[5] + leftBottomPixel.R * matrix[6] + bottomPixel.R * matrix[7] + rightBottomPixel.R * matrix[8]),
                            (byte)(leftTopPixel.G * matrix[0] + topPixel.G * matrix[1] + rightTopPixel.G * matrix[2] + leftPixel.G * matrix[3] + centerPixel.G * matrix[4] + rightPixel.G * matrix[5] + leftBottomPixel.G * matrix[6] + bottomPixel.G * matrix[7] + rightBottomPixel.G * matrix[8]),
                            (byte)(leftTopPixel.B * matrix[0] + topPixel.B * matrix[1] + rightTopPixel.B * matrix[2] + leftPixel.B * matrix[3] + centerPixel.B * matrix[4] + rightPixel.B * matrix[5] + leftBottomPixel.B * matrix[6] + bottomPixel.B * matrix[7] + rightBottomPixel.B * matrix[8])
                        );
                        middlePicture[x, y] = pixel;
                        currentProgress[offset]++;
                    }
                }
            }
        }

        private void UpdateProgress(IProgress<int> progressValue, IProgress<int> progressMaximum, IProgress<bool> buttonEnabler)
        {
            int myprogress;
            while (progress.Value != progress.Maximum)
            {
                myprogress = 0;
                for (int i = 0; i < currentProgress.Length; i++)
                {
                    myprogress += currentProgress[i];
                }
                progressValue.Report(myprogress + progressOffset);
                Thread.Sleep(100);
            }
            progressValue.Report(0);
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            picture.Image = new Bitmap(loadedImage);
        }
    }
}
