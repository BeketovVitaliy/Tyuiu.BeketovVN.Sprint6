namespace Tyuiu.BeketovVN.Sprint6.Task4.V21
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartResult_BVN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_BVN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BVN = new System.Windows.Forms.TextBox();
            this.groupBoxInput_BVN = new System.Windows.Forms.GroupBox();
            this.labelStopStep_BVN = new System.Windows.Forms.Label();
            this.labelStartStep_BVN = new System.Windows.Forms.Label();
            this.textBoxStopStep_BVN = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_BVN = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_BVN = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_BVN = new System.Windows.Forms.TextBox();
            this.buttonDone_BVN = new System.Windows.Forms.Button();
            this.buttonSave_BVN = new System.Windows.Forms.Button();
            this.buttonInfo_BVN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BVN)).BeginInit();
            this.groupBoxTask_BVN.SuspendLayout();
            this.groupBoxInput_BVN.SuspendLayout();
            this.groupBoxOutPut_BVN.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartResult_BVN
            // 
            chartArea2.Name = "ChartArea1";
            this.chartResult_BVN.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartResult_BVN.Legends.Add(legend2);
            this.chartResult_BVN.Location = new System.Drawing.Point(252, 62);
            this.chartResult_BVN.Name = "chartResult_BVN";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartResult_BVN.Series.Add(series2);
            this.chartResult_BVN.Size = new System.Drawing.Size(279, 297);
            this.chartResult_BVN.TabIndex = 0;
            this.chartResult_BVN.Text = "chart1";
            // 
            // groupBoxTask_BVN
            // 
            this.groupBoxTask_BVN.Controls.Add(this.textBoxTask_BVN);
            this.groupBoxTask_BVN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BVN.Name = "groupBoxTask_BVN";
            this.groupBoxTask_BVN.Size = new System.Drawing.Size(531, 82);
            this.groupBoxTask_BVN.TabIndex = 0;
            this.groupBoxTask_BVN.TabStop = false;
            this.groupBoxTask_BVN.Text = "Условие";
            // 
            // textBoxTask_BVN
            // 
            this.textBoxTask_BVN.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BVN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_BVN.Location = new System.Drawing.Point(8, 18);
            this.textBoxTask_BVN.Multiline = true;
            this.textBoxTask_BVN.Name = "textBoxTask_BVN";
            this.textBoxTask_BVN.Size = new System.Drawing.Size(517, 57);
            this.textBoxTask_BVN.TabIndex = 0;
            this.textBoxTask_BVN.TabStop = false;
            this.textBoxTask_BVN.Text = "Протабулировать функцию на заданном промежутке от -5 до 5.\r\nРезультат вывести в t" +
    "extBox, построить график функции и сохранить в файл OutPutFileTask.txt по нажати" +
    "ю кнопки.";
            // 
            // groupBoxInput_BVN
            // 
            this.groupBoxInput_BVN.Controls.Add(this.labelStopStep_BVN);
            this.groupBoxInput_BVN.Controls.Add(this.labelStartStep_BVN);
            this.groupBoxInput_BVN.Controls.Add(this.textBoxStopStep_BVN);
            this.groupBoxInput_BVN.Controls.Add(this.textBoxStartStep_BVN);
            this.groupBoxInput_BVN.Location = new System.Drawing.Point(537, 0);
            this.groupBoxInput_BVN.Name = "groupBoxInput_BVN";
            this.groupBoxInput_BVN.Size = new System.Drawing.Size(348, 82);
            this.groupBoxInput_BVN.TabIndex = 1;
            this.groupBoxInput_BVN.TabStop = false;
            this.groupBoxInput_BVN.Text = "Ввод данных";
            // 
            // labelStopStep_BVN
            // 
            this.labelStopStep_BVN.AutoSize = true;
            this.labelStopStep_BVN.Location = new System.Drawing.Point(174, 26);
            this.labelStopStep_BVN.Name = "labelStopStep_BVN";
            this.labelStopStep_BVN.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_BVN.TabIndex = 3;
            this.labelStopStep_BVN.Text = "Конец шага:";
            // 
            // labelStartStep_BVN
            // 
            this.labelStartStep_BVN.AutoSize = true;
            this.labelStartStep_BVN.Location = new System.Drawing.Point(6, 26);
            this.labelStartStep_BVN.Name = "labelStartStep_BVN";
            this.labelStartStep_BVN.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_BVN.TabIndex = 2;
            this.labelStartStep_BVN.Text = "Старт шага:";
            // 
            // textBoxStopStep_BVN
            // 
            this.textBoxStopStep_BVN.Location = new System.Drawing.Point(177, 46);
            this.textBoxStopStep_BVN.Name = "textBoxStopStep_BVN";
            this.textBoxStopStep_BVN.Size = new System.Drawing.Size(165, 20);
            this.textBoxStopStep_BVN.TabIndex = 1;
            this.textBoxStopStep_BVN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStopStep_BVN_KeyPress);
            // 
            // textBoxStartStep_BVN
            // 
            this.textBoxStartStep_BVN.Location = new System.Drawing.Point(6, 46);
            this.textBoxStartStep_BVN.Name = "textBoxStartStep_BVN";
            this.textBoxStartStep_BVN.Size = new System.Drawing.Size(165, 20);
            this.textBoxStartStep_BVN.TabIndex = 0;
            this.textBoxStartStep_BVN.TextChanged += new System.EventHandler(this.textBoxStartStep_BVN_TextChanged);
            this.textBoxStartStep_BVN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_BVN_KeyPress);
            // 
            // groupBoxOutPut_BVN
            // 
            this.groupBoxOutPut_BVN.Controls.Add(this.textBoxOutPut_BVN);
            this.groupBoxOutPut_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_BVN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_BVN.Name = "groupBoxOutPut_BVN";
            this.groupBoxOutPut_BVN.Size = new System.Drawing.Size(387, 514);
            this.groupBoxOutPut_BVN.TabIndex = 2;
            this.groupBoxOutPut_BVN.TabStop = false;
            this.groupBoxOutPut_BVN.Text = "Вывод:";
            this.groupBoxOutPut_BVN.Enter += new System.EventHandler(this.groupBoxOutPut_BVN_Enter);
            // 
            // textBoxOutPut_BVN
            // 
            this.textBoxOutPut_BVN.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxOutPut_BVN.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutPut_BVN.Multiline = true;
            this.textBoxOutPut_BVN.Name = "textBoxOutPut_BVN";
            this.textBoxOutPut_BVN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_BVN.Size = new System.Drawing.Size(382, 495);
            this.textBoxOutPut_BVN.TabIndex = 0;
            // 
            // buttonDone_BVN
            // 
            this.buttonDone_BVN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone_BVN.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone_BVN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_BVN.Location = new System.Drawing.Point(898, 9);
            this.buttonDone_BVN.Name = "buttonDone_BVN";
            this.buttonDone_BVN.Size = new System.Drawing.Size(109, 73);
            this.buttonDone_BVN.TabIndex = 4;
            this.buttonDone_BVN.Text = "Выполнить";
            this.buttonDone_BVN.UseVisualStyleBackColor = false;
            this.buttonDone_BVN.Click += new System.EventHandler(this.buttonDone_BVN_Click);
            // 
            // buttonSave_BVN
            // 
            this.buttonSave_BVN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave_BVN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSave_BVN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_BVN.Location = new System.Drawing.Point(1013, 10);
            this.buttonSave_BVN.Name = "buttonSave_BVN";
            this.buttonSave_BVN.Size = new System.Drawing.Size(103, 73);
            this.buttonSave_BVN.TabIndex = 5;
            this.buttonSave_BVN.Text = "Сохранить";
            this.buttonSave_BVN.UseVisualStyleBackColor = false;
            this.buttonSave_BVN.Click += new System.EventHandler(this.buttonSave_BVN_Click);
            // 
            // buttonInfo_BVN
            // 
            this.buttonInfo_BVN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_BVN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonInfo_BVN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_BVN.Location = new System.Drawing.Point(1122, 10);
            this.buttonInfo_BVN.Name = "buttonInfo_BVN";
            this.buttonInfo_BVN.Size = new System.Drawing.Size(108, 71);
            this.buttonInfo_BVN.TabIndex = 6;
            this.buttonInfo_BVN.Text = "Справка";
            this.buttonInfo_BVN.UseVisualStyleBackColor = false;
            this.buttonInfo_BVN.Click += new System.EventHandler(this.buttonInfo_BVN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxOutPut_BVN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 514);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxTask_BVN);
            this.panel2.Controls.Add(this.groupBoxInput_BVN);
            this.panel2.Controls.Add(this.buttonInfo_BVN);
            this.panel2.Controls.Add(this.buttonDone_BVN);
            this.panel2.Controls.Add(this.buttonSave_BVN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1242, 100);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartResult_BVN);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(387, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 514);
            this.panel3.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(387, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 514);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 614);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 |  Вариант 21 | Бекетов В.Н.";
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_BVN)).EndInit();
            this.groupBoxTask_BVN.ResumeLayout(false);
            this.groupBoxTask_BVN.PerformLayout();
            this.groupBoxInput_BVN.ResumeLayout(false);
            this.groupBoxInput_BVN.PerformLayout();
            this.groupBoxOutPut_BVN.ResumeLayout(false);
            this.groupBoxOutPut_BVN.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_BVN;
        private System.Windows.Forms.GroupBox groupBoxInput_BVN;
        private System.Windows.Forms.GroupBox groupBoxOutPut_BVN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_BVN;
        private System.Windows.Forms.Button buttonDone_BVN;
        private System.Windows.Forms.Button buttonSave_BVN;
        private System.Windows.Forms.Button buttonInfo_BVN;
        private System.Windows.Forms.TextBox textBoxTask_BVN;
        private System.Windows.Forms.Label labelStopStep_BVN;
        private System.Windows.Forms.Label labelStartStep_BVN;
        private System.Windows.Forms.TextBox textBoxStopStep_BVN;
        private System.Windows.Forms.TextBox textBoxStartStep_BVN;
        private System.Windows.Forms.TextBox textBoxOutPut_BVN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
    }
}

