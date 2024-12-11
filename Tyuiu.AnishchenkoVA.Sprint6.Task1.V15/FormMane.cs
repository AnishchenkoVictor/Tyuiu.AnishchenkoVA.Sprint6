using Tyuiu.AnishchenkoVA.Sprint6.Task1.V15.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint6.Task1.V15
{
    public partial class FormMane : Form
    {
        public FormMane()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonResult_AVA_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxVarStart_AVA.Text);
                int end = Convert.ToInt32(textBoxVarEnd_AVA.Text);

                string strline;

                int len = ds.GetMassFunction(start, end).Length;

                double[] res;
                res = new double[len];

                res = ds.GetMassFunction(start, end);
                textBoxOutputResult_AVA.Text = "";
                textBoxOutputResult_AVA.AppendText("+----------+------------+" + Environment.NewLine);
                textBoxOutputResult_AVA.AppendText("|    X     |   F(x)     |" + Environment.NewLine);
                textBoxOutputResult_AVA.AppendText("+----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strline = String.Format("|{0,5:d}     |  {1,6:f2}    |", start, res[i]);
                    textBoxOutputResult_AVA.AppendText(strline + Environment.NewLine);
                    start++;
                }
                textBoxOutputResult_AVA.AppendText("+----------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_AVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-24-2 Анищенко Виктор Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
