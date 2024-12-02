namespace Tyuiu.SimonovMA.Sprint6.Task1.V23
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taskLabel_SMA = new Label();
            taskPicture_SMA = new PictureBox();
            labelInput_SMA = new Label();
            labelInputFinish_SMA = new Label();
            labelInputStart_SMA = new Label();
            inputFinish_SMA = new TextBox();
            inputStart_SMA = new TextBox();
            buttonAbout_SMA = new Button();
            buttonExecute_SMA = new Button();
            textOutput_SMA = new TextBox();
            labelOutput_SMA = new Label();
            labelResult_SMA = new Label();
            ((System.ComponentModel.ISupportInitialize)taskPicture_SMA).BeginInit();
            SuspendLayout();
            // 
            // taskLabel_SMA
            // 
            taskLabel_SMA.AutoSize = true;
            taskLabel_SMA.Location = new Point(12, 9);
            taskLabel_SMA.Name = "taskLabel_SMA";
            taskLabel_SMA.Size = new Size(53, 15);
            taskLabel_SMA.TabIndex = 0;
            taskLabel_SMA.Text = "Условие";
            // 
            // taskPicture_SMA
            // 
            taskPicture_SMA.Image = Properties.Resources.picture;
            taskPicture_SMA.Location = new Point(12, 27);
            taskPicture_SMA.Name = "taskPicture_SMA";
            taskPicture_SMA.Size = new Size(421, 136);
            taskPicture_SMA.SizeMode = PictureBoxSizeMode.Zoom;
            taskPicture_SMA.TabIndex = 3;
            taskPicture_SMA.TabStop = false;
            // 
            // labelInput_SMA
            // 
            labelInput_SMA.AutoSize = true;
            labelInput_SMA.Location = new Point(12, 180);
            labelInput_SMA.Name = "labelInput_SMA";
            labelInput_SMA.Size = new Size(77, 15);
            labelInput_SMA.TabIndex = 4;
            labelInput_SMA.Text = "Ввод данных";
            // 
            // labelInputFinish_SMA
            // 
            labelInputFinish_SMA.AutoSize = true;
            labelInputFinish_SMA.Location = new Point(121, 206);
            labelInputFinish_SMA.Name = "labelInputFinish_SMA";
            labelInputFinish_SMA.Size = new Size(75, 15);
            labelInputFinish_SMA.TabIndex = 5;
            labelInputFinish_SMA.Text = "Конец шага:";
            // 
            // labelInputStart_SMA
            // 
            labelInputStart_SMA.AutoSize = true;
            labelInputStart_SMA.Location = new Point(12, 206);
            labelInputStart_SMA.Name = "labelInputStart_SMA";
            labelInputStart_SMA.Size = new Size(72, 15);
            labelInputStart_SMA.TabIndex = 6;
            labelInputStart_SMA.Text = "Старт шага:";
            // 
            // inputFinish_SMA
            // 
            inputFinish_SMA.Location = new Point(121, 224);
            inputFinish_SMA.Name = "inputFinish_SMA";
            inputFinish_SMA.Size = new Size(75, 23);
            inputFinish_SMA.TabIndex = 7;
            inputFinish_SMA.KeyPress += inputFinish_SMA_KeyPress;
            // 
            // inputStart_SMA
            // 
            inputStart_SMA.Location = new Point(12, 224);
            inputStart_SMA.Name = "inputStart_SMA";
            inputStart_SMA.Size = new Size(77, 23);
            inputStart_SMA.TabIndex = 8;
            inputStart_SMA.TextChanged += inputStart_SMA_TextChanged;
            inputStart_SMA.KeyPress += inputStart_SMA_KeyPress;
            // 
            // buttonAbout_SMA
            // 
            buttonAbout_SMA.BackColor = Color.LightSeaGreen;
            buttonAbout_SMA.FlatStyle = FlatStyle.Flat;
            buttonAbout_SMA.Location = new Point(12, 263);
            buttonAbout_SMA.Name = "buttonAbout_SMA";
            buttonAbout_SMA.Size = new Size(163, 154);
            buttonAbout_SMA.TabIndex = 9;
            buttonAbout_SMA.Text = "Справка";
            buttonAbout_SMA.UseVisualStyleBackColor = false;
            buttonAbout_SMA.Click += buttonAbout_SMA_Click;
            // 
            // buttonExecute_SMA
            // 
            buttonExecute_SMA.BackColor = Color.Lime;
            buttonExecute_SMA.Location = new Point(181, 263);
            buttonExecute_SMA.Name = "buttonExecute_SMA";
            buttonExecute_SMA.Size = new Size(252, 154);
            buttonExecute_SMA.TabIndex = 10;
            buttonExecute_SMA.Text = "Выполнить";
            buttonExecute_SMA.UseVisualStyleBackColor = false;
            buttonExecute_SMA.Click += buttonExecute_SMA_Click;
            // 
            // textOutput_SMA
            // 
            textOutput_SMA.Location = new Point(453, 60);
            textOutput_SMA.Multiline = true;
            textOutput_SMA.Name = "textOutput_SMA";
            textOutput_SMA.ReadOnly = true;
            textOutput_SMA.Size = new Size(335, 357);
            textOutput_SMA.TabIndex = 11;
            textOutput_SMA.TextChanged += textOutput_SMA_TextChanged;
            // 
            // labelOutput_SMA
            // 
            labelOutput_SMA.AutoSize = true;
            labelOutput_SMA.Location = new Point(453, 27);
            labelOutput_SMA.Name = "labelOutput_SMA";
            labelOutput_SMA.Size = new Size(86, 15);
            labelOutput_SMA.TabIndex = 12;
            labelOutput_SMA.Text = "Вывод данных";
            // 
            // labelResult_SMA
            // 
            labelResult_SMA.AutoSize = true;
            labelResult_SMA.Location = new Point(453, 42);
            labelResult_SMA.Name = "labelResult_SMA";
            labelResult_SMA.Size = new Size(63, 15);
            labelResult_SMA.TabIndex = 13;
            labelResult_SMA.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult_SMA);
            Controls.Add(labelOutput_SMA);
            Controls.Add(textOutput_SMA);
            Controls.Add(buttonExecute_SMA);
            Controls.Add(buttonAbout_SMA);
            Controls.Add(inputStart_SMA);
            Controls.Add(inputFinish_SMA);
            Controls.Add(labelInputStart_SMA);
            Controls.Add(labelInputFinish_SMA);
            Controls.Add(labelInput_SMA);
            Controls.Add(taskPicture_SMA);
            Controls.Add(taskLabel_SMA);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 23 |  Симонов М.А.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)taskPicture_SMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label taskLabel_SMA;
        private PictureBox taskPicture_SMA;
        private Label labelInput_SMA;
        private Label labelInputFinish_SMA;
        private Label labelInputStart_SMA;
        private TextBox inputFinish_SMA;
        private TextBox inputStart_SMA;
        private Button buttonAbout_SMA;
        private Button buttonExecute_SMA;
        private TextBox textOutput_SMA;
        private Label labelOutput_SMA;
        private Label labelResult_SMA;
    }
}
