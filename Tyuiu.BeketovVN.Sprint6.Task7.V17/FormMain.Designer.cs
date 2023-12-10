namespace Tyuiu.BeketovVN.Sprint6.Task7.V17
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.PanelTop_BVN = new System.Windows.Forms.Panel();
            this.ButtonInfo_BVN = new System.Windows.Forms.Button();
            this.ButtonSave_BVN = new System.Windows.Forms.Button();
            this.ButtonDone_BVN = new System.Windows.Forms.Button();
            this.ButtonOpen_BVN = new System.Windows.Forms.Button();
            this.PanelTask_BVN = new System.Windows.Forms.Panel();
            this.GroupBoxTask_BVN = new System.Windows.Forms.GroupBox();
            this.TextBoxTask_BVN = new System.Windows.Forms.TextBox();
            this.PanelLeft_BVN = new System.Windows.Forms.Panel();
            this.GroupBoxInput_BVN = new System.Windows.Forms.GroupBox();
            this.DataGridViewInput_BVN = new System.Windows.Forms.DataGridView();
            this.PanelFill_BVN = new System.Windows.Forms.Panel();
            this.GroupBoxOutput_BVN = new System.Windows.Forms.GroupBox();
            this.DataGridViewOutput_BVN = new System.Windows.Forms.DataGridView();
            this.Splitter_BVN = new System.Windows.Forms.Splitter();
            this.OpenFileDialog_BVN = new System.Windows.Forms.OpenFileDialog();
            this.ToolTip_BVN = new System.Windows.Forms.ToolTip(this.components);
            this.SaveFileDialog_BVN = new System.Windows.Forms.SaveFileDialog();
            this.PanelTop_BVN.SuspendLayout();
            this.PanelTask_BVN.SuspendLayout();
            this.GroupBoxTask_BVN.SuspendLayout();
            this.PanelLeft_BVN.SuspendLayout();
            this.GroupBoxInput_BVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInput_BVN)).BeginInit();
            this.PanelFill_BVN.SuspendLayout();
            this.GroupBoxOutput_BVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutput_BVN)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop_BVN
            // 
            this.PanelTop_BVN.Controls.Add(this.ButtonInfo_BVN);
            this.PanelTop_BVN.Controls.Add(this.ButtonSave_BVN);
            this.PanelTop_BVN.Controls.Add(this.ButtonDone_BVN);
            this.PanelTop_BVN.Controls.Add(this.ButtonOpen_BVN);
            this.PanelTop_BVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop_BVN.Location = new System.Drawing.Point(0, 0);
            this.PanelTop_BVN.Name = "PanelTop_BVN";
            this.PanelTop_BVN.Size = new System.Drawing.Size(904, 100);
            this.PanelTop_BVN.TabIndex = 0;
            // 
            // ButtonInfo_BVN
            // 
            this.ButtonInfo_BVN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInfo_BVN.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonInfo_BVN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonInfo_BVN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfo_BVN.Image = ((System.Drawing.Image)(resources.GetObject("ButtonInfo_BVN.Image")));
            this.ButtonInfo_BVN.Location = new System.Drawing.Point(783, 12);
            this.ButtonInfo_BVN.Name = "ButtonInfo_BVN";
            this.ButtonInfo_BVN.Size = new System.Drawing.Size(106, 82);
            this.ButtonInfo_BVN.TabIndex = 3;
            this.ButtonInfo_BVN.UseVisualStyleBackColor = false;
            this.ButtonInfo_BVN.Click += new System.EventHandler(this.ButtonInfo_BVN_Click);
            // 
            // ButtonSave_BVN
            // 
            this.ButtonSave_BVN.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonSave_BVN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonSave_BVN.Enabled = false;
            this.ButtonSave_BVN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave_BVN.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSave_BVN.Image")));
            this.ButtonSave_BVN.Location = new System.Drawing.Point(225, 12);
            this.ButtonSave_BVN.Name = "ButtonSave_BVN";
            this.ButtonSave_BVN.Size = new System.Drawing.Size(100, 82);
            this.ButtonSave_BVN.TabIndex = 2;
            this.ToolTip_BVN.SetToolTip(this.ButtonSave_BVN, "Сохранить обработанные данные в файл в формате CSV");
            this.ButtonSave_BVN.UseVisualStyleBackColor = false;
            this.ButtonSave_BVN.Click += new System.EventHandler(this.ButtonSave_BVN_Click);
            this.ButtonSave_BVN.MouseEnter += new System.EventHandler(this.ButtonSave_BVN_MouseEnter);
            // 
            // ButtonDone_BVN
            // 
            this.ButtonDone_BVN.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonDone_BVN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonDone_BVN.Enabled = false;
            this.ButtonDone_BVN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDone_BVN.Image = ((System.Drawing.Image)(resources.GetObject("ButtonDone_BVN.Image")));
            this.ButtonDone_BVN.Location = new System.Drawing.Point(119, 12);
            this.ButtonDone_BVN.Name = "ButtonDone_BVN";
            this.ButtonDone_BVN.Size = new System.Drawing.Size(100, 82);
            this.ButtonDone_BVN.TabIndex = 1;
            this.ToolTip_BVN.SetToolTip(this.ButtonDone_BVN, "Выполнить обработку данных");
            this.ButtonDone_BVN.UseVisualStyleBackColor = false;
            this.ButtonDone_BVN.Click += new System.EventHandler(this.ButtonDone_BVN_Click);
            this.ButtonDone_BVN.MouseEnter += new System.EventHandler(this.ButtonDone_BVN_MouseEnter);
            // 
            // ButtonOpen_BVN
            // 
            this.ButtonOpen_BVN.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonOpen_BVN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonOpen_BVN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOpen_BVN.Image = ((System.Drawing.Image)(resources.GetObject("ButtonOpen_BVN.Image")));
            this.ButtonOpen_BVN.Location = new System.Drawing.Point(12, 12);
            this.ButtonOpen_BVN.Name = "ButtonOpen_BVN";
            this.ButtonOpen_BVN.Size = new System.Drawing.Size(101, 82);
            this.ButtonOpen_BVN.TabIndex = 0;
            this.ToolTip_BVN.SetToolTip(this.ButtonOpen_BVN, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.ButtonOpen_BVN.UseVisualStyleBackColor = false;
            this.ButtonOpen_BVN.Click += new System.EventHandler(this.ButtonOpen_BVN_Click);
            this.ButtonOpen_BVN.MouseEnter += new System.EventHandler(this.ButtonOpen_BVN_MouseEnter);
            // 
            // PanelTask_BVN
            // 
            this.PanelTask_BVN.Controls.Add(this.GroupBoxTask_BVN);
            this.PanelTask_BVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTask_BVN.Location = new System.Drawing.Point(0, 100);
            this.PanelTask_BVN.Name = "PanelTask_BVN";
            this.PanelTask_BVN.Size = new System.Drawing.Size(904, 100);
            this.PanelTask_BVN.TabIndex = 1;
            // 
            // GroupBoxTask_BVN
            // 
            this.GroupBoxTask_BVN.Controls.Add(this.TextBoxTask_BVN);
            this.GroupBoxTask_BVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBoxTask_BVN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxTask_BVN.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxTask_BVN.Name = "GroupBoxTask_BVN";
            this.GroupBoxTask_BVN.Size = new System.Drawing.Size(904, 100);
            this.GroupBoxTask_BVN.TabIndex = 0;
            this.GroupBoxTask_BVN.TabStop = false;
            this.GroupBoxTask_BVN.Text = "Условие";
            // 
            // TextBoxTask_BVN
            // 
            this.TextBoxTask_BVN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTask_BVN.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxTask_BVN.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTask_BVN.Location = new System.Drawing.Point(3, 22);
            this.TextBoxTask_BVN.Multiline = true;
            this.TextBoxTask_BVN.Name = "TextBoxTask_BVN";
            this.TextBoxTask_BVN.ReadOnly = true;
            this.TextBoxTask_BVN.Size = new System.Drawing.Size(898, 72);
            this.TextBoxTask_BVN.TabIndex = 0;
            this.TextBoxTask_BVN.TabStop = false;
            this.TextBoxTask_BVN.Text = resources.GetString("TextBoxTask_BVN.Text");
            // 
            // PanelLeft_BVN
            // 
            this.PanelLeft_BVN.BackColor = System.Drawing.SystemColors.Control;
            this.PanelLeft_BVN.Controls.Add(this.GroupBoxInput_BVN);
            this.PanelLeft_BVN.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLeft_BVN.Location = new System.Drawing.Point(0, 200);
            this.PanelLeft_BVN.Name = "PanelLeft_BVN";
            this.PanelLeft_BVN.Size = new System.Drawing.Size(438, 261);
            this.PanelLeft_BVN.TabIndex = 2;
            // 
            // GroupBoxInput_BVN
            // 
            this.GroupBoxInput_BVN.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBoxInput_BVN.Controls.Add(this.DataGridViewInput_BVN);
            this.GroupBoxInput_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxInput_BVN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxInput_BVN.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxInput_BVN.Name = "GroupBoxInput_BVN";
            this.GroupBoxInput_BVN.Size = new System.Drawing.Size(438, 261);
            this.GroupBoxInput_BVN.TabIndex = 0;
            this.GroupBoxInput_BVN.TabStop = false;
            this.GroupBoxInput_BVN.Text = "Ввод";
            // 
            // DataGridViewInput_BVN
            // 
            this.DataGridViewInput_BVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewInput_BVN.ColumnHeadersVisible = false;
            this.DataGridViewInput_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewInput_BVN.Location = new System.Drawing.Point(3, 22);
            this.DataGridViewInput_BVN.Name = "DataGridViewInput_BVN";
            this.DataGridViewInput_BVN.RowHeadersVisible = false;
            this.DataGridViewInput_BVN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewInput_BVN.Size = new System.Drawing.Size(432, 236);
            this.DataGridViewInput_BVN.TabIndex = 0;
            // 
            // PanelFill_BVN
            // 
            this.PanelFill_BVN.Controls.Add(this.GroupBoxOutput_BVN);
            this.PanelFill_BVN.Controls.Add(this.Splitter_BVN);
            this.PanelFill_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFill_BVN.Location = new System.Drawing.Point(438, 200);
            this.PanelFill_BVN.Name = "PanelFill_BVN";
            this.PanelFill_BVN.Size = new System.Drawing.Size(466, 261);
            this.PanelFill_BVN.TabIndex = 3;
            // 
            // GroupBoxOutput_BVN
            // 
            this.GroupBoxOutput_BVN.Controls.Add(this.DataGridViewOutput_BVN);
            this.GroupBoxOutput_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxOutput_BVN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxOutput_BVN.Location = new System.Drawing.Point(3, 0);
            this.GroupBoxOutput_BVN.Name = "GroupBoxOutput_BVN";
            this.GroupBoxOutput_BVN.Size = new System.Drawing.Size(463, 261);
            this.GroupBoxOutput_BVN.TabIndex = 1;
            this.GroupBoxOutput_BVN.TabStop = false;
            this.GroupBoxOutput_BVN.Text = "Вывод";
            // 
            // DataGridViewOutput_BVN
            // 
            this.DataGridViewOutput_BVN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewOutput_BVN.ColumnHeadersVisible = false;
            this.DataGridViewOutput_BVN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewOutput_BVN.Location = new System.Drawing.Point(3, 22);
            this.DataGridViewOutput_BVN.Name = "DataGridViewOutput_BVN";
            this.DataGridViewOutput_BVN.RowHeadersVisible = false;
            this.DataGridViewOutput_BVN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataGridViewOutput_BVN.Size = new System.Drawing.Size(457, 236);
            this.DataGridViewOutput_BVN.TabIndex = 0;
            // 
            // Splitter_BVN
            // 
            this.Splitter_BVN.Location = new System.Drawing.Point(0, 0);
            this.Splitter_BVN.Name = "Splitter_BVN";
            this.Splitter_BVN.Size = new System.Drawing.Size(3, 261);
            this.Splitter_BVN.TabIndex = 0;
            this.Splitter_BVN.TabStop = false;
            // 
            // OpenFileDialog_BVN
            // 
            this.OpenFileDialog_BVN.FileName = "openFileDialog1";
            // 
            // ToolTip_BVN
            // 
            this.ToolTip_BVN.IsBalloon = true;
            this.ToolTip_BVN.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.PanelFill_BVN);
            this.Controls.Add(this.PanelLeft_BVN);
            this.Controls.Add(this.PanelTask_BVN);
            this.Controls.Add(this.PanelTop_BVN);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(920, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 17 | Бекетов В.Н.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelTop_BVN.ResumeLayout(false);
            this.PanelTask_BVN.ResumeLayout(false);
            this.GroupBoxTask_BVN.ResumeLayout(false);
            this.GroupBoxTask_BVN.PerformLayout();
            this.PanelLeft_BVN.ResumeLayout(false);
            this.GroupBoxInput_BVN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewInput_BVN)).EndInit();
            this.PanelFill_BVN.ResumeLayout(false);
            this.GroupBoxOutput_BVN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOutput_BVN)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Panel PanelTop_BVN;
        private System.Windows.Forms.Panel PanelTask_BVN;
        private System.Windows.Forms.GroupBox GroupBoxTask_BVN;
        private System.Windows.Forms.Panel PanelLeft_BVN;
        private System.Windows.Forms.GroupBox GroupBoxInput_BVN;
        private System.Windows.Forms.DataGridView DataGridViewInput_BVN;
        private System.Windows.Forms.Panel PanelFill_BVN;
        private System.Windows.Forms.GroupBox GroupBoxOutput_BVN;
        private System.Windows.Forms.DataGridView DataGridViewOutput_BVN;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog_BVN;
        private System.Windows.Forms.ToolTip ToolTip_BVN;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog_BVN;
        private System.Windows.Forms.Button ButtonInfo_BVN;
        private System.Windows.Forms.Button ButtonSave_BVN;
        private System.Windows.Forms.Button ButtonDone_BVN;
        private System.Windows.Forms.Button ButtonOpen_BVN;
        private System.Windows.Forms.TextBox TextBoxTask_BVN;
        private System.Windows.Forms.Splitter Splitter_BVN;
    }
}

