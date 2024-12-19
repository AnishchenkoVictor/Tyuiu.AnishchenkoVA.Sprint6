using Tyuiu.AnishchenkoVA.Sprint6.Task2.V14.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint6.Task2.V14
{
    public partial class FormMane : Form
    {
        public FormMane()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_AVA_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_AVA.Text);
                int end = Convert.ToInt32(textBoxEnd_AVA.Text);

                int len = ds.GetMassFunction(start, end).Length;

                double[] res;
                res = new double[len];

                res = ds.GetMassFunction(start, end);
                this.chartFunc.Titles.Add("График функции");
                this.chartFunc.ChartAreas[0].AxisX.Title = "ось X";
                this.chartFunc.ChartAreas[0].AxisY.Title = "ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewRes.Rows.Add(Convert.ToString(start), Convert.ToString(res[i]));
                    this.chartFunc.Series[0].Points.AddXY(start, res[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInf_AVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПб-24-2 Анищенко Виктор Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_AVA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_AVA.BackColor = Color.Red;
        }

        private void buttonDone_AVA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_AVA.BackColor = Color.Green;
        }

        private void buttonDone_AVA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_AVA.BackColor = Color.Blue;
        }
    }
}
