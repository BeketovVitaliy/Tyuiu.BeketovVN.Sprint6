namespace Tyuiu.BeketovVN.Sprint6.Task7.V17
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
            this.pictureBoxAbout_BVN = new System.Windows.Forms.PictureBox();
            this.textBoxAbout_BVN = new System.Windows.Forms.TextBox();
            this.buttonOK_BVN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_BVN)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAbout_BVN
            // 
            this.pictureBoxAbout_BVN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxAbout_BVN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout_BVN.Image")));
            this.pictureBoxAbout_BVN.Location = new System.Drawing.Point(22, 12);
            this.pictureBoxAbout_BVN.Name = "pictureBoxAbout_BVN";
            this.pictureBoxAbout_BVN.Size = new System.Drawing.Size(203, 190);
            this.pictureBoxAbout_BVN.TabIndex = 0;
            this.pictureBoxAbout_BVN.TabStop = false;
            // 
            // textBoxAbout_BVN
            // 
            this.textBoxAbout_BVN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAbout_BVN.Location = new System.Drawing.Point(231, 11);
            this.textBoxAbout_BVN.Multiline = true;
            this.textBoxAbout_BVN.Name = "textBoxAbout_BVN";
            this.textBoxAbout_BVN.ReadOnly = true;
            this.textBoxAbout_BVN.Size = new System.Drawing.Size(290, 161);
            this.textBoxAbout_BVN.TabIndex = 1;
            this.textBoxAbout_BVN.Text = "Разработчик: Бекетов В.Н.\r\nгруппа ИИПб-23-3\r\n\r\nПрограммма разработана в рамках из" +
    "учения языка C#\r\n\r\nТИУ(с) 2023\r\nВШЦТ(с) 2023\r\n\r\nВнутренее имя: Tyuiu.BeketovVN.S" +
    "print6.Task7.V17\r\n";
            // 
            // buttonOK_BVN
            // 
            this.buttonOK_BVN.Location = new System.Drawing.Point(446, 178);
            this.buttonOK_BVN.Name = "buttonOK_BVN";
            this.buttonOK_BVN.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_BVN.TabIndex = 2;
            this.buttonOK_BVN.Text = "Ок";
            this.buttonOK_BVN.UseVisualStyleBackColor = true;
            this.buttonOK_BVN.Click += new System.EventHandler(this.buttonOK_BVN_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 218);
            this.Controls.Add(this.buttonOK_BVN);
            this.Controls.Add(this.textBoxAbout_BVN);
            this.Controls.Add(this.pictureBoxAbout_BVN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_BVN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pictureBoxAbout_BVN;
        private System.Windows.Forms.TextBox textBoxAbout_BVN;
        private System.Windows.Forms.Button buttonOK_BVN;
    }
}