namespace Tyuiu.AnishchenkoVA.Sprint6.Task0.V24
{
    partial class FormMane_AVA
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
            pictureBoxFormula_AVA = new PictureBox();
            groupBoxTask_AVA = new GroupBox();
            textBoxTask_AVA = new TextBox();
            groupBoxVariables_AVA = new GroupBox();
            textBoxVariables_AVA = new TextBox();
            textBoxInputVariablesX_AVA = new TextBox();
            groupBoxResult_AVA = new GroupBox();
            textBoxOutputResult_AVA = new TextBox();
            textBoxResult_AVA = new TextBox();
            buttonDone_AVA = new Button();
            buttonHelp_AVA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AVA).BeginInit();
            groupBoxTask_AVA.SuspendLayout();
            groupBoxVariables_AVA.SuspendLayout();
            groupBoxResult_AVA.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxFormula_AVA
            // 
            pictureBoxFormula_AVA.Image = Properties.Resources._57E0C110_09A1_4EF4_99CD_5A2621BDB0A3_;
            pictureBoxFormula_AVA.Location = new Point(560, 26);
            pictureBoxFormula_AVA.Name = "pictureBoxFormula_AVA";
            pictureBoxFormula_AVA.Size = new Size(210, 53);
            pictureBoxFormula_AVA.TabIndex = 0;
            pictureBoxFormula_AVA.TabStop = false;
            // 
            // groupBoxTask_AVA
            // 
            groupBoxTask_AVA.Controls.Add(textBoxTask_AVA);
            groupBoxTask_AVA.Controls.Add(pictureBoxFormula_AVA);
            groupBoxTask_AVA.Location = new Point(12, 12);
            groupBoxTask_AVA.Name = "groupBoxTask_AVA";
            groupBoxTask_AVA.Size = new Size(776, 225);
            groupBoxTask_AVA.TabIndex = 1;
            groupBoxTask_AVA.TabStop = false;
            groupBoxTask_AVA.Text = "Условие";
            // 
            // textBoxTask_AVA
            // 
            textBoxTask_AVA.AccessibleName = "";
            textBoxTask_AVA.BackColor = SystemColors.Control;
            textBoxTask_AVA.BorderStyle = BorderStyle.None;
            textBoxTask_AVA.Location = new Point(6, 26);
            textBoxTask_AVA.Multiline = true;
            textBoxTask_AVA.Name = "textBoxTask_AVA";
            textBoxTask_AVA.ReadOnly = true;
            textBoxTask_AVA.Size = new Size(548, 182);
            textBoxTask_AVA.TabIndex = 2;
            textBoxTask_AVA.Text = "Дано выражение вычислить его значение при x = 3, результат вывести в TextBox.\r\nОкруглить до трёх знаков после запятой. \r\nГрафический интерфейс оформить по шаблону из лекции.";
            // 
            // groupBoxVariables_AVA
            // 
            groupBoxVariables_AVA.Controls.Add(textBoxVariables_AVA);
            groupBoxVariables_AVA.Controls.Add(textBoxInputVariablesX_AVA);
            groupBoxVariables_AVA.Location = new Point(12, 243);
            groupBoxVariables_AVA.Name = "groupBoxVariables_AVA";
            groupBoxVariables_AVA.Size = new Size(516, 143);
            groupBoxVariables_AVA.TabIndex = 2;
            groupBoxVariables_AVA.TabStop = false;
            groupBoxVariables_AVA.Text = "Ввод данных";
            // 
            // textBoxVariables_AVA
            // 
            textBoxVariables_AVA.BackColor = SystemColors.Control;
            textBoxVariables_AVA.BorderStyle = BorderStyle.None;
            textBoxVariables_AVA.Location = new Point(187, 50);
            textBoxVariables_AVA.Name = "textBoxVariables_AVA";
            textBoxVariables_AVA.ReadOnly = true;
            textBoxVariables_AVA.Size = new Size(112, 20);
            textBoxVariables_AVA.TabIndex = 3;
            textBoxVariables_AVA.Text = "Переменная X:";
            // 
            // textBoxInputVariablesX_AVA
            // 
            textBoxInputVariablesX_AVA.Location = new Point(177, 76);
            textBoxInputVariablesX_AVA.Name = "textBoxInputVariablesX_AVA";
            textBoxInputVariablesX_AVA.Size = new Size(122, 27);
            textBoxInputVariablesX_AVA.TabIndex = 0;
            textBoxInputVariablesX_AVA.KeyPress += textBoxInputVariablesX_AVA_KeyPress;
            // 
            // groupBoxResult_AVA
            // 
            groupBoxResult_AVA.Controls.Add(textBoxOutputResult_AVA);
            groupBoxResult_AVA.Controls.Add(textBoxResult_AVA);
            groupBoxResult_AVA.Location = new Point(534, 243);
            groupBoxResult_AVA.Name = "groupBoxResult_AVA";
            groupBoxResult_AVA.Size = new Size(254, 143);
            groupBoxResult_AVA.TabIndex = 3;
            groupBoxResult_AVA.TabStop = false;
            groupBoxResult_AVA.Text = "Вывод данных";
            // 
            // textBoxOutputResult_AVA
            // 
            textBoxOutputResult_AVA.BackColor = SystemColors.Control;
            textBoxOutputResult_AVA.Location = new Point(72, 76);
            textBoxOutputResult_AVA.Name = "textBoxOutputResult_AVA";
            textBoxOutputResult_AVA.ReadOnly = true;
            textBoxOutputResult_AVA.Size = new Size(122, 27);
            textBoxOutputResult_AVA.TabIndex = 4;
            // 
            // textBoxResult_AVA
            // 
            textBoxResult_AVA.BackColor = SystemColors.Control;
            textBoxResult_AVA.BorderStyle = BorderStyle.None;
            textBoxResult_AVA.Location = new Point(93, 50);
            textBoxResult_AVA.Name = "textBoxResult_AVA";
            textBoxResult_AVA.ReadOnly = true;
            textBoxResult_AVA.Size = new Size(112, 20);
            textBoxResult_AVA.TabIndex = 4;
            textBoxResult_AVA.Text = "Результат:";
            // 
            // buttonDone_AVA
            // 
            buttonDone_AVA.Location = new Point(606, 392);
            buttonDone_AVA.Name = "buttonDone_AVA";
            buttonDone_AVA.Size = new Size(182, 46);
            buttonDone_AVA.TabIndex = 4;
            buttonDone_AVA.Text = "Результат";
            buttonDone_AVA.UseVisualStyleBackColor = true;
            buttonDone_AVA.Click += buttonDone_AVA_Click;
            // 
            // buttonHelp_AVA
            // 
            buttonHelp_AVA.FlatStyle = FlatStyle.Flat;
            buttonHelp_AVA.Location = new Point(549, 392);
            buttonHelp_AVA.Name = "buttonHelp_AVA";
            buttonHelp_AVA.Size = new Size(51, 46);
            buttonHelp_AVA.TabIndex = 5;
            buttonHelp_AVA.Text = "?";
            buttonHelp_AVA.UseVisualStyleBackColor = true;
            buttonHelp_AVA.Click += buttonHelp_AVA_Click;
            // 
            // FormMane_AVA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_AVA);
            Controls.Add(buttonDone_AVA);
            Controls.Add(groupBoxResult_AVA);
            Controls.Add(groupBoxVariables_AVA);
            Controls.Add(groupBoxTask_AVA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMane_AVA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 24 | Анищенко В. А.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AVA).EndInit();
            groupBoxTask_AVA.ResumeLayout(false);
            groupBoxTask_AVA.PerformLayout();
            groupBoxVariables_AVA.ResumeLayout(false);
            groupBoxVariables_AVA.PerformLayout();
            groupBoxResult_AVA.ResumeLayout(false);
            groupBoxResult_AVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxFormula_AVA;
        private GroupBox groupBoxTask_AVA;
        private TextBox textBoxTask_AVA;
        private GroupBox groupBoxVariables_AVA;
        private TextBox textBoxVariables_AVA;
        private TextBox textBoxInputVariablesX_AVA;
        private GroupBox groupBoxResult_AVA;
        private TextBox textBoxOutputResult_AVA;
        private TextBox textBoxResult_AVA;
        private Button buttonDone_AVA;
        private Button buttonHelp_AVA;
    }
}
