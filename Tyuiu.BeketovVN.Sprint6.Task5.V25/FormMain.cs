using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.BeketovVN.Sprint6.Task5.V25.Lib;

namespace Tyuiu.BeketovVN.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"D:\Project\С#\sprint\Tyuiu.BeketovVN.Sprint6\Tyuiu.BeketovVN.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";
        private void buttonDone_BVN_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_BVN.ColumnCount = 2;
            dataGridViewOutPut_BVN.Columns[0].Width = 40;
            dataGridViewOutPut_BVN.Columns[1].Width = 60;

            this.chartGraph_BVN.ChartAreas[0].AxisX.Title = "Ось Х";
            this.chartGraph_BVN.ChartAreas[0].AxisY.Title = "Ось Y";
            this.chartGraph_BVN.Series[0].Points.Clear();

            double[] nums = new double[ds.len];
            nums = ds.LoadFromDataFile(path);
            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewOutPut_BVN.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartGraph_BVN.Series[0].Points.AddXY(i, nums[i]);
            }
        }

        private void buttonSaveFile_BVN_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\Project\С#\sprint\Tyuiu.BeketovVN.Sprint6\Tyuiu.BeketovVN.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";

                System.Diagnostics.Process txt = new System.Diagnostics.Process();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = path;
                txt.Start();
            }
            catch
            {
                MessageBox.Show("Сбой при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_BVN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПб-23-2 Бекетов Виталий Николаевич", "Сообщение");
        }
    }
}
