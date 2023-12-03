using Tyuiu.BeketovVN.Sprint6.Task0.V13.Lib;

namespace Tyuiu.BeketovVN.Sprint6.Task0.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private Button buttonGo_BVN;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonGo_BVN = new Button();
            groupBoxTask_BVN = new GroupBox();
            labelTask_BVN = new Label();
            groupBoxInPut_BVN = new GroupBox();
            labelInput_BVN = new Label();
            textBoxInPut_BVN = new TextBox();
            groupBoxResult_BVN = new GroupBox();
            labelResult_BVN = new Label();
            textBoxResult_BVN = new TextBox();
            pictureBox1 = new PictureBox();
            groupBoxTask_BVN.SuspendLayout();
            groupBoxInPut_BVN.SuspendLayout();
            groupBoxResult_BVN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonGo_BVN
            // 
            buttonGo_BVN.AccessibleName = "buttonDone";
            buttonGo_BVN.Location = new Point(465, 274);
            buttonGo_BVN.Name = "buttonGo_BVN";
            buttonGo_BVN.Size = new Size(119, 42);
            buttonGo_BVN.TabIndex = 0;
            buttonGo_BVN.Text = "Выполнить";
            buttonGo_BVN.UseVisualStyleBackColor = true;
            buttonGo_BVN.Click += button1_Click;
            // 
            // groupBoxTask_BVN
            // 
            groupBoxTask_BVN.Controls.Add(pictureBox1);
            groupBoxTask_BVN.Controls.Add(labelTask_BVN);
            groupBoxTask_BVN.Location = new Point(12, 12);
            groupBoxTask_BVN.Name = "groupBoxTask_BVN";
            groupBoxTask_BVN.Size = new Size(581, 143);
            groupBoxTask_BVN.TabIndex = 1;
            groupBoxTask_BVN.TabStop = false;
            groupBoxTask_BVN.Text = "Условие:";
            groupBoxTask_BVN.UseWaitCursor = true;
            groupBoxTask_BVN.Enter += groupBox1_Enter;
            // 
            // labelTask_BVN
            // 
            labelTask_BVN.AutoSize = true;
            labelTask_BVN.Location = new Point(3, 19);
            labelTask_BVN.Name = "labelTask_BVN";
            labelTask_BVN.Size = new Size(205, 15);
            labelTask_BVN.TabIndex = 0;
            labelTask_BVN.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInPut_BVN
            // 
            groupBoxInPut_BVN.Controls.Add(labelInput_BVN);
            groupBoxInPut_BVN.Controls.Add(textBoxInPut_BVN);
            groupBoxInPut_BVN.Location = new Point(12, 161);
            groupBoxInPut_BVN.Name = "groupBoxInPut_BVN";
            groupBoxInPut_BVN.Size = new Size(366, 100);
            groupBoxInPut_BVN.TabIndex = 0;
            groupBoxInPut_BVN.TabStop = false;
            groupBoxInPut_BVN.Text = "Ввод данных";
            // 
            // labelInput_BVN
            // 
            labelInput_BVN.AutoSize = true;
            labelInput_BVN.Location = new Point(6, 28);
            labelInput_BVN.Name = "labelInput_BVN";
            labelInput_BVN.Size = new Size(89, 15);
            labelInput_BVN.TabIndex = 0;
            labelInput_BVN.Text = "Переменная X:";
            // 
            // textBoxInPut_BVN
            // 
            textBoxInPut_BVN.Location = new Point(6, 46);
            textBoxInPut_BVN.Name = "textBoxInPut_BVN";
            textBoxInPut_BVN.Size = new Size(100, 23);
            textBoxInPut_BVN.TabIndex = 2;
            textBoxInPut_BVN.TextChanged += textBoxInPut_BVN_TextChanged;
            textBoxInPut_BVN.KeyPress += textBoxInPut_BVN_KeyPress;
            // 
            // groupBoxResult_BVN
            // 
            groupBoxResult_BVN.Controls.Add(labelResult_BVN);
            groupBoxResult_BVN.Controls.Add(textBoxResult_BVN);
            groupBoxResult_BVN.Location = new Point(384, 161);
            groupBoxResult_BVN.Name = "groupBoxResult_BVN";
            groupBoxResult_BVN.Size = new Size(200, 100);
            groupBoxResult_BVN.TabIndex = 0;
            groupBoxResult_BVN.TabStop = false;
            groupBoxResult_BVN.Text = "Вывод данных";
            // 
            // labelResult_BVN
            // 
            labelResult_BVN.AutoSize = true;
            labelResult_BVN.Location = new Point(6, 28);
            labelResult_BVN.Name = "labelResult_BVN";
            labelResult_BVN.Size = new Size(60, 15);
            labelResult_BVN.TabIndex = 3;
            labelResult_BVN.Text = "Результат";
            labelResult_BVN.Click += label2_Click;
            // 
            // textBoxResult_BVN
            // 
            textBoxResult_BVN.Location = new Point(6, 46);
            textBoxResult_BVN.Name = "textBoxResult_BVN";
            textBoxResult_BVN.ReadOnly = true;
            textBoxResult_BVN.Size = new Size(100, 23);
            textBoxResult_BVN.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(453, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 64);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // FormMain
            // 
            ClientSize = new Size(605, 328);
            Controls.Add(groupBoxResult_BVN);
            Controls.Add(groupBoxInPut_BVN);
            Controls.Add(groupBoxTask_BVN);
            Controls.Add(buttonGo_BVN);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormMain_Load;
            groupBoxTask_BVN.ResumeLayout(false);
            groupBoxTask_BVN.PerformLayout();
            groupBoxInPut_BVN.ResumeLayout(false);
            groupBoxInPut_BVN.PerformLayout();
            groupBoxResult_BVN.ResumeLayout(false);
            groupBoxResult_BVN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_BVN.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInPut_BVN.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private GroupBox groupBoxTask_BVN;
        private GroupBox groupBoxInPut_BVN;
        private GroupBox groupBoxResult_BVN;
        private Label labelInput_BVN;
        private TextBox textBoxInPut_BVN;
        private Label labelResult_BVN;
        private TextBox textBoxResult_BVN;
        private Label labelTask_BVN;

        private void textBoxInPut_BVN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxInPut_BVN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private PictureBox pictureBox1;
    }
}