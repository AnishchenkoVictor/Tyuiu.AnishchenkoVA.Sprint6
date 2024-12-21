using Tyuiu.AnishchenkoVA.Sprint6.Task3.V4.Lib;
namespace Tyuiu.AnishchenkoVA.Sprint6.Task3.V4
{
    public partial class FormMane : Form
    {
        public FormMane()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = { { -14, -7, 18, 12, -20 }, { -2, -15, -19, -19, -3 }, { -18, -5, -10, 14, -17 }, { -1, 2, -10, 0, 11 }, { 6, -18, 0, 19, 16 } };
        private void buttonDone_AVA_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;

            dataGridViewMatrixRes_AVA.ColumnCount = cols;
            dataGridViewMatrixRes_AVA.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrixRes_AVA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrixRes_AVA.Rows[i].Cells[j].Value = Convert.ToString(res[i,j]);
                }
            }
        }

        private void FormMane_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;

            dataGridViewMatrix_AVA.ColumnCount = cols;
            dataGridViewMatrix_AVA.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix_AVA.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_AVA.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonHelp_AVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИИПб-24-2 Анищенко Виктор Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
