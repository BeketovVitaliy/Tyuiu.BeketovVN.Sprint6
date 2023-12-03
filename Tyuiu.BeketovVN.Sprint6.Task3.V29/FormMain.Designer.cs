namespace Tyuiu.BeketovVN.Sprint6.Task3.V29
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
            this.groupBoxCondition_BVN = new System.Windows.Forms.GroupBox();
            this.dataGridViewData_BVN = new System.Windows.Forms.DataGridView();
            this.textBoxTask_BVN = new System.Windows.Forms.TextBox();
            this.groupBoxResult_BVN = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_BVN = new System.Windows.Forms.DataGridView();
            this.buttonHelp_BVN = new System.Windows.Forms.Button();
            this.buttonDone_BVN = new System.Windows.Forms.Button();
            this.groupBoxCondition_BVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_BVN)).BeginInit();
            this.groupBoxResult_BVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BVN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_BVN
            // 
            this.groupBoxCondition_BVN.Controls.Add(this.dataGridViewData_BVN);
            this.groupBoxCondition_BVN.Controls.Add(this.textBoxTask_BVN);
            this.groupBoxCondition_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCondition_BVN.Location = new System.Drawing.Point(9, 10);
            this.groupBoxCondition_BVN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCondition_BVN.Name = "groupBoxCondition_BVN";
            this.groupBoxCondition_BVN.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxCondition_BVN.Size = new System.Drawing.Size(477, 280);
            this.groupBoxCondition_BVN.TabIndex = 0;
            this.groupBoxCondition_BVN.TabStop = false;
            this.groupBoxCondition_BVN.Text = "Условие";
            this.groupBoxCondition_BVN.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewData_BVN
            // 
            this.dataGridViewData_BVN.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewData_BVN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewData_BVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_BVN.ColumnHeadersVisible = false;
            this.dataGridViewData_BVN.Location = new System.Drawing.Point(270, 21);
            this.dataGridViewData_BVN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewData_BVN.Name = "dataGridViewData_BVN";
            this.dataGridViewData_BVN.ReadOnly = true;
            this.dataGridViewData_BVN.RowHeadersVisible = false;
            this.dataGridViewData_BVN.RowHeadersWidth = 51;
            this.dataGridViewData_BVN.RowTemplate.Height = 24;
            this.dataGridViewData_BVN.Size = new System.Drawing.Size(202, 189);
            this.dataGridViewData_BVN.TabIndex = 0;
            this.dataGridViewData_BVN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBoxTask_BVN
            // 
            this.textBoxTask_BVN.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BVN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_BVN.Location = new System.Drawing.Point(5, 21);
            this.textBoxTask_BVN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTask_BVN.Multiline = true;
            this.textBoxTask_BVN.Name = "textBoxTask_BVN";
            this.textBoxTask_BVN.Size = new System.Drawing.Size(437, 242);
            this.textBoxTask_BVN.TabIndex = 0;
            this.textBoxTask_BVN.Text = "Дан массив 5 на 5 элементов. \r\nВыполнить сортировку по возрастанию \r\nв пятом ст" +
    "олбце.\r\n\r\n-2, -13, -15,  -9, -17\r\n13, -20, -15, 27, 18\r\n-12, -1, -20, 13, 0\r\n15, 32," +
    "  18, -12, -18\r\n16, 5, 3, -5, -8";
            // 
            // groupBoxResult_BVN
            // 
            this.groupBoxResult_BVN.Controls.Add(this.dataGridViewMatrix_BVN);
            this.groupBoxResult_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult_BVN.Location = new System.Drawing.Point(490, 10);
            this.groupBoxResult_BVN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResult_BVN.Name = "groupBoxResult_BVN";
            this.groupBoxResult_BVN.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxResult_BVN.Size = new System.Drawing.Size(212, 223);
            this.groupBoxResult_BVN.TabIndex = 0;
            this.groupBoxResult_BVN.TabStop = false;
            this.groupBoxResult_BVN.Text = "Вывод данных";
            this.groupBoxResult_BVN.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewMatrix_BVN
            // 
            this.dataGridViewMatrix_BVN.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMatrix_BVN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMatrix_BVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_BVN.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_BVN.Location = new System.Drawing.Point(5, 21);
            this.dataGridViewMatrix_BVN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMatrix_BVN.Name = "dataGridViewMatrix_BVN";
            this.dataGridViewMatrix_BVN.ReadOnly = true;
            this.dataGridViewMatrix_BVN.RowHeadersVisible = false;
            this.dataGridViewMatrix_BVN.RowHeadersWidth = 51;
            this.dataGridViewMatrix_BVN.RowTemplate.Height = 24;
            this.dataGridViewMatrix_BVN.Size = new System.Drawing.Size(202, 189);
            this.dataGridViewMatrix_BVN.TabIndex = 0;
            this.dataGridViewMatrix_BVN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonHelp_BVN
            // 
            this.buttonHelp_BVN.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonHelp_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_BVN.Location = new System.Drawing.Point(490, 238);
            this.buttonHelp_BVN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp_BVN.Name = "buttonHelp_BVN";
            this.buttonHelp_BVN.Size = new System.Drawing.Size(51, 52);
            this.buttonHelp_BVN.TabIndex = 1;
            this.buttonHelp_BVN.Text = "?";
            this.buttonHelp_BVN.UseVisualStyleBackColor = false;
            this.buttonHelp_BVN.Click += new System.EventHandler(this.buttonHelp_SME_Click);
            // 
            // buttonDone_BVN
            // 
            this.buttonDone_BVN.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonDone_BVN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_BVN.Location = new System.Drawing.Point(546, 238);
            this.buttonDone_BVN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDone_BVN.Name = "buttonDone_BVN";
            this.buttonDone_BVN.Size = new System.Drawing.Size(152, 52);
            this.buttonDone_BVN.TabIndex = 1;
            this.buttonDone_BVN.Text = "Выполнить";
            this.buttonDone_BVN.UseVisualStyleBackColor = false;
            this.buttonDone_BVN.Click += new System.EventHandler(this.buttonDone_SME_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 303);
            this.Controls.Add(this.buttonDone_BVN);
            this.Controls.Add(this.buttonHelp_BVN);
            this.Controls.Add(this.groupBoxResult_BVN);
            this.Controls.Add(this.groupBoxCondition_BVN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 29 | Бекетов Виталий Николаевич";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_BVN.ResumeLayout(false);
            this.groupBoxCondition_BVN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_BVN)).EndInit();
            this.groupBoxResult_BVN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_BVN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_BVN;
        private System.Windows.Forms.GroupBox groupBoxResult_BVN;
        private System.Windows.Forms.Button buttonHelp_BVN;
        private System.Windows.Forms.TextBox textBoxTask_BVN;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_BVN;
        private System.Windows.Forms.Button buttonDone_BVN;
        private System.Windows.Forms.DataGridView dataGridViewData_BVN;
    }
}

