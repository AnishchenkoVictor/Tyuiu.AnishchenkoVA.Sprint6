using Tyuiu.AnishchenkoVA.Sprint6.Task0.V24.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint6.Task0.V24
{
    public partial class FormMane_AVA : Form
    {
        
        public FormMane_AVA()
        {
            InitializeComponent();
        }

        private void buttonDone_AVA_Click(object sender, EventArgs e)
        {
            DataService ds = new();
            try
            {
                textBoxOutputResult_AVA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputVariablesX_AVA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInputVariablesX_AVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_AVA_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИИПб-24-2 Анищенко Виктор Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
