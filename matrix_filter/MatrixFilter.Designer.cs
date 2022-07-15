
namespace MatrixFilter
{
    partial class MatrixFilter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.picture = new System.Windows.Forms.PictureBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBoxFilterType = new System.Windows.Forms.GroupBox();
            this.radioButtonWithColor = new System.Windows.Forms.RadioButton();
            this.radioButtonWithoutColor = new System.Windows.Forms.RadioButton();
            this.redFilter = new System.Windows.Forms.TextBox();
            this.greenFilter = new System.Windows.Forms.TextBox();
            this.blueFilter = new System.Windows.Forms.TextBox();
            this.groupBoxFilterMatrix = new System.Windows.Forms.GroupBox();
            this.numFilter3x3 = new System.Windows.Forms.TextBox();
            this.numFilter3x2 = new System.Windows.Forms.TextBox();
            this.numFilter3x1 = new System.Windows.Forms.TextBox();
            this.numFilter2x3 = new System.Windows.Forms.TextBox();
            this.numFilter2x2 = new System.Windows.Forms.TextBox();
            this.numFilter2x1 = new System.Windows.Forms.TextBox();
            this.numFilter1x3 = new System.Windows.Forms.TextBox();
            this.numFilter1x2 = new System.Windows.Forms.TextBox();
            this.numFilter1x1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonNormalize = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.checkBoxCycleFilter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.groupBoxFilterType.SuspendLayout();
            this.groupBoxFilterMatrix.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Location = new System.Drawing.Point(12, 12);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(800, 450);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.Location = new System.Drawing.Point(12, 468);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(1009, 23);
            this.progress.TabIndex = 1;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFilter.Enabled = false;
            this.buttonFilter.Location = new System.Drawing.Point(821, 439);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(200, 23);
            this.buttonFilter.TabIndex = 8;
            this.buttonFilter.Text = "Фильтр";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(821, 284);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(200, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoad.Location = new System.Drawing.Point(821, 255);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(200, 23);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBoxFilterType
            // 
            this.groupBoxFilterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilterType.Controls.Add(this.radioButtonWithColor);
            this.groupBoxFilterType.Controls.Add(this.radioButtonWithoutColor);
            this.groupBoxFilterType.Location = new System.Drawing.Point(821, 143);
            this.groupBoxFilterType.Name = "groupBoxFilterType";
            this.groupBoxFilterType.Size = new System.Drawing.Size(200, 67);
            this.groupBoxFilterType.TabIndex = 2;
            this.groupBoxFilterType.TabStop = false;
            this.groupBoxFilterType.Text = "Тип фильтра";
            // 
            // radioButtonWithColor
            // 
            this.radioButtonWithColor.AutoSize = true;
            this.radioButtonWithColor.Location = new System.Drawing.Point(6, 42);
            this.radioButtonWithColor.Name = "radioButtonWithColor";
            this.radioButtonWithColor.Size = new System.Drawing.Size(127, 17);
            this.radioButtonWithColor.TabIndex = 1;
            this.radioButtonWithColor.TabStop = true;
            this.radioButtonWithColor.Text = "С пересчетом цвета";
            this.radioButtonWithColor.UseVisualStyleBackColor = true;
            this.radioButtonWithColor.CheckedChanged += new System.EventHandler(this.radioButtonWithColor_CheckedChanged);
            // 
            // radioButtonWithoutColor
            // 
            this.radioButtonWithoutColor.AutoSize = true;
            this.radioButtonWithoutColor.Checked = true;
            this.radioButtonWithoutColor.Location = new System.Drawing.Point(6, 19);
            this.radioButtonWithoutColor.Name = "radioButtonWithoutColor";
            this.radioButtonWithoutColor.Size = new System.Drawing.Size(131, 17);
            this.radioButtonWithoutColor.TabIndex = 0;
            this.radioButtonWithoutColor.TabStop = true;
            this.radioButtonWithoutColor.Text = "Без пересчета цвета";
            this.radioButtonWithoutColor.UseVisualStyleBackColor = true;
            this.radioButtonWithoutColor.CheckedChanged += new System.EventHandler(this.radioButtonWithoutColor_CheckedChanged);
            // 
            // redFilter
            // 
            this.redFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.redFilter.Enabled = false;
            this.redFilter.Location = new System.Drawing.Point(821, 229);
            this.redFilter.Name = "redFilter";
            this.redFilter.Size = new System.Drawing.Size(60, 20);
            this.redFilter.TabIndex = 3;
            this.redFilter.Text = "100";
            this.redFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // greenFilter
            // 
            this.greenFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.greenFilter.Enabled = false;
            this.greenFilter.Location = new System.Drawing.Point(887, 229);
            this.greenFilter.Name = "greenFilter";
            this.greenFilter.Size = new System.Drawing.Size(60, 20);
            this.greenFilter.TabIndex = 4;
            this.greenFilter.Text = "100";
            this.greenFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // blueFilter
            // 
            this.blueFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blueFilter.Enabled = false;
            this.blueFilter.Location = new System.Drawing.Point(953, 229);
            this.blueFilter.Name = "blueFilter";
            this.blueFilter.Size = new System.Drawing.Size(60, 20);
            this.blueFilter.TabIndex = 5;
            this.blueFilter.Text = "100";
            this.blueFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // groupBoxFilterMatrix
            // 
            this.groupBoxFilterMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilterMatrix.Controls.Add(this.numFilter3x3);
            this.groupBoxFilterMatrix.Controls.Add(this.numFilter3x2);
            this.groupBoxFilterMatrix.Controls.Add(this.numFilter3x1);
            this.groupBoxFilterMatrix.Controls.Add(this.numFilter2x3);
            this.groupBoxFilterMatrix.Controls.Add(this.numFilter2x2);
            this.groupBoxFilterMatrix.Controls.Add(this.numFilter2x1);
            this.groupBoxFilterMatrix.Controls.Add(this.numFilter1x3);
            this.groupBoxFilterMatrix.Controls.Add(this.numFilter1x2);
            this.groupBoxFilterMatrix.Controls.Add(this.numFilter1x1);
            this.groupBoxFilterMatrix.Location = new System.Drawing.Point(821, 12);
            this.groupBoxFilterMatrix.Name = "groupBoxFilterMatrix";
            this.groupBoxFilterMatrix.Size = new System.Drawing.Size(200, 96);
            this.groupBoxFilterMatrix.TabIndex = 0;
            this.groupBoxFilterMatrix.TabStop = false;
            this.groupBoxFilterMatrix.Text = "Матрица фильтра";
            // 
            // numFilter3x3
            // 
            this.numFilter3x3.Location = new System.Drawing.Point(118, 71);
            this.numFilter3x3.Name = "numFilter3x3";
            this.numFilter3x3.Size = new System.Drawing.Size(50, 20);
            this.numFilter3x3.TabIndex = 8;
            this.numFilter3x3.Text = "0,1";
            this.numFilter3x3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // numFilter3x2
            // 
            this.numFilter3x2.Location = new System.Drawing.Point(62, 71);
            this.numFilter3x2.Name = "numFilter3x2";
            this.numFilter3x2.Size = new System.Drawing.Size(50, 20);
            this.numFilter3x2.TabIndex = 7;
            this.numFilter3x2.Text = "0,1";
            this.numFilter3x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // numFilter3x1
            // 
            this.numFilter3x1.Location = new System.Drawing.Point(6, 71);
            this.numFilter3x1.Name = "numFilter3x1";
            this.numFilter3x1.Size = new System.Drawing.Size(50, 20);
            this.numFilter3x1.TabIndex = 6;
            this.numFilter3x1.Text = "0,1";
            this.numFilter3x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // numFilter2x3
            // 
            this.numFilter2x3.Location = new System.Drawing.Point(118, 45);
            this.numFilter2x3.Name = "numFilter2x3";
            this.numFilter2x3.Size = new System.Drawing.Size(50, 20);
            this.numFilter2x3.TabIndex = 5;
            this.numFilter2x3.Text = "0,1";
            this.numFilter2x3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // numFilter2x2
            // 
            this.numFilter2x2.Location = new System.Drawing.Point(62, 45);
            this.numFilter2x2.Name = "numFilter2x2";
            this.numFilter2x2.Size = new System.Drawing.Size(50, 20);
            this.numFilter2x2.TabIndex = 4;
            this.numFilter2x2.Text = "0,2";
            this.numFilter2x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // numFilter2x1
            // 
            this.numFilter2x1.Location = new System.Drawing.Point(6, 45);
            this.numFilter2x1.Name = "numFilter2x1";
            this.numFilter2x1.Size = new System.Drawing.Size(50, 20);
            this.numFilter2x1.TabIndex = 3;
            this.numFilter2x1.Text = "0,1";
            this.numFilter2x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // numFilter1x3
            // 
            this.numFilter1x3.Location = new System.Drawing.Point(118, 19);
            this.numFilter1x3.Name = "numFilter1x3";
            this.numFilter1x3.Size = new System.Drawing.Size(50, 20);
            this.numFilter1x3.TabIndex = 2;
            this.numFilter1x3.Text = "0,1";
            this.numFilter1x3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // numFilter1x2
            // 
            this.numFilter1x2.Location = new System.Drawing.Point(62, 19);
            this.numFilter1x2.Name = "numFilter1x2";
            this.numFilter1x2.Size = new System.Drawing.Size(50, 20);
            this.numFilter1x2.TabIndex = 1;
            this.numFilter1x2.Text = "0,1";
            this.numFilter1x2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // numFilter1x1
            // 
            this.numFilter1x1.Location = new System.Drawing.Point(6, 19);
            this.numFilter1x1.Name = "numFilter1x1";
            this.numFilter1x1.Size = new System.Drawing.Size(50, 20);
            this.numFilter1x1.TabIndex = 0;
            this.numFilter1x1.Text = "0,1";
            this.numFilter1x1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numFilterx_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(818, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Красный, %";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(884, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Зеленый, %";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(950, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Синий, %";
            // 
            // buttonNormalize
            // 
            this.buttonNormalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNormalize.Location = new System.Drawing.Point(821, 114);
            this.buttonNormalize.Name = "buttonNormalize";
            this.buttonNormalize.Size = new System.Drawing.Size(200, 23);
            this.buttonNormalize.TabIndex = 1;
            this.buttonNormalize.Text = "Нормализовать";
            this.buttonNormalize.UseVisualStyleBackColor = true;
            this.buttonNormalize.Click += new System.EventHandler(this.buttonNormalize_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestore.Enabled = false;
            this.buttonRestore.Location = new System.Drawing.Point(821, 313);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(200, 23);
            this.buttonRestore.TabIndex = 15;
            this.buttonRestore.Text = "Восстановить";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // checkBoxCycleFilter
            // 
            this.checkBoxCycleFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxCycleFilter.AutoSize = true;
            this.checkBoxCycleFilter.Location = new System.Drawing.Point(821, 416);
            this.checkBoxCycleFilter.Name = "checkBoxCycleFilter";
            this.checkBoxCycleFilter.Size = new System.Drawing.Size(80, 17);
            this.checkBoxCycleFilter.TabIndex = 16;
            this.checkBoxCycleFilter.Text = "Зациклить";
            this.checkBoxCycleFilter.UseVisualStyleBackColor = true;
            // 
            // MatrixFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 497);
            this.Controls.Add(this.checkBoxCycleFilter);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonNormalize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxFilterMatrix);
            this.Controls.Add(this.blueFilter);
            this.Controls.Add(this.greenFilter);
            this.Controls.Add(this.redFilter);
            this.Controls.Add(this.groupBoxFilterType);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.picture);
            this.Name = "MatrixFilter";
            this.Text = "Matrix Filter";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.groupBoxFilterType.ResumeLayout(false);
            this.groupBoxFilterType.PerformLayout();
            this.groupBoxFilterMatrix.ResumeLayout(false);
            this.groupBoxFilterMatrix.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBoxFilterType;
        private System.Windows.Forms.RadioButton radioButtonWithColor;
        private System.Windows.Forms.RadioButton radioButtonWithoutColor;
        private System.Windows.Forms.TextBox redFilter;
        private System.Windows.Forms.TextBox greenFilter;
        private System.Windows.Forms.TextBox blueFilter;
        private System.Windows.Forms.GroupBox groupBoxFilterMatrix;
        private System.Windows.Forms.TextBox numFilter1x1;
        private System.Windows.Forms.TextBox numFilter1x2;
        private System.Windows.Forms.TextBox numFilter1x3;
        private System.Windows.Forms.TextBox numFilter2x1;
        private System.Windows.Forms.TextBox numFilter2x2;
        private System.Windows.Forms.TextBox numFilter2x3;
        private System.Windows.Forms.TextBox numFilter3x1;
        private System.Windows.Forms.TextBox numFilter3x2;
        private System.Windows.Forms.TextBox numFilter3x3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonNormalize;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.CheckBox checkBoxCycleFilter;
    }
}

