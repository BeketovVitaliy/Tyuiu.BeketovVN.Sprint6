using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BeketovVN.Sprint6.Task2.V8.Lib;

namespace Tyuiu.BeketovVN.Sprint6.Task2.V8
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

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chart_BVN.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chart_BVN.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView_BVN.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chart_BVN.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
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

        private void buttonDone_BVN_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BVN.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BVN.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chart_BVN.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chart_BVN.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridView_BVN.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chart_BVN.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxStartStep_BVN_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart_BVN_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTask_BVN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
