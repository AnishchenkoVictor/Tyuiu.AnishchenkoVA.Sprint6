namespace Tyuiu.AnishchenkoVA.Sprint6.Task1.V15
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
            groupBoxTask_AVA = new GroupBox();
            pictureBox1 = new PictureBox();
            buttonResult_AVA = new Button();
            buttonHelp_AVA = new Button();
            groupBoxVar_AVA = new GroupBox();
            textBoxVarEnd_AVA = new TextBox();
            textBoxVarStart_AVA = new TextBox();
            textBoxEnd_AVA = new TextBox();
            textBoxStart_AVA = new TextBox();
            groupBoxResult_AVA = new GroupBox();
            textBoxOutputResult_AVA = new TextBox();
            textBoxResult_AVA = new TextBox();
            groupBoxTask_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxVar_AVA.SuspendLayout();
            groupBoxResult_AVA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_AVA
            // 
            groupBoxTask_AVA.Controls.Add(pictureBox1);
            groupBoxTask_AVA.Location = new Point(12, 12);
            groupBoxTask_AVA.Name = "groupBoxTask_AVA";
            groupBoxTask_AVA.Size = new Size(809, 354);
            groupBoxTask_AVA.TabIndex = 0;
            groupBoxTask_AVA.TabStop = false;
            groupBoxTask_AVA.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._09B4FE80_550F_4974_A1AF_E4BA7DB4E5D0_;
            pictureBox1.Location = new Point(6, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(797, 262);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonResult_AVA
            // 
            buttonResult_AVA.BackColor = Color.Green;
            buttonResult_AVA.Location = new Point(604, 381);
            buttonResult_AVA.Name = "buttonResult_AVA";
            buttonResult_AVA.Size = new Size(211, 86);
            buttonResult_AVA.TabIndex = 1;
            buttonResult_AVA.Text = "Выполнить";
            buttonResult_AVA.UseVisualStyleBackColor = false;
            buttonResult_AVA.Click += buttonResult_AVA_Click;
            // 
            // buttonHelp_AVA
            // 
            buttonHelp_AVA.BackColor = SystemColors.MenuHighlight;
            buttonHelp_AVA.Location = new Point(489, 381);
            buttonHelp_AVA.Name = "buttonHelp_AVA";
            buttonHelp_AVA.Size = new Size(109, 86);
            buttonHelp_AVA.TabIndex = 2;
            buttonHelp_AVA.Text = "Справка";
            buttonHelp_AVA.UseVisualStyleBackColor = false;
            buttonHelp_AVA.Click += buttonHelp_AVA_Click;
            // 
            // groupBoxVar_AVA
            // 
            groupBoxVar_AVA.Controls.Add(textBoxVarEnd_AVA);
            groupBoxVar_AVA.Controls.Add(textBoxVarStart_AVA);
            groupBoxVar_AVA.Controls.Add(textBoxEnd_AVA);
            groupBoxVar_AVA.Controls.Add(textBoxStart_AVA);
            groupBoxVar_AVA.Location = new Point(18, 372);
            groupBoxVar_AVA.Name = "groupBoxVar_AVA";
            groupBoxVar_AVA.Size = new Size(465, 95);
            groupBoxVar_AVA.TabIndex = 1;
            groupBoxVar_AVA.TabStop = false;
            groupBoxVar_AVA.Text = "Ввод данных";
            // 
            // textBoxVarEnd_AVA
            // 
            textBoxVarEnd_AVA.Location = new Point(255, 52);
            textBoxVarEnd_AVA.Name = "textBoxVarEnd_AVA";
            textBoxVarEnd_AVA.Size = new Size(125, 27);
            textBoxVarEnd_AVA.TabIndex = 3;
            // 
            // textBoxVarStart_AVA
            // 
            textBoxVarStart_AVA.Location = new Point(40, 52);
            textBoxVarStart_AVA.Name = "textBoxVarStart_AVA";
            textBoxVarStart_AVA.Size = new Size(125, 27);
            textBoxVarStart_AVA.TabIndex = 2;
            // 
            // textBoxEnd_AVA
            // 
            textBoxEnd_AVA.BackColor = SystemColors.Control;
            textBoxEnd_AVA.BorderStyle = BorderStyle.None;
            textBoxEnd_AVA.Location = new Point(273, 26);
            textBoxEnd_AVA.Name = "textBoxEnd_AVA";
            textBoxEnd_AVA.ReadOnly = true;
            textBoxEnd_AVA.Size = new Size(125, 20);
            textBoxEnd_AVA.TabIndex = 1;
            textBoxEnd_AVA.Text = "Конец шага";
            // 
            // textBoxStart_AVA
            // 
            textBoxStart_AVA.BackColor = SystemColors.Control;
            textBoxStart_AVA.BorderStyle = BorderStyle.None;
            textBoxStart_AVA.Location = new Point(60, 26);
            textBoxStart_AVA.Name = "textBoxStart_AVA";
            textBoxStart_AVA.ReadOnly = true;
            textBoxStart_AVA.Size = new Size(90, 20);
            textBoxStart_AVA.TabIndex = 0;
            textBoxStart_AVA.Text = "Старт шага";
            // 
            // groupBoxResult_AVA
            // 
            groupBoxResult_AVA.Controls.Add(textBoxOutputResult_AVA);
            groupBoxResult_AVA.Controls.Add(textBoxResult_AVA);
            groupBoxResult_AVA.Location = new Point(827, 12);
            groupBoxResult_AVA.Name = "groupBoxResult_AVA";
            groupBoxResult_AVA.Size = new Size(381, 455);
            groupBoxResult_AVA.TabIndex = 3;
            groupBoxResult_AVA.TabStop = false;
            groupBoxResult_AVA.Text = "Вывод данных";
            // 
            // textBoxOutputResult_AVA
            // 
            textBoxOutputResult_AVA.BackColor = SystemColors.Control;
            textBoxOutputResult_AVA.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxOutputResult_AVA.Location = new Point(6, 52);
            textBoxOutputResult_AVA.Multiline = true;
            textBoxOutputResult_AVA.Name = "textBoxOutputResult_AVA";
            textBoxOutputResult_AVA.ReadOnly = true;
            textBoxOutputResult_AVA.ScrollBars = ScrollBars.Vertical;
            textBoxOutputResult_AVA.Size = new Size(369, 397);
            textBoxOutputResult_AVA.TabIndex = 5;
            // 
            // textBoxResult_AVA
            // 
            textBoxResult_AVA.BackColor = SystemColors.Control;
            textBoxResult_AVA.BorderStyle = BorderStyle.None;
            textBoxResult_AVA.Location = new Point(17, 26);
            textBoxResult_AVA.Name = "textBoxResult_AVA";
            textBoxResult_AVA.ReadOnly = true;
            textBoxResult_AVA.Size = new Size(90, 20);
            textBoxResult_AVA.TabIndex = 4;
            textBoxResult_AVA.Text = "Результат";
            // 
            // FormMane
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 505);
            Controls.Add(groupBoxResult_AVA);
            Controls.Add(groupBoxVar_AVA);
            Controls.Add(buttonHelp_AVA);
            Controls.Add(buttonResult_AVA);
            Controls.Add(groupBoxTask_AVA);
            MaximizeBox = false;
            Name = "FormMane";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBoxTask_AVA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxVar_AVA.ResumeLayout(false);
            groupBoxVar_AVA.PerformLayout();
            groupBoxResult_AVA.ResumeLayout(false);
            groupBoxResult_AVA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_AVA;
        private PictureBox pictureBox1;
        private Button buttonResult_AVA;
        private Button buttonHelp_AVA;
        private GroupBox groupBoxVar_AVA;
        private TextBox textBoxVarEnd_AVA;
        private TextBox textBoxVarStart_AVA;
        private TextBox textBoxEnd_AVA;
        private TextBox textBoxStart_AVA;
        private GroupBox groupBoxResult_AVA;
        private TextBox textBoxResult_AVA;
        private TextBox textBoxOutputResult_AVA;
    }
}
