using Tyuiu.SimonovMA.Sprint6.Task1.V23.Lib;

namespace Tyuiu.SimonovMA.Sprint6.Task1.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        DataService ds = new DataService();
        private void buttonExecute_SMA_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                //textOutput_SMA.Text = Convert.ToString(ds.GetMassFunction(Convert.ToInt32(inputStart_SMA.Text), Convert.ToInt32(inputFinish_SMA.Text)));

                int startStep = Convert.ToInt32(inputStart_SMA.Text);
                int stopStep = Convert.ToInt32(inputFinish_SMA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textOutput_SMA.Text = "";
                textOutput_SMA.AppendText("+----------+----------+" + Environment.NewLine);
                textOutput_SMA.AppendText("|    X     +   f(x)   |" + Environment.NewLine);
                textOutput_SMA.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f2}   | ", startStep, valueArray[i]);
                    textOutput_SMA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textOutput_SMA.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAbout_SMA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы РППб-24-1 Симонов Михаил Алексеевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void inputStart_SMA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void inputStart_SMA_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputFinish_SMA_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textOutput_SMA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
