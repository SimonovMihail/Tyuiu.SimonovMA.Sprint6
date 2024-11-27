namespace Tyuiu.SimonovMA.Sprint6.Task0.V17
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
            taskPicture_SMA = new PictureBox();
            taskTextBox_SMA = new TextBox();
            taskLabel_SMA = new Label();
            resultTextBox_SMA = new TextBox();
            xinputBox_SMA = new TextBox();
            outputLabel_SMA = new Label();
            inputLabel_SMA = new Label();
            xinputLabel_SMA = new Label();
            resultLabel_SMA = new Label();
            executeButton_SMA = new Button();
            aboutButton_SMA = new Button();
            ((System.ComponentModel.ISupportInitialize)taskPicture_SMA).BeginInit();
            SuspendLayout();
            // 
            // taskPicture_SMA
            // 
            taskPicture_SMA.Image = Properties.Resources.picture;
            taskPicture_SMA.Location = new Point(306, 37);
            taskPicture_SMA.Name = "taskPicture_SMA";
            taskPicture_SMA.Size = new Size(70, 53);
            taskPicture_SMA.TabIndex = 0;
            taskPicture_SMA.TabStop = false;
            // 
            // taskTextBox_SMA
            // 
            taskTextBox_SMA.Enabled = false;
            taskTextBox_SMA.HideSelection = false;
            taskTextBox_SMA.Location = new Point(12, 25);
            taskTextBox_SMA.Multiline = true;
            taskTextBox_SMA.Name = "taskTextBox_SMA";
            taskTextBox_SMA.ReadOnly = true;
            taskTextBox_SMA.Size = new Size(374, 134);
            taskTextBox_SMA.TabIndex = 1;
            taskTextBox_SMA.Text = "Вычислить выражение по формуле";
            taskTextBox_SMA.TextChanged += textBox1_TextChanged;
            // 
            // taskLabel_SMA
            // 
            taskLabel_SMA.AutoSize = true;
            taskLabel_SMA.Location = new Point(12, 7);
            taskLabel_SMA.Name = "taskLabel_SMA";
            taskLabel_SMA.Size = new Size(53, 15);
            taskLabel_SMA.TabIndex = 2;
            taskLabel_SMA.Text = "Условие";
            // 
            // resultTextBox_SMA
            // 
            resultTextBox_SMA.Location = new Point(237, 202);
            resultTextBox_SMA.Name = "resultTextBox_SMA";
            resultTextBox_SMA.ReadOnly = true;
            resultTextBox_SMA.Size = new Size(139, 23);
            resultTextBox_SMA.TabIndex = 3;
            // 
            // xinputBox_SMA
            // 
            xinputBox_SMA.Location = new Point(46, 202);
            xinputBox_SMA.Name = "xinputBox_SMA";
            xinputBox_SMA.Size = new Size(100, 23);
            xinputBox_SMA.TabIndex = 4;
            xinputBox_SMA.TextChanged += xinputBox_SMA_TextChanged;
            xinputBox_SMA.KeyPress += xinputBox_SMA_KeyPress;
            // 
            // outputLabel_SMA
            // 
            outputLabel_SMA.AutoSize = true;
            outputLabel_SMA.Location = new Point(237, 162);
            outputLabel_SMA.Name = "outputLabel_SMA";
            outputLabel_SMA.Size = new Size(86, 15);
            outputLabel_SMA.TabIndex = 5;
            outputLabel_SMA.Text = "Вывод данных";
            outputLabel_SMA.Click += label2_Click;
            // 
            // inputLabel_SMA
            // 
            inputLabel_SMA.AutoSize = true;
            inputLabel_SMA.Location = new Point(46, 163);
            inputLabel_SMA.Name = "inputLabel_SMA";
            inputLabel_SMA.Size = new Size(77, 15);
            inputLabel_SMA.TabIndex = 6;
            inputLabel_SMA.Text = "Ввод данных";
            inputLabel_SMA.Click += label3_Click;
            // 
            // xinputLabel_SMA
            // 
            xinputLabel_SMA.AutoSize = true;
            xinputLabel_SMA.Location = new Point(46, 184);
            xinputLabel_SMA.Name = "xinputLabel_SMA";
            xinputLabel_SMA.Size = new Size(88, 15);
            xinputLabel_SMA.TabIndex = 7;
            xinputLabel_SMA.Text = "Переменная x:";
            // 
            // resultLabel_SMA
            // 
            resultLabel_SMA.AutoSize = true;
            resultLabel_SMA.Location = new Point(237, 184);
            resultLabel_SMA.Name = "resultLabel_SMA";
            resultLabel_SMA.Size = new Size(63, 15);
            resultLabel_SMA.TabIndex = 8;
            resultLabel_SMA.Text = "Результат:";
            // 
            // executeButton_SMA
            // 
            executeButton_SMA.Location = new Point(276, 231);
            executeButton_SMA.Name = "executeButton_SMA";
            executeButton_SMA.Size = new Size(100, 28);
            executeButton_SMA.TabIndex = 9;
            executeButton_SMA.Text = "Выполнить";
            executeButton_SMA.UseVisualStyleBackColor = true;
            executeButton_SMA.Click += executeButton_SMA_Click;
            // 
            // aboutButton_SMA
            // 
            aboutButton_SMA.FlatStyle = FlatStyle.Flat;
            aboutButton_SMA.Location = new Point(237, 231);
            aboutButton_SMA.Name = "aboutButton_SMA";
            aboutButton_SMA.Size = new Size(33, 28);
            aboutButton_SMA.TabIndex = 10;
            aboutButton_SMA.Text = "?";
            aboutButton_SMA.UseVisualStyleBackColor = true;
            aboutButton_SMA.Click += aboutButton_SMA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 271);
            Controls.Add(aboutButton_SMA);
            Controls.Add(executeButton_SMA);
            Controls.Add(resultLabel_SMA);
            Controls.Add(xinputLabel_SMA);
            Controls.Add(inputLabel_SMA);
            Controls.Add(outputLabel_SMA);
            Controls.Add(xinputBox_SMA);
            Controls.Add(resultTextBox_SMA);
            Controls.Add(taskLabel_SMA);
            Controls.Add(taskPicture_SMA);
            Controls.Add(taskTextBox_SMA);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 17 |  Симонов М.А.";
            ((System.ComponentModel.ISupportInitialize)taskPicture_SMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox taskPicture_SMA;
        private TextBox taskTextBox_SMA;
        private Label taskLabel_SMA;
        private TextBox resultTextBox_SMA;
        private TextBox xinputBox_SMA;
        private Label outputLabel_SMA;
        private Label inputLabel_SMA;
        private Label xinputLabel_SMA;
        private Label resultLabel_SMA;
        private Button executeButton_SMA;
        private Button aboutButton_SMA;
    }
}
