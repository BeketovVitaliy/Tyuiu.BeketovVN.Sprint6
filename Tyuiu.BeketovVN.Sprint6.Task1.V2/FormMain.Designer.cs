namespace Tyuiu.BeketovVN.Sprint6.Task1.V2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone_BVN = new System.Windows.Forms.Button();
            buttonInfo_BVN = new System.Windows.Forms.Button();
            groupBoxInput_BVN = new System.Windows.Forms.GroupBox();
            labelStopStep_BVN = new System.Windows.Forms.Label();
            labelStartStep_BVN = new System.Windows.Forms.Label();
            textBoxStopStep_BVN = new System.Windows.Forms.TextBox();
            textBoxStartStep_BVN = new System.Windows.Forms.TextBox();
            groupBoxTask_BVN = new System.Windows.Forms.GroupBox();
            pictureBoxTask_BVN = new System.Windows.Forms.PictureBox();
            textBoxTask_BVN = new System.Windows.Forms.TextBox();
            groupBoxResult_BVN = new System.Windows.Forms.GroupBox();
            labelResult_BVN = new System.Windows.Forms.Label();
            textBoxResult_BVN = new System.Windows.Forms.TextBox();
            groupBoxInput_BVN.SuspendLayout();
            groupBoxTask_BVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BVN).BeginInit();
            groupBoxResult_BVN.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_BVN
            // 
            buttonDone_BVN.BackColor = System.Drawing.Color.Green;
            buttonDone_BVN.Location = new System.Drawing.Point(399, 338);
            buttonDone_BVN.Name = "buttonDone_BVN";
            buttonDone_BVN.Size = new System.Drawing.Size(121, 58);
            buttonDone_BVN.TabIndex = 0;
            buttonDone_BVN.Text = "Выполнить";
            buttonDone_BVN.UseMnemonic = false;
            buttonDone_BVN.UseVisualStyleBackColor = false;
            buttonDone_BVN.Click += button1_Click;
            // 
            // buttonInfo_BVN
            // 
            buttonInfo_BVN.BackColor = System.Drawing.Color.DodgerBlue;
            buttonInfo_BVN.Location = new System.Drawing.Point(308, 338);
            buttonInfo_BVN.Name = "buttonInfo_BVN";
            buttonInfo_BVN.Size = new System.Drawing.Size(86, 58);
            buttonInfo_BVN.TabIndex = 1;
            buttonInfo_BVN.Text = "Справка";
            buttonInfo_BVN.UseVisualStyleBackColor = false;
            buttonInfo_BVN.Click += buttonInfo_GKU_Click;
            // 
            // groupBoxInput_BVN
            // 
            groupBoxInput_BVN.Controls.Add(labelStopStep_BVN);
            groupBoxInput_BVN.Controls.Add(labelStartStep_BVN);
            groupBoxInput_BVN.Controls.Add(textBoxStopStep_BVN);
            groupBoxInput_BVN.Controls.Add(textBoxStartStep_BVN);
            groupBoxInput_BVN.Location = new System.Drawing.Point(10, 332);
            groupBoxInput_BVN.Name = "groupBoxInput_BVN";
            groupBoxInput_BVN.Size = new System.Drawing.Size(284, 64);
            groupBoxInput_BVN.TabIndex = 2;
            groupBoxInput_BVN.TabStop = false;
            groupBoxInput_BVN.Text = "Ввод данных";
            // 
            // labelStopStep_BVN
            // 
            labelStopStep_BVN.AutoSize = true;
            labelStopStep_BVN.Location = new System.Drawing.Point(145, 19);
            labelStopStep_BVN.Name = "labelStopStep_BVN";
            labelStopStep_BVN.Size = new System.Drawing.Size(75, 15);
            labelStopStep_BVN.TabIndex = 3;
            labelStopStep_BVN.Text = "Конец шага:";
            // 
            // labelStartStep_BVN
            // 
            labelStartStep_BVN.AutoSize = true;
            labelStartStep_BVN.Location = new System.Drawing.Point(5, 19);
            labelStartStep_BVN.Name = "labelStartStep_BVN";
            labelStartStep_BVN.Size = new System.Drawing.Size(72, 15);
            labelStartStep_BVN.TabIndex = 2;
            labelStartStep_BVN.Text = "Старт шага:";
            // 
            // textBoxStopStep_BVN
            // 
            textBoxStopStep_BVN.Location = new System.Drawing.Point(148, 38);
            textBoxStopStep_BVN.Name = "textBoxStopStep_BVN";
            textBoxStopStep_BVN.Size = new System.Drawing.Size(129, 23);
            textBoxStopStep_BVN.TabIndex = 1;
            // 
            // textBoxStartStep_BVN
            // 
            textBoxStartStep_BVN.Location = new System.Drawing.Point(5, 38);
            textBoxStartStep_BVN.Name = "textBoxStartStep_BVN";
            textBoxStartStep_BVN.Size = new System.Drawing.Size(126, 23);
            textBoxStartStep_BVN.TabIndex = 0;
            textBoxStartStep_BVN.TextChanged += textBoxStartStep_GKU_TextChanged;
            // 
            // groupBoxTask_BVN
            // 
            groupBoxTask_BVN.Controls.Add(pictureBoxTask_BVN);
            groupBoxTask_BVN.Controls.Add(textBoxTask_BVN);
            groupBoxTask_BVN.Location = new System.Drawing.Point(12, 9);
            groupBoxTask_BVN.Name = "groupBoxTask_BVN";
            groupBoxTask_BVN.Size = new System.Drawing.Size(508, 322);
            groupBoxTask_BVN.TabIndex = 3;
            groupBoxTask_BVN.TabStop = false;
            groupBoxTask_BVN.Text = "Условие";
            // 
            // pictureBoxTask_BVN
            // 
            pictureBoxTask_BVN.Image = (System.Drawing.Image)resources.GetObject("pictureBoxTask_BVN.Image");
            pictureBoxTask_BVN.Location = new System.Drawing.Point(0, 65);
            pictureBoxTask_BVN.Name = "pictureBoxTask_BVN";
            pictureBoxTask_BVN.Size = new System.Drawing.Size(386, 59);
            pictureBoxTask_BVN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            pictureBoxTask_BVN.TabIndex = 1;
            pictureBoxTask_BVN.TabStop = false;
            // 
            // textBoxTask_BVN
            // 
            textBoxTask_BVN.BackColor = System.Drawing.SystemColors.Control;
            textBoxTask_BVN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBoxTask_BVN.Location = new System.Drawing.Point(9, 22);
            textBoxTask_BVN.Multiline = true;
            textBoxTask_BVN.Name = "textBoxTask_BVN";
            textBoxTask_BVN.Size = new System.Drawing.Size(331, 82);
            textBoxTask_BVN.TabIndex = 0;
            textBoxTask_BVN.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в  виде таблицы.";
            // 
            // groupBoxResult_BVN
            // 
            groupBoxResult_BVN.Controls.Add(labelResult_BVN);
            groupBoxResult_BVN.Controls.Add(textBoxResult_BVN);
            groupBoxResult_BVN.Location = new System.Drawing.Point(533, 17);
            groupBoxResult_BVN.Name = "groupBoxResult_BVN";
            groupBoxResult_BVN.Size = new System.Drawing.Size(282, 378);
            groupBoxResult_BVN.TabIndex = 4;
            groupBoxResult_BVN.TabStop = false;
            groupBoxResult_BVN.Text = "Вывод данных";
            // 
            // labelResult_BVN
            // 
            labelResult_BVN.AutoSize = true;
            labelResult_BVN.Location = new System.Drawing.Point(5, 19);
            labelResult_BVN.Name = "labelResult_BVN";
            labelResult_BVN.Size = new System.Drawing.Size(63, 15);
            labelResult_BVN.TabIndex = 1;
            labelResult_BVN.Text = "Результат:";
            labelResult_BVN.Click += labelResult_GKU_Click;
            // 
            // textBoxResult_BVN
            // 
            textBoxResult_BVN.BackColor = System.Drawing.SystemColors.Control;
            textBoxResult_BVN.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxResult_BVN.Location = new System.Drawing.Point(5, 38);
            textBoxResult_BVN.Multiline = true;
            textBoxResult_BVN.Name = "textBoxResult_BVN";
            textBoxResult_BVN.ReadOnly = true;
            textBoxResult_BVN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxResult_BVN.Size = new System.Drawing.Size(272, 335);
            textBoxResult_BVN.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(824, 422);
            Controls.Add(groupBoxResult_BVN);
            Controls.Add(groupBoxTask_BVN);
            Controls.Add(groupBoxInput_BVN);
            Controls.Add(buttonInfo_BVN);
            Controls.Add(buttonDone_BVN);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 |  Вариант 2 | Бекетов В.Н.";
            Load += FormMain_Load;
            groupBoxInput_BVN.ResumeLayout(false);
            groupBoxInput_BVN.PerformLayout();
            groupBoxTask_BVN.ResumeLayout(false);
            groupBoxTask_BVN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_BVN).EndInit();
            groupBoxResult_BVN.ResumeLayout(false);
            groupBoxResult_BVN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonDone_BVN;
        private System.Windows.Forms.Button buttonInfo_BVN;
        private System.Windows.Forms.GroupBox groupBoxInput_BVN;
        private System.Windows.Forms.Label labelStopStep_BVN;
        private System.Windows.Forms.Label labelStartStep_BVN;
        private System.Windows.Forms.TextBox textBoxStopStep_BVN;
        private System.Windows.Forms.TextBox textBoxStartStep_BVN;
        private System.Windows.Forms.GroupBox groupBoxTask_BVN;
        private System.Windows.Forms.TextBox textBoxTask_BVN;
        private System.Windows.Forms.GroupBox groupBoxResult_BVN;
        private System.Windows.Forms.Label labelResult_BVN;
        private System.Windows.Forms.TextBox textBoxResult_BVN;
        private System.Windows.Forms.PictureBox pictureBoxTask_BVN;
    }
}
