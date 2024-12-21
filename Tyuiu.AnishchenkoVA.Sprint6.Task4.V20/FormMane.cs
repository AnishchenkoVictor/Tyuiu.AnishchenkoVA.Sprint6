using Tyuiu.AnishchenkoVA.Sprint6.Task4.V20.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint6.Task4.V20
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
                int start = Convert.ToInt32(textBoxStartVar_AVA.Text);
                int end = Convert.ToInt32(textBoxEndVar_AVA.Text);

                int len = ds.GetMassFunction(start, end).Length;

                double[] res;
                res = new double[len];

                res = ds.GetMassFunction(start, end);

                this.chartFunction_AVA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AVA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxRes_AVA.Text = "";
                chartFunction_AVA.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_AVA.Series[0].Points.AddXY(start, res[i]);
                    textBoxRes_AVA.AppendText(res[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИИПб-24-2 Анищенко Виктор Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_AVA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxRes_AVA.Text);

                DialogResult dl = MessageBox.Show("Файл" + path + "сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dl == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
