namespace Tyuiu.BeketovVN.Sprint6.Task6.V25
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.textBoxInfo_BVN = new System.Windows.Forms.TextBox();
            this.buttonOK_BVN = new System.Windows.Forms.Button();
            this.pictureBox_BVN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BVN)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInfo_BVN
            // 
            this.textBoxInfo_BVN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_BVN.Location = new System.Drawing.Point(200, 11);
            this.textBoxInfo_BVN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxInfo_BVN.Multiline = true;
            this.textBoxInfo_BVN.Name = "textBoxInfo_BVN";
            this.textBoxInfo_BVN.ReadOnly = true;
            this.textBoxInfo_BVN.Size = new System.Drawing.Size(279, 149);
            this.textBoxInfo_BVN.TabIndex = 0;
            this.textBoxInfo_BVN.TabStop = false;
            this.textBoxInfo_BVN.Text = "Разработчик: Бекетов В.Н.\r\nгруппа ИИПб-23-2\r\n\r\nПрограммма разработана в рамках из" +
    "учения языка C#\r\n\r\nТИУ(с) 2023\r\nВШЦТ(с) 2023\r\n\r\nВнутренее имя: Tyuiu.BeketovVN.S" +
    "print6.Task6.V25\r\n";
            this.textBoxInfo_BVN.TextChanged += new System.EventHandler(this.textBoxInfo_BVN_TextChanged);
            // 
            // buttonOK_BVN
            // 
            this.buttonOK_BVN.Location = new System.Drawing.Point(280, 182);
            this.buttonOK_BVN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOK_BVN.Name = "buttonOK_BVN";
            this.buttonOK_BVN.Size = new System.Drawing.Size(87, 24);
            this.buttonOK_BVN.TabIndex = 1;
            this.buttonOK_BVN.Text = "Ок";
            this.buttonOK_BVN.UseVisualStyleBackColor = true;
            this.buttonOK_BVN.Click += new System.EventHandler(this.buttonOK_BVN_Click);
            // 
            // pictureBox_BVN
            // 
            this.pictureBox_BVN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_BVN.Image")));
            this.pictureBox_BVN.Location = new System.Drawing.Point(7, 4);
            this.pictureBox_BVN.Name = "pictureBox_BVN";
            this.pictureBox_BVN.Size = new System.Drawing.Size(188, 202);
            this.pictureBox_BVN.TabIndex = 2;
            this.pictureBox_BVN.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 213);
            this.Controls.Add(this.pictureBox_BVN);
            this.Controls.Add(this.buttonOK_BVN);
            this.Controls.Add(this.textBoxInfo_BVN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BVN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.TextBox textBoxInfo_BVN;
        private System.Windows.Forms.Button buttonOK_BVN;
        private System.Windows.Forms.PictureBox pictureBox_BVN;
    }
}