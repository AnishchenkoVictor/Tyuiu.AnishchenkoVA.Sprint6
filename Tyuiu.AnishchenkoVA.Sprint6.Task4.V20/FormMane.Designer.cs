namespace Tyuiu.AnishchenkoVA.Sprint6.Task4.V20
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMane));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_AVA = new GroupBox();
            textBoxTask_AVA = new TextBox();
            groupBoxVar_AVA = new GroupBox();
            textBoxEndVar_AVA = new TextBox();
            textBoxStartVar_AVA = new TextBox();
            textBoxEndText_AVA = new TextBox();
            textBoxStartText_AVA = new TextBox();
            buttonDone_AVA = new Button();
            buttonSave_AVA = new Button();
            buttonHelp_AVA = new Button();
            groupBoxRes_AVA = new GroupBox();
            chartFunction_AVA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxRes_AVA = new TextBox();
            groupBoxTask_AVA.SuspendLayout();
            groupBoxVar_AVA.SuspendLayout();
            groupBoxRes_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AVA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_AVA
            // 
            groupBoxTask_AVA.Controls.Add(textBoxTask_AVA);
            groupBoxTask_AVA.Location = new Point(3, 3);
            groupBoxTask_AVA.Name = "groupBoxTask_AVA";
            groupBoxTask_AVA.Size = new Size(587, 121);
            groupBoxTask_AVA.TabIndex = 0;
            groupBoxTask_AVA.TabStop = false;
            groupBoxTask_AVA.Text = "Условие";
            // 
            // textBoxTask_AVA
            // 
            textBoxTask_AVA.BackColor = SystemColors.Control;
            textBoxTask_AVA.BorderStyle = BorderStyle.None;
            textBoxTask_AVA.Location = new Point(6, 23);
            textBoxTask_AVA.Multiline = true;
            textBoxTask_AVA.Name = "textBoxTask_AVA";
            textBoxTask_AVA.ReadOnly = true;
            textBoxTask_AVA.Size = new Size(575, 92);
            textBoxTask_AVA.TabIndex = 0;
            textBoxTask_AVA.Text = resources.GetString("textBoxTask_AVA.Text");
            // 
            // groupBoxVar_AVA
            // 
            groupBoxVar_AVA.Controls.Add(textBoxEndVar_AVA);
            groupBoxVar_AVA.Controls.Add(textBoxStartVar_AVA);
            groupBoxVar_AVA.Controls.Add(textBoxEndText_AVA);
            groupBoxVar_AVA.Controls.Add(textBoxStartText_AVA);
            groupBoxVar_AVA.Location = new Point(596, 3);
            groupBoxVar_AVA.Name = "groupBoxVar_AVA";
            groupBoxVar_AVA.Size = new Size(312, 121);
            groupBoxVar_AVA.TabIndex = 1;
            groupBoxVar_AVA.TabStop = false;
            groupBoxVar_AVA.Text = "Ввод данных";
            // 
            // textBoxEndVar_AVA
            // 
            textBoxEndVar_AVA.Location = new Point(164, 61);
            textBoxEndVar_AVA.Name = "textBoxEndVar_AVA";
            textBoxEndVar_AVA.Size = new Size(143, 27);
            textBoxEndVar_AVA.TabIndex = 3;
            // 
            // textBoxStartVar_AVA
            // 
            textBoxStartVar_AVA.Location = new Point(6, 61);
            textBoxStartVar_AVA.Name = "textBoxStartVar_AVA";
            textBoxStartVar_AVA.Size = new Size(143, 27);
            textBoxStartVar_AVA.TabIndex = 2;
            // 
            // textBoxEndText_AVA
            // 
            textBoxEndText_AVA.BackColor = SystemColors.Control;
            textBoxEndText_AVA.BorderStyle = BorderStyle.None;
            textBoxEndText_AVA.Location = new Point(164, 35);
            textBoxEndText_AVA.Name = "textBoxEndText_AVA";
            textBoxEndText_AVA.ReadOnly = true;
            textBoxEndText_AVA.Size = new Size(125, 20);
            textBoxEndText_AVA.TabIndex = 1;
            textBoxEndText_AVA.Text = "Конец шага:";
            // 
            // textBoxStartText_AVA
            // 
            textBoxStartText_AVA.BackColor = SystemColors.Control;
            textBoxStartText_AVA.BorderStyle = BorderStyle.None;
            textBoxStartText_AVA.Location = new Point(6, 35);
            textBoxStartText_AVA.Name = "textBoxStartText_AVA";
            textBoxStartText_AVA.ReadOnly = true;
            textBoxStartText_AVA.Size = new Size(125, 20);
            textBoxStartText_AVA.TabIndex = 0;
            textBoxStartText_AVA.Text = "Старт шага:";
            // 
            // buttonDone_AVA
            // 
            buttonDone_AVA.BackColor = Color.Green;
            buttonDone_AVA.Location = new Point(927, 12);
            buttonDone_AVA.Name = "buttonDone_AVA";
            buttonDone_AVA.Size = new Size(144, 112);
            buttonDone_AVA.TabIndex = 2;
            buttonDone_AVA.Text = "Выполнить";
            buttonDone_AVA.UseVisualStyleBackColor = false;
            buttonDone_AVA.Click += buttonDone_AVA_Click;
            // 
            // buttonSave_AVA
            // 
            buttonSave_AVA.BackColor = Color.RoyalBlue;
            buttonSave_AVA.Location = new Point(1077, 12);
            buttonSave_AVA.Name = "buttonSave_AVA";
            buttonSave_AVA.Size = new Size(144, 112);
            buttonSave_AVA.TabIndex = 3;
            buttonSave_AVA.Text = "Сохранить";
            buttonSave_AVA.UseVisualStyleBackColor = false;
            buttonSave_AVA.Click += buttonSave_AVA_Click;
            // 
            // buttonHelp_AVA
            // 
            buttonHelp_AVA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AVA.BackColor = Color.LightSkyBlue;
            buttonHelp_AVA.Location = new Point(1227, 12);
            buttonHelp_AVA.Name = "buttonHelp_AVA";
            buttonHelp_AVA.Size = new Size(122, 112);
            buttonHelp_AVA.TabIndex = 4;
            buttonHelp_AVA.Text = "Справка";
            buttonHelp_AVA.UseVisualStyleBackColor = false;
            buttonHelp_AVA.Click += buttonHelp_AVA_Click;
            // 
            // groupBoxRes_AVA
            // 
            groupBoxRes_AVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxRes_AVA.Controls.Add(chartFunction_AVA);
            groupBoxRes_AVA.Controls.Add(textBoxRes_AVA);
            groupBoxRes_AVA.Location = new Point(3, 130);
            groupBoxRes_AVA.MinimumSize = new Size(1346, 626);
            groupBoxRes_AVA.Name = "groupBoxRes_AVA";
            groupBoxRes_AVA.Size = new Size(1346, 626);
            groupBoxRes_AVA.TabIndex = 5;
            groupBoxRes_AVA.TabStop = false;
            groupBoxRes_AVA.Text = "Вывод:";
            // 
            // chartFunction_AVA
            // 
            chartFunction_AVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartFunction_AVA.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_AVA.Legends.Add(legend1);
            chartFunction_AVA.Location = new Point(400, 23);
            chartFunction_AVA.Name = "chartFunction_AVA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_AVA.Series.Add(series1);
            chartFunction_AVA.Size = new Size(943, 600);
            chartFunction_AVA.TabIndex = 1;
            chartFunction_AVA.Text = "chartFunction";
            title1.Font = new Font("Microsoft Sans Serif", 20F);
            title1.ForeColor = Color.Blue;
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction_AVA.Titles.Add(title1);
            // 
            // textBoxRes_AVA
            // 
            textBoxRes_AVA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxRes_AVA.Location = new Point(9, 23);
            textBoxRes_AVA.Multiline = true;
            textBoxRes_AVA.Name = "textBoxRes_AVA";
            textBoxRes_AVA.ScrollBars = ScrollBars.Vertical;
            textBoxRes_AVA.Size = new Size(385, 600);
            textBoxRes_AVA.TabIndex = 0;
            // 
            // FormMane
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 768);
            Controls.Add(groupBoxRes_AVA);
            Controls.Add(buttonHelp_AVA);
            Controls.Add(buttonSave_AVA);
            Controls.Add(buttonDone_AVA);
            Controls.Add(groupBoxVar_AVA);
            Controls.Add(groupBoxTask_AVA);
            MinimumSize = new Size(1376, 815);
            Name = "FormMane";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 20 | Анищенко В.А.";
            WindowState = FormWindowState.Minimized;
            groupBoxTask_AVA.ResumeLayout(false);
            groupBoxTask_AVA.PerformLayout();
            groupBoxVar_AVA.ResumeLayout(false);
            groupBoxVar_AVA.PerformLayout();
            groupBoxRes_AVA.ResumeLayout(false);
            groupBoxRes_AVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_AVA;
        private TextBox textBoxTask_AVA;
        private GroupBox groupBoxVar_AVA;
        private TextBox textBoxStartVar_AVA;
        private TextBox textBoxEndText_AVA;
        private TextBox textBoxStartText_AVA;
        private TextBox textBoxEndVar_AVA;
        private Button buttonDone_AVA;
        private Button buttonSave_AVA;
        private Button buttonHelp_AVA;
        private GroupBox groupBoxRes_AVA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AVA;
        private TextBox textBoxRes_AVA;
    }
}
