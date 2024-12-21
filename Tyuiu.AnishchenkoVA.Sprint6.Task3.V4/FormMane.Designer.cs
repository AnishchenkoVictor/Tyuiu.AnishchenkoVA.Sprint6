namespace Tyuiu.AnishchenkoVA.Sprint6.Task3.V4
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
            groupBoxTask_AVA = new GroupBox();
            dataGridViewMatrix_AVA = new DataGridView();
            textBoxTask = new TextBox();
            groupBoxDone_AVA = new GroupBox();
            textBoxRes_AVA = new TextBox();
            dataGridViewMatrixRes_AVA = new DataGridView();
            buttonDone_AVA = new Button();
            buttonHelp_AVA = new Button();
            groupBoxTask_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_AVA).BeginInit();
            groupBoxDone_AVA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixRes_AVA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_AVA
            // 
            groupBoxTask_AVA.Controls.Add(dataGridViewMatrix_AVA);
            groupBoxTask_AVA.Controls.Add(textBoxTask);
            groupBoxTask_AVA.Location = new Point(7, 5);
            groupBoxTask_AVA.Name = "groupBoxTask_AVA";
            groupBoxTask_AVA.Size = new Size(832, 386);
            groupBoxTask_AVA.TabIndex = 0;
            groupBoxTask_AVA.TabStop = false;
            groupBoxTask_AVA.Text = "Условие";
            // 
            // dataGridViewMatrix_AVA
            // 
            dataGridViewMatrix_AVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_AVA.ColumnHeadersVisible = false;
            dataGridViewMatrix_AVA.Location = new Point(504, 26);
            dataGridViewMatrix_AVA.Name = "dataGridViewMatrix_AVA";
            dataGridViewMatrix_AVA.RowHeadersVisible = false;
            dataGridViewMatrix_AVA.RowHeadersWidth = 51;
            dataGridViewMatrix_AVA.Size = new Size(322, 308);
            dataGridViewMatrix_AVA.TabIndex = 1;
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Control;
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(6, 26);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(492, 299);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxDone_AVA
            // 
            groupBoxDone_AVA.Controls.Add(textBoxRes_AVA);
            groupBoxDone_AVA.Controls.Add(dataGridViewMatrixRes_AVA);
            groupBoxDone_AVA.Location = new Point(845, 5);
            groupBoxDone_AVA.Name = "groupBoxDone_AVA";
            groupBoxDone_AVA.Size = new Size(336, 340);
            groupBoxDone_AVA.TabIndex = 1;
            groupBoxDone_AVA.TabStop = false;
            groupBoxDone_AVA.Text = "Вывод данных";
            // 
            // textBoxRes_AVA
            // 
            textBoxRes_AVA.BackColor = SystemColors.Control;
            textBoxRes_AVA.BorderStyle = BorderStyle.None;
            textBoxRes_AVA.Location = new Point(6, 26);
            textBoxRes_AVA.Name = "textBoxRes_AVA";
            textBoxRes_AVA.Size = new Size(125, 20);
            textBoxRes_AVA.TabIndex = 3;
            textBoxRes_AVA.Text = "Результат:";
            // 
            // dataGridViewMatrixRes_AVA
            // 
            dataGridViewMatrixRes_AVA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrixRes_AVA.ColumnHeadersVisible = false;
            dataGridViewMatrixRes_AVA.Location = new Point(6, 52);
            dataGridViewMatrixRes_AVA.Name = "dataGridViewMatrixRes_AVA";
            dataGridViewMatrixRes_AVA.RowHeadersVisible = false;
            dataGridViewMatrixRes_AVA.RowHeadersWidth = 51;
            dataGridViewMatrixRes_AVA.Size = new Size(324, 282);
            dataGridViewMatrixRes_AVA.TabIndex = 2;
            // 
            // buttonDone_AVA
            // 
            buttonDone_AVA.Location = new Point(1009, 351);
            buttonDone_AVA.Name = "buttonDone_AVA";
            buttonDone_AVA.Size = new Size(169, 40);
            buttonDone_AVA.TabIndex = 2;
            buttonDone_AVA.Text = "Выполнить";
            buttonDone_AVA.UseVisualStyleBackColor = true;
            buttonDone_AVA.Click += buttonDone_AVA_Click;
            // 
            // buttonHelp_AVA
            // 
            buttonHelp_AVA.Location = new Point(851, 351);
            buttonHelp_AVA.Name = "buttonHelp_AVA";
            buttonHelp_AVA.Size = new Size(45, 40);
            buttonHelp_AVA.TabIndex = 3;
            buttonHelp_AVA.Text = "?";
            buttonHelp_AVA.UseVisualStyleBackColor = true;
            buttonHelp_AVA.Click += buttonHelp_AVA_Click;
            // 
            // FormMane
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 403);
            Controls.Add(buttonHelp_AVA);
            Controls.Add(buttonDone_AVA);
            Controls.Add(groupBoxDone_AVA);
            Controls.Add(groupBoxTask_AVA);
            MaximizeBox = false;
            Name = "FormMane";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 4 | Анищенко В.А.";
            Load += FormMane_Load;
            groupBoxTask_AVA.ResumeLayout(false);
            groupBoxTask_AVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_AVA).EndInit();
            groupBoxDone_AVA.ResumeLayout(false);
            groupBoxDone_AVA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrixRes_AVA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_AVA;
        private TextBox textBoxTask;
        private DataGridView dataGridViewMatrix_AVA;
        private GroupBox groupBoxDone_AVA;
        private DataGridView dataGridViewMatrixRes_AVA;
        private Button buttonDone_AVA;
        private Button buttonHelp_AVA;
        private TextBox textBoxRes_AVA;
    }
}
