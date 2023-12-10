namespace Tyuiu.BeketovVN.Sprint6.Task6.V25
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_BVN = new System.Windows.Forms.Panel();
            this.buttonHelp_BVN = new System.Windows.Forms.Button();
            this.buttonDone_BVN = new System.Windows.Forms.Button();
            this.buttonOpenFile_BVN = new System.Windows.Forms.Button();
            this.panelTask_BVN = new System.Windows.Forms.Panel();
            this.groupBoxTask_BVN = new System.Windows.Forms.GroupBox();
            this.textBoxTask_BVN = new System.Windows.Forms.TextBox();
            this.panelInput_BVN = new System.Windows.Forms.Panel();
            this.groupBoxInPut_BVN = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_BVN = new System.Windows.Forms.TextBox();
            this.splitterOutPut_BVN = new System.Windows.Forms.Splitter();
            this.panelOutPut_BVN = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_BVN = new System.Windows.Forms.GroupBox();
            this.textBoxOutPut_BVN = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_BVN = new System.Windows.Forms.OpenFileDialog();
            this.toolTipTask_BVN = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_BVN.SuspendLayout();
            this.panelTask_BVN.SuspendLayout();
            this.groupBoxTask_BVN.SuspendLayout();
            this.panelInput_BVN.SuspendLayout();
            this.groupBoxInPut_BVN.SuspendLayout();
            this.panelOutPut_BVN.SuspendLayout();
            this.groupBoxOutPut_BVN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_BVN
            // 
            this.panelButtons_BVN.Controls.Add(this.buttonHelp_BVN);
            this.panelButtons_BVN.Controls.Add(this.buttonDone_BVN);
            this.panelButtons_BVN.Controls.Add(this.buttonOpenFile_BVN);
            this.panelButtons_BVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_BVN.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.panelButtons_BVN.Name = "panelButtons_BVN";
            this.panelButtons_BVN.Size = new System.Drawing.Size(612, 54);
            this.panelButtons_BVN.TabIndex = 0;
            // 
            // buttonHelp_BVN
            // 
            this.buttonHelp_BVN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_BVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_BVN.Image")));
            this.buttonHelp_BVN.Location = new System.Drawing.Point(554, 2);
            this.buttonHelp_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_BVN.Name = "buttonHelp_BVN";
            this.buttonHelp_BVN.Size = new System.Drawing.Size(50, 50);
            this.buttonHelp_BVN.TabIndex = 0;
            this.toolTipTask_BVN.SetToolTip(this.buttonHelp_BVN, "Сведения о программе");
            this.buttonHelp_BVN.UseVisualStyleBackColor = true;
            this.buttonHelp_BVN.Click += new System.EventHandler(this.buttonHelp_BVN_Click);
            // 
            // buttonDone_BVN
            // 
            this.buttonDone_BVN.Enabled = false;
            this.buttonDone_BVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_BVN.Image")));
            this.buttonDone_BVN.Location = new System.Drawing.Point(65, 2);
            this.buttonDone_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_BVN.Name = "buttonDone_BVN";
            this.buttonDone_BVN.Size = new System.Drawing.Size(57, 50);
            this.buttonDone_BVN.TabIndex = 0;
            this.toolTipTask_BVN.SetToolTip(this.buttonDone_BVN, "Выводит первое слово каждой строки\r\nв результирующую строку");
            this.buttonDone_BVN.UseVisualStyleBackColor = true;
            this.buttonDone_BVN.Click += new System.EventHandler(this.buttonDone_BVN_Click);
            // 
            // buttonOpenFile_BVN
            // 
            this.buttonOpenFile_BVN.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_BVN.Image")));
            this.buttonOpenFile_BVN.Location = new System.Drawing.Point(4, 2);
            this.buttonOpenFile_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenFile_BVN.Name = "buttonOpenFile_BVN";
            this.buttonOpenFile_BVN.Size = new System.Drawing.Size(57, 50);
            this.buttonOpenFile_BVN.TabIndex = 0;
            this.toolTipTask_BVN.SetToolTip(this.buttonOpenFile_BVN, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_BVN.UseVisualStyleBackColor = true;
            this.buttonOpenFile_BVN.Click += new System.EventHandler(this.buttonOpenFile_BVN_Click);
            // 
            // panelTask_BVN
            // 
            this.panelTask_BVN.Controls.Add(this.groupBoxTask_BVN);
            this.panelTask_BVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_BVN.Location = new System.Drawing.Point(0, 54);
            this.panelTask_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.panelTask_BVN.Name = "panelTask_BVN";
            this.panelTask_BVN.Size = new System.Drawing.Size(612, 58);
            this.panelTask_BVN.TabIndex = 1;
            // 
            // groupBoxTask_BVN
            // 
            this.groupBoxTask_BVN.Controls.Add(this.textBoxTask_BVN);
            this.groupBoxTask_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_BVN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_BVN.Name = "groupBoxTask_BVN";
            this.groupBoxTask_BVN.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_BVN.Size = new System.Drawing.Size(612, 58);
            this.groupBoxTask_BVN.TabIndex = 0;
            this.groupBoxTask_BVN.TabStop = false;
            this.groupBoxTask_BVN.Text = "Условие:";
            // 
            // textBoxTask_BVN
            // 
            this.textBoxTask_BVN.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_BVN.Location = new System.Drawing.Point(2, 15);
            this.textBoxTask_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTask_BVN.Multiline = true;
            this.textBoxTask_BVN.Name = "textBoxTask_BVN";
            this.textBoxTask_BVN.ReadOnly = true;
            this.textBoxTask_BVN.Size = new System.Drawing.Size(608, 41);
            this.textBoxTask_BVN.TabIndex = 0;
            this.textBoxTask_BVN.Text = resources.GetString("textBoxTask_BVN.Text");
            // 
            // panelInput_BVN
            // 
            this.panelInput_BVN.Controls.Add(this.groupBoxInPut_BVN);
            this.panelInput_BVN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput_BVN.Location = new System.Drawing.Point(0, 112);
            this.panelInput_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.panelInput_BVN.Name = "panelInput_BVN";
            this.panelInput_BVN.Size = new System.Drawing.Size(292, 276);
            this.panelInput_BVN.TabIndex = 2;
            // 
            // groupBoxInPut_BVN
            // 
            this.groupBoxInPut_BVN.Controls.Add(this.textBoxInPut_BVN);
            this.groupBoxInPut_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_BVN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInPut_BVN.Name = "groupBoxInPut_BVN";
            this.groupBoxInPut_BVN.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInPut_BVN.Size = new System.Drawing.Size(292, 276);
            this.groupBoxInPut_BVN.TabIndex = 0;
            this.groupBoxInPut_BVN.TabStop = false;
            this.groupBoxInPut_BVN.Text = "Ввод:";
            // 
            // textBoxInPut_BVN
            // 
            this.textBoxInPut_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_BVN.Location = new System.Drawing.Point(2, 15);
            this.textBoxInPut_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInPut_BVN.Multiline = true;
            this.textBoxInPut_BVN.Name = "textBoxInPut_BVN";
            this.textBoxInPut_BVN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_BVN.Size = new System.Drawing.Size(288, 259);
            this.textBoxInPut_BVN.TabIndex = 0;
            // 
            // splitterOutPut_BVN
            // 
            this.splitterOutPut_BVN.Location = new System.Drawing.Point(292, 112);
            this.splitterOutPut_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.splitterOutPut_BVN.Name = "splitterOutPut_BVN";
            this.splitterOutPut_BVN.Size = new System.Drawing.Size(6, 276);
            this.splitterOutPut_BVN.TabIndex = 3;
            this.splitterOutPut_BVN.TabStop = false;
            // 
            // panelOutPut_BVN
            // 
            this.panelOutPut_BVN.Controls.Add(this.groupBoxOutPut_BVN);
            this.panelOutPut_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_BVN.Location = new System.Drawing.Point(298, 112);
            this.panelOutPut_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.panelOutPut_BVN.Name = "panelOutPut_BVN";
            this.panelOutPut_BVN.Size = new System.Drawing.Size(314, 276);
            this.panelOutPut_BVN.TabIndex = 4;
            // 
            // groupBoxOutPut_BVN
            // 
            this.groupBoxOutPut_BVN.Controls.Add(this.textBoxOutPut_BVN);
            this.groupBoxOutPut_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_BVN.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxOutPut_BVN.Name = "groupBoxOutPut_BVN";
            this.groupBoxOutPut_BVN.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxOutPut_BVN.Size = new System.Drawing.Size(314, 276);
            this.groupBoxOutPut_BVN.TabIndex = 0;
            this.groupBoxOutPut_BVN.TabStop = false;
            this.groupBoxOutPut_BVN.Text = "Вывод:";
            // 
            // textBoxOutPut_BVN
            // 
            this.textBoxOutPut_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutPut_BVN.Location = new System.Drawing.Point(2, 15);
            this.textBoxOutPut_BVN.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOutPut_BVN.Multiline = true;
            this.textBoxOutPut_BVN.Name = "textBoxOutPut_BVN";
            this.textBoxOutPut_BVN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPut_BVN.Size = new System.Drawing.Size(310, 259);
            this.textBoxOutPut_BVN.TabIndex = 0;
            // 
            // openFileDialogTask_BVN
            // 
            this.openFileDialogTask_BVN.FileName = "openFileDialogTask_GKU";
            // 
            // toolTipTask_BVN
            // 
            this.toolTipTask_BVN.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipTask_BVN.ToolTipTitle = "Подсказка";
            this.toolTipTask_BVN.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipTask_BVN_Popup);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 388);
            this.Controls.Add(this.panelOutPut_BVN);
            this.Controls.Add(this.splitterOutPut_BVN);
            this.Controls.Add(this.panelInput_BVN);
            this.Controls.Add(this.panelTask_BVN);
            this.Controls.Add(this.panelButtons_BVN);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 |  Вариант 25 | Бекетов В.Н.";
            this.panelButtons_BVN.ResumeLayout(false);
            this.panelTask_BVN.ResumeLayout(false);
            this.groupBoxTask_BVN.ResumeLayout(false);
            this.groupBoxTask_BVN.PerformLayout();
            this.panelInput_BVN.ResumeLayout(false);
            this.groupBoxInPut_BVN.ResumeLayout(false);
            this.groupBoxInPut_BVN.PerformLayout();
            this.panelOutPut_BVN.ResumeLayout(false);
            this.groupBoxOutPut_BVN.ResumeLayout(false);
            this.groupBoxOutPut_BVN.PerformLayout();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel panelButtons_BVN;
        private System.Windows.Forms.Panel panelTask_BVN;
        private System.Windows.Forms.GroupBox groupBoxTask_BVN;
        private System.Windows.Forms.TextBox textBoxTask_BVN;
        private System.Windows.Forms.Panel panelInput_BVN;
        private System.Windows.Forms.GroupBox groupBoxInPut_BVN;
        private System.Windows.Forms.Splitter splitterOutPut_BVN;
        private System.Windows.Forms.Panel panelOutPut_BVN;
        private System.Windows.Forms.GroupBox groupBoxOutPut_BVN;
        private System.Windows.Forms.Button buttonHelp_BVN;
        private System.Windows.Forms.Button buttonDone_BVN;
        private System.Windows.Forms.Button buttonOpenFile_BVN;
        private System.Windows.Forms.ToolTip toolTipTask_BVN;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_BVN;
        private System.Windows.Forms.TextBox textBoxInPut_BVN;
        private System.Windows.Forms.TextBox textBoxOutPut_BVN;
    }
}

