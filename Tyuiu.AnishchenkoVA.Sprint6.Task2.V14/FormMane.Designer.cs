namespace Tyuiu.AnishchenkoVA.Sprint6.Task2.V14
{
    partial class FormMane
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_AVA = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBoxVar_AVA = new GroupBox();
            textBoxNameEnd_AVA = new TextBox();
            textBoxNameStart_AVA = new TextBox();
            textBoxEnd_AVA = new TextBox();
            textBoxStart_AVA = new TextBox();
            buttonInf_AVA = new Button();
            buttonDone_AVA = new Button();
            groupBoxRes_AVA = new GroupBox();
            chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewRes = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Func = new DataGridViewTextBoxColumn();
            textBoxNameRes_AVA = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxTask_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxVar_AVA.SuspendLayout();
            groupBoxRes_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_AVA
            // 
            groupBoxTask_AVA.Controls.Add(pictureBox1);
            groupBoxTask_AVA.Location = new Point(12, 12);
            groupBoxTask_AVA.Name = "groupBoxTask_AVA";
            groupBoxTask_AVA.Size = new Size(801, 363);
            groupBoxTask_AVA.TabIndex = 0;
            groupBoxTask_AVA.TabStop = false;
            groupBoxTask_AVA.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._C2AD8771_EC6B_46F7_B334_A34ACDAC000A_;
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(788, 256);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBoxVar_AVA
            // 
            groupBoxVar_AVA.Controls.Add(textBoxNameEnd_AVA);
            groupBoxVar_AVA.Controls.Add(textBoxNameStart_AVA);
            groupBoxVar_AVA.Controls.Add(textBoxEnd_AVA);
            groupBoxVar_AVA.Controls.Add(textBoxStart_AVA);
            groupBoxVar_AVA.Location = new Point(12, 381);
            groupBoxVar_AVA.Name = "groupBoxVar_AVA";
            groupBoxVar_AVA.Size = new Size(418, 100);
            groupBoxVar_AVA.TabIndex = 1;
            groupBoxVar_AVA.TabStop = false;
            groupBoxVar_AVA.Text = "Ввод данных";
            // 
            // textBoxNameEnd_AVA
            // 
            textBoxNameEnd_AVA.BackColor = SystemColors.Control;
            textBoxNameEnd_AVA.BorderStyle = BorderStyle.None;
            textBoxNameEnd_AVA.Location = new Point(240, 26);
            textBoxNameEnd_AVA.Name = "textBoxNameEnd_AVA";
            textBoxNameEnd_AVA.Size = new Size(125, 20);
            textBoxNameEnd_AVA.TabIndex = 3;
            textBoxNameEnd_AVA.Text = "Конец шага:";
            // 
            // textBoxNameStart_AVA
            // 
            textBoxNameStart_AVA.BackColor = SystemColors.Control;
            textBoxNameStart_AVA.BorderStyle = BorderStyle.None;
            textBoxNameStart_AVA.Location = new Point(6, 26);
            textBoxNameStart_AVA.Name = "textBoxNameStart_AVA";
            textBoxNameStart_AVA.Size = new Size(125, 20);
            textBoxNameStart_AVA.TabIndex = 2;
            textBoxNameStart_AVA.Text = "Старт шага:";
            // 
            // textBoxEnd_AVA
            // 
            textBoxEnd_AVA.Location = new Point(221, 52);
            textBoxEnd_AVA.Name = "textBoxEnd_AVA";
            textBoxEnd_AVA.Size = new Size(191, 27);
            textBoxEnd_AVA.TabIndex = 1;
            // 
            // textBoxStart_AVA
            // 
            textBoxStart_AVA.Location = new Point(6, 52);
            textBoxStart_AVA.Name = "textBoxStart_AVA";
            textBoxStart_AVA.Size = new Size(191, 27);
            textBoxStart_AVA.TabIndex = 0;
            // 
            // buttonInf_AVA
            // 
            buttonInf_AVA.BackColor = Color.DeepSkyBlue;
            buttonInf_AVA.Location = new Point(445, 392);
            buttonInf_AVA.Name = "buttonInf_AVA";
            buttonInf_AVA.Size = new Size(127, 82);
            buttonInf_AVA.TabIndex = 2;
            buttonInf_AVA.Text = "Справка";
            buttonInf_AVA.UseVisualStyleBackColor = false;
            buttonInf_AVA.Click += buttonInf_AVA_Click;
            // 
            // buttonDone_AVA
            // 
            buttonDone_AVA.BackColor = Color.Green;
            buttonDone_AVA.Location = new Point(587, 392);
            buttonDone_AVA.Name = "buttonDone_AVA";
            buttonDone_AVA.Size = new Size(219, 82);
            buttonDone_AVA.TabIndex = 3;
            buttonDone_AVA.Text = "Выполнить";
            buttonDone_AVA.UseVisualStyleBackColor = false;
            buttonDone_AVA.Click += buttonDone_AVA_Click;
            buttonDone_AVA.MouseDown += buttonDone_AVA_MouseDown;
            buttonDone_AVA.MouseEnter += buttonDone_AVA_MouseEnter;
            buttonDone_AVA.MouseLeave += buttonDone_AVA_MouseLeave;
            // 
            // groupBoxRes_AVA
            // 
            groupBoxRes_AVA.Controls.Add(chartFunc);
            groupBoxRes_AVA.Controls.Add(dataGridViewRes);
            groupBoxRes_AVA.Controls.Add(textBoxNameRes_AVA);
            groupBoxRes_AVA.Location = new Point(819, 12);
            groupBoxRes_AVA.Name = "groupBoxRes_AVA";
            groupBoxRes_AVA.Size = new Size(622, 469);
            groupBoxRes_AVA.TabIndex = 4;
            groupBoxRes_AVA.TabStop = false;
            groupBoxRes_AVA.Text = "Вывод данных";
            // 
            // chartFunc
            // 
            chartArea3.Name = "ChartArea1";
            chartFunc.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chartFunc.Legends.Add(legend3);
            chartFunc.Location = new Point(146, 52);
            chartFunc.Name = "chartFunc";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartFunc.Series.Add(series3);
            chartFunc.Size = new Size(470, 404);
            chartFunc.TabIndex = 2;
            chartFunc.Text = "chartFunc";
            // 
            // dataGridViewRes
            // 
            dataGridViewRes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes.Columns.AddRange(new DataGridViewColumn[] { X, Func });
            dataGridViewRes.Location = new Point(6, 52);
            dataGridViewRes.Name = "dataGridViewRes";
            dataGridViewRes.RowHeadersVisible = false;
            dataGridViewRes.RowHeadersWidth = 51;
            dataGridViewRes.Size = new Size(134, 404);
            dataGridViewRes.TabIndex = 1;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.Width = 50;
            // 
            // Func
            // 
            Func.HeaderText = "F(X)";
            Func.MinimumWidth = 6;
            Func.Name = "Func";
            Func.Width = 50;
            // 
            // textBoxNameRes_AVA
            // 
            textBoxNameRes_AVA.BackColor = SystemColors.Control;
            textBoxNameRes_AVA.BorderStyle = BorderStyle.None;
            textBoxNameRes_AVA.Location = new Point(6, 26);
            textBoxNameRes_AVA.Name = "textBoxNameRes_AVA";
            textBoxNameRes_AVA.Size = new Size(125, 20);
            textBoxNameRes_AVA.TabIndex = 0;
            textBoxNameRes_AVA.Text = "Результат:";
            // 
            // FormMane
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1453, 493);
            Controls.Add(groupBoxRes_AVA);
            Controls.Add(buttonDone_AVA);
            Controls.Add(buttonInf_AVA);
            Controls.Add(groupBoxVar_AVA);
            Controls.Add(groupBoxTask_AVA);
            MaximizeBox = false;
            Name = "FormMane";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 15 | Анищенко В.А.";
            groupBoxTask_AVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxVar_AVA.ResumeLayout(false);
            groupBoxVar_AVA.PerformLayout();
            groupBoxRes_AVA.ResumeLayout(false);
            groupBoxRes_AVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_AVA;
        private PictureBox pictureBox1;
        private GroupBox groupBoxVar_AVA;
        private TextBox textBoxNameEnd_AVA;
        private TextBox textBoxNameStart_AVA;
        private TextBox textBoxEnd_AVA;
        private TextBox textBoxStart_AVA;
        private Button buttonInf_AVA;
        private Button buttonDone_AVA;
        private GroupBox groupBoxRes_AVA;
        private DataGridView dataGridViewRes;
        private TextBox textBoxNameRes_AVA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Func;
    }
}
