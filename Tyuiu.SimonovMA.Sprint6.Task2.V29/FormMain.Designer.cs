namespace Tyuiu.SimonovMA.Sprint6.Task2.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pictureTask_SMA = new PictureBox();
            labelInput_SMA = new Label();
            labelInputFinish_SMA = new Label();
            labelInputStart_SMA = new Label();
            textBoxStart_SMA = new TextBox();
            textBoxFinish_SMA = new TextBox();
            buttonAbout_SMA = new Button();
            buttonExecute_SMA = new Button();
            labelOutput_SMA = new Label();
            labelResult_SMA = new Label();
            dataGridView1 = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            f_x = new DataGridViewTextBoxColumn();
            chartResult_SMA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pictureTask_SMA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_SMA).BeginInit();
            SuspendLayout();
            // 
            // pictureTask_SMA
            // 
            pictureTask_SMA.Image = Properties.Resources.picture1;
            pictureTask_SMA.Location = new Point(12, 12);
            pictureTask_SMA.Name = "pictureTask_SMA";
            pictureTask_SMA.Size = new Size(434, 158);
            pictureTask_SMA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureTask_SMA.TabIndex = 0;
            pictureTask_SMA.TabStop = false;
            // 
            // labelInput_SMA
            // 
            labelInput_SMA.AutoSize = true;
            labelInput_SMA.Location = new Point(12, 185);
            labelInput_SMA.Name = "labelInput_SMA";
            labelInput_SMA.Size = new Size(77, 15);
            labelInput_SMA.TabIndex = 1;
            labelInput_SMA.Text = "Ввод данных";
            // 
            // labelInputFinish_SMA
            // 
            labelInputFinish_SMA.AutoSize = true;
            labelInputFinish_SMA.Location = new Point(114, 213);
            labelInputFinish_SMA.Name = "labelInputFinish_SMA";
            labelInputFinish_SMA.Size = new Size(75, 15);
            labelInputFinish_SMA.TabIndex = 2;
            labelInputFinish_SMA.Text = "Конец шага:";
            // 
            // labelInputStart_SMA
            // 
            labelInputStart_SMA.AutoSize = true;
            labelInputStart_SMA.Location = new Point(12, 213);
            labelInputStart_SMA.Name = "labelInputStart_SMA";
            labelInputStart_SMA.Size = new Size(72, 15);
            labelInputStart_SMA.TabIndex = 3;
            labelInputStart_SMA.Text = "Старт шага:";
            // 
            // textBoxStart_SMA
            // 
            textBoxStart_SMA.Location = new Point(12, 231);
            textBoxStart_SMA.Name = "textBoxStart_SMA";
            textBoxStart_SMA.Size = new Size(72, 23);
            textBoxStart_SMA.TabIndex = 4;
            // 
            // textBoxFinish_SMA
            // 
            textBoxFinish_SMA.Location = new Point(114, 231);
            textBoxFinish_SMA.Name = "textBoxFinish_SMA";
            textBoxFinish_SMA.Size = new Size(75, 23);
            textBoxFinish_SMA.TabIndex = 5;
            // 
            // buttonAbout_SMA
            // 
            buttonAbout_SMA.Font = new Font("Segoe UI", 25F);
            buttonAbout_SMA.Location = new Point(195, 177);
            buttonAbout_SMA.Name = "buttonAbout_SMA";
            buttonAbout_SMA.Size = new Size(251, 77);
            buttonAbout_SMA.TabIndex = 6;
            buttonAbout_SMA.Text = "Справка";
            buttonAbout_SMA.UseVisualStyleBackColor = true;
            // 
            // buttonExecute_SMA
            // 
            buttonExecute_SMA.Font = new Font("Segoe UI", 55F);
            buttonExecute_SMA.Location = new Point(12, 260);
            buttonExecute_SMA.Name = "buttonExecute_SMA";
            buttonExecute_SMA.Size = new Size(434, 178);
            buttonExecute_SMA.TabIndex = 7;
            buttonExecute_SMA.Text = "Выполнить";
            buttonExecute_SMA.UseVisualStyleBackColor = true;
            // 
            // labelOutput_SMA
            // 
            labelOutput_SMA.AutoSize = true;
            labelOutput_SMA.Location = new Point(469, 12);
            labelOutput_SMA.Name = "labelOutput_SMA";
            labelOutput_SMA.Size = new Size(86, 15);
            labelOutput_SMA.TabIndex = 8;
            labelOutput_SMA.Text = "Вывод данных";
            // 
            // labelResult_SMA
            // 
            labelResult_SMA.AutoSize = true;
            labelResult_SMA.Location = new Point(469, 36);
            labelResult_SMA.Name = "labelResult_SMA";
            labelResult_SMA.Size = new Size(63, 15);
            labelResult_SMA.TabIndex = 9;
            labelResult_SMA.Text = "Результат:";
            labelResult_SMA.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { X, f_x });
            dataGridView1.Location = new Point(469, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(104, 384);
            dataGridView1.TabIndex = 10;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // f_x
            // 
            f_x.HeaderText = "F(X)";
            f_x.Name = "f_x";
            f_x.ReadOnly = true;
            f_x.Width = 50;
            // 
            // chartResult_SMA
            // 
            chartArea2.Name = "ChartArea1";
            chartResult_SMA.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartResult_SMA.Legends.Add(legend2);
            chartResult_SMA.Location = new Point(579, 54);
            chartResult_SMA.Name = "chartResult_SMA";
            chartResult_SMA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartResult_SMA.Series.Add(series2);
            chartResult_SMA.Size = new Size(341, 384);
            chartResult_SMA.TabIndex = 11;
            chartResult_SMA.Text = "chart1";
            chartResult_SMA.Click += chart1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 450);
            Controls.Add(chartResult_SMA);
            Controls.Add(dataGridView1);
            Controls.Add(labelResult_SMA);
            Controls.Add(labelOutput_SMA);
            Controls.Add(buttonExecute_SMA);
            Controls.Add(buttonAbout_SMA);
            Controls.Add(textBoxFinish_SMA);
            Controls.Add(textBoxStart_SMA);
            Controls.Add(labelInputStart_SMA);
            Controls.Add(labelInputFinish_SMA);
            Controls.Add(labelInput_SMA);
            Controls.Add(pictureTask_SMA);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 29 |  Симонов М.А.";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureTask_SMA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartResult_SMA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureTask_SMA;
        private Label labelInput_SMA;
        private Label labelInputFinish_SMA;
        private Label labelInputStart_SMA;
        private TextBox textBoxStart_SMA;
        private TextBox textBoxFinish_SMA;
        private Button buttonAbout_SMA;
        private Button buttonExecute_SMA;
        private Label labelOutput_SMA;
        private Label labelResult_SMA;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn f_x;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SMA;
    }
}
