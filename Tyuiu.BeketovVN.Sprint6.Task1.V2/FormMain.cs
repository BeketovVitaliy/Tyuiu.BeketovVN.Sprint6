using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BeketovVN.Sprint6.Task1.V2.Lib;

namespace Tyuiu.BeketovVN.Sprint6.Task1.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BVN.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BVN.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_BVN.Text = "";
                textBoxResult_BVN.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_BVN.AppendText("|     X     |    f(x)   |" + Environment.NewLine);
                textBoxResult_BVN.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,6:d}     |   {1, 6:f2}  |", startStep, valueArray[i]);
                    textBoxResult_BVN.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_BVN.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelTask_GKU_Click(object sender, EventArgs e)
        {

        }

        private void labelResult_GKU_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_GKU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПб-23-2 Бекетов Виталий Николаевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxStartStep_GKU_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
