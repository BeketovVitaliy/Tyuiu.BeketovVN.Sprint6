namespace Tyuiu.BeketovVN.Sprint6.Task2.V8
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonDone_BVN = new System.Windows.Forms.Button();
            this.buttonInfo_BVN = new System.Windows.Forms.Button();
            this.groupBoxInput_BVN = new System.Windows.Forms.GroupBox();
            this.labelStopStep_BVN = new System.Windows.Forms.Label();
            this.labelStartStep_BVN = new System.Windows.Forms.Label();
            this.textBoxStopStep_BVN = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_BVN = new System.Windows.Forms.TextBox();
            this.groupBoxTask_BVN = new System.Windows.Forms.GroupBox();
            this.pictureBoxTask_BVN = new System.Windows.Forms.PictureBox();
            this.textBoxTask_BVN = new System.Windows.Forms.TextBox();
            this.groupBoxResult_BVN = new System.Windows.Forms.GroupBox();
            this.chart_BVN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_BVN = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelResult_BVN = new System.Windows.Forms.Label();
            this.groupBoxInput_BVN.SuspendLayout();
            this.groupBoxTask_BVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_BVN)).BeginInit();
            this.groupBoxResult_BVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BVN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BVN)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_BVN
            // 
            this.buttonDone_BVN.BackColor = System.Drawing.Color.Green;
            this.buttonDone_BVN.Location = new System.Drawing.Point(342, 293);
            this.buttonDone_BVN.Name = "buttonDone_BVN";
            this.buttonDone_BVN.Size = new System.Drawing.Size(104, 50);
            this.buttonDone_BVN.TabIndex = 0;
            this.buttonDone_BVN.Text = "Выполнить";
            this.buttonDone_BVN.UseMnemonic = false;
            this.buttonDone_BVN.UseVisualStyleBackColor = false;
            this.buttonDone_BVN.Click += new System.EventHandler(this.buttonDone_BVN_Click);
            // 
            // buttonInfo_BVN
            // 
            this.buttonInfo_BVN.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_BVN.Location = new System.Drawing.Point(264, 293);
            this.buttonInfo_BVN.Name = "buttonInfo_BVN";
            this.buttonInfo_BVN.Size = new System.Drawing.Size(74, 50);
            this.buttonInfo_BVN.TabIndex = 1;
            this.buttonInfo_BVN.Text = "Справка";
            this.buttonInfo_BVN.UseVisualStyleBackColor = false;
            // 
            // groupBoxInput_BVN
            // 
            this.groupBoxInput_BVN.Controls.Add(this.labelStopStep_BVN);
            this.groupBoxInput_BVN.Controls.Add(this.labelStartStep_BVN);
            this.groupBoxInput_BVN.Controls.Add(this.textBoxStopStep_BVN);
            this.groupBoxInput_BVN.Controls.Add(this.textBoxStartStep_BVN);
            this.groupBoxInput_BVN.Location = new System.Drawing.Point(9, 288);
            this.groupBoxInput_BVN.Name = "groupBoxInput_BVN";
            this.groupBoxInput_BVN.Size = new System.Drawing.Size(243, 55);
            this.groupBoxInput_BVN.TabIndex = 2;
            this.groupBoxInput_BVN.TabStop = false;
            this.groupBoxInput_BVN.Text = "Ввод данных";
            // 
            // labelStopStep_BVN
            // 
            this.labelStopStep_BVN.AutoSize = true;
            this.labelStopStep_BVN.Location = new System.Drawing.Point(124, 16);
            this.labelStopStep_BVN.Name = "labelStopStep_BVN";
            this.labelStopStep_BVN.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_BVN.TabIndex = 3;
            this.labelStopStep_BVN.Text = "Конец шага:";
            // 
            // labelStartStep_BVN
            // 
            this.labelStartStep_BVN.AutoSize = true;
            this.labelStartStep_BVN.Location = new System.Drawing.Point(4, 16);
            this.labelStartStep_BVN.Name = "labelStartStep_BVN";
            this.labelStartStep_BVN.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_BVN.TabIndex = 2;
            this.labelStartStep_BVN.Text = "Старт шага:";
            // 
            // textBoxStopStep_BVN
            // 
            this.textBoxStopStep_BVN.Location = new System.Drawing.Point(127, 33);
            this.textBoxStopStep_BVN.Name = "textBoxStopStep_BVN";
            this.textBoxStopStep_BVN.Size = new System.Drawing.Size(111, 20);
            this.textBoxStopStep_BVN.TabIndex = 1;
            // 
            // textBoxStartStep_BVN
            // 
            this.textBoxStartStep_BVN.Location = new System.Drawing.Point(4, 33);
            this.textBoxStartStep_BVN.Name = "textBoxStartStep_BVN";
            this.textBoxStartStep_BVN.Size = new System.Drawing.Size(109, 20);
            this.textBoxStartStep_BVN.TabIndex = 0;
            this.textBoxStartStep_BVN.TextChanged += new System.EventHandler(this.textBoxStartStep_BVN_TextChanged);
            // 
            // groupBoxTask_BVN
            // 
            this.groupBoxTask_BVN.Controls.Add(this.pictureBoxTask_BVN);
            this.groupBoxTask_BVN.Controls.Add(this.textBoxTask_BVN);
            this.groupBoxTask_BVN.Location = new System.Drawing.Point(10, 8);
            this.groupBoxTask_BVN.Name = "groupBoxTask_BVN";
            this.groupBoxTask_BVN.Size = new System.Drawing.Size(435, 279);
            this.groupBoxTask_BVN.TabIndex = 3;
            this.groupBoxTask_BVN.TabStop = false;
            this.groupBoxTask_BVN.Text = "Условие";
            // 
            // pictureBoxTask_BVN
            // 
            this.pictureBoxTask_BVN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTask_BVN.Image")));
            this.pictureBoxTask_BVN.Location = new System.Drawing.Point(-1, 96);
            this.pictureBoxTask_BVN.Name = "pictureBoxTask_BVN";
            this.pictureBoxTask_BVN.Size = new System.Drawing.Size(340, 54);
            this.pictureBoxTask_BVN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxTask_BVN.TabIndex = 1;
            this.pictureBoxTask_BVN.TabStop = false;
            // 
            // textBoxTask_BVN
            // 
            this.textBoxTask_BVN.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BVN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BVN.Location = new System.Drawing.Point(8, 19);
            this.textBoxTask_BVN.Multiline = true;
            this.textBoxTask_BVN.Name = "textBoxTask_BVN";
            this.textBoxTask_BVN.Size = new System.Drawing.Size(284, 71);
            this.textBoxTask_BVN.TabIndex = 0;
            this.textBoxTask_BVN.Text = "Протабулировать функцию Sin(x) на заданном диапозоне.\r\nРезультат вывести в DataGr" +
    "idView.\r\n";
            this.textBoxTask_BVN.TextChanged += new System.EventHandler(this.textBoxTask_BVN_TextChanged);
            // 
            // groupBoxResult_BVN
            // 
            this.groupBoxResult_BVN.Controls.Add(this.chart_BVN);
            this.groupBoxResult_BVN.Controls.Add(this.dataGridView_BVN);
            this.groupBoxResult_BVN.Controls.Add(this.labelResult_BVN);
            this.groupBoxResult_BVN.Location = new System.Drawing.Point(457, 15);
            this.groupBoxResult_BVN.Name = "groupBoxResult_BVN";
            this.groupBoxResult_BVN.Size = new System.Drawing.Size(582, 328);
            this.groupBoxResult_BVN.TabIndex = 4;
            this.groupBoxResult_BVN.TabStop = false;
            this.groupBoxResult_BVN.Text = "Вывод данных";
            // 
            // chart_BVN
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_BVN.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_BVN.Legends.Add(legend3);
            this.chart_BVN.Location = new System.Drawing.Point(176, 16);
            this.chart_BVN.Name = "chart_BVN";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_BVN.Series.Add(series3);
            this.chart_BVN.Size = new System.Drawing.Size(400, 300);
            this.chart_BVN.TabIndex = 3;
            this.chart_BVN.Text = "chart1";
            this.chart_BVN.Click += new System.EventHandler(this.chart_BVN_Click);
            // 
            // dataGridView_BVN
            // 
            this.dataGridView_BVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BVN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView_BVN.Location = new System.Drawing.Point(44, 29);
            this.dataGridView_BVN.Name = "dataGridView_BVN";
            this.dataGridView_BVN.RowHeadersVisible = false;
            this.dataGridView_BVN.Size = new System.Drawing.Size(104, 273);
            this.dataGridView_BVN.TabIndex = 2;
            this.dataGridView_BVN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(x)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // labelResult_BVN
            // 
            this.labelResult_BVN.AutoSize = true;
            this.labelResult_BVN.Location = new System.Drawing.Point(4, 16);
            this.labelResult_BVN.Name = "labelResult_BVN";
            this.labelResult_BVN.Size = new System.Drawing.Size(62, 13);
            this.labelResult_BVN.TabIndex = 1;
            this.labelResult_BVN.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 366);
            this.Controls.Add(this.groupBoxResult_BVN);
            this.Controls.Add(this.groupBoxTask_BVN);
            this.Controls.Add(this.groupBoxInput_BVN);
            this.Controls.Add(this.buttonInfo_BVN);
            this.Controls.Add(this.buttonDone_BVN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 |  Вариант 2 | Бекетов В.Н.";
            this.groupBoxInput_BVN.ResumeLayout(false);
            this.groupBoxInput_BVN.PerformLayout();
            this.groupBoxTask_BVN.ResumeLayout(false);
            this.groupBoxTask_BVN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTask_BVN)).EndInit();
            this.groupBoxResult_BVN.ResumeLayout(false);
            this.groupBoxResult_BVN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_BVN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BVN)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pictureBoxTask_BVN;
        private System.Windows.Forms.DataGridView dataGridView_BVN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_BVN;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}

