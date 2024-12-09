namespace Tyuiu.SimonovMA.Sprint6.Task6.V12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpenFile_SMA = new Button();
            buttonRun_SMA = new Button();
            buttonAbout_SMA = new Button();
            groupBoxTask_SMA = new GroupBox();
            textBoxTask_SMA = new TextBox();
            groupBoxTask_SMA.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile_SMA
            // 
            buttonOpenFile_SMA.Location = new Point(12, 12);
            buttonOpenFile_SMA.Name = "buttonOpenFile_SMA";
            buttonOpenFile_SMA.Size = new Size(75, 54);
            buttonOpenFile_SMA.TabIndex = 0;
            buttonOpenFile_SMA.Text = "Файл";
            buttonOpenFile_SMA.UseVisualStyleBackColor = true;
            // 
            // buttonRun_SMA
            // 
            buttonRun_SMA.Location = new Point(93, 12);
            buttonRun_SMA.Name = "buttonRun_SMA";
            buttonRun_SMA.Size = new Size(75, 54);
            buttonRun_SMA.TabIndex = 1;
            buttonRun_SMA.Text = "Пуск";
            buttonRun_SMA.UseVisualStyleBackColor = true;
            // 
            // buttonAbout_SMA
            // 
            buttonAbout_SMA.Location = new Point(713, 8);
            buttonAbout_SMA.Name = "buttonAbout_SMA";
            buttonAbout_SMA.Size = new Size(75, 58);
            buttonAbout_SMA.TabIndex = 2;
            buttonAbout_SMA.Text = "Справка";
            buttonAbout_SMA.UseVisualStyleBackColor = true;
            // 
            // groupBoxTask_SMA
            // 
            groupBoxTask_SMA.Controls.Add(textBoxTask_SMA);
            groupBoxTask_SMA.Location = new Point(12, 72);
            groupBoxTask_SMA.Name = "groupBoxTask_SMA";
            groupBoxTask_SMA.Size = new Size(776, 64);
            groupBoxTask_SMA.TabIndex = 3;
            groupBoxTask_SMA.TabStop = false;
            groupBoxTask_SMA.Text = "Условие";
            groupBoxTask_SMA.Enter += groupBox1_Enter;
            // 
            // textBoxTask_SMA
            // 
            textBoxTask_SMA.Location = new Point(6, 22);
            textBoxTask_SMA.Multiline = true;
            textBoxTask_SMA.Name = "textBoxTask_SMA";
            textBoxTask_SMA.ReadOnly = true;
            textBoxTask_SMA.Size = new Size(764, 36);
            textBoxTask_SMA.TabIndex = 0;
            textBoxTask_SMA.Text = resources.GetString("textBoxTask_SMA.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxTask_SMA);
            Controls.Add(buttonAbout_SMA);
            Controls.Add(buttonRun_SMA);
            Controls.Add(buttonOpenFile_SMA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 12 |  Симонов М.А.";
            Load += Form1_Load;
            groupBoxTask_SMA.ResumeLayout(false);
            groupBoxTask_SMA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpenFile_SMA;
        private Button buttonRun_SMA;
        private Button buttonAbout_SMA;
        private GroupBox groupBoxTask_SMA;
        private TextBox textBoxTask_SMA;
    }
}
