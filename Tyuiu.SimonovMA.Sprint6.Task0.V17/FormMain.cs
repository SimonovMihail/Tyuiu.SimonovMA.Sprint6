using Tyuiu.SimonovMA.Sprint6.Task0.V17.Lib;

namespace Tyuiu.SimonovMA.Sprint6.Task0.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void executeButton_SMA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                resultTextBox_SMA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(xinputBox_SMA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xinputBox_SMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void xinputBox_SMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutButton_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы РППб-24-1 Симонов Михаил Алексеевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
