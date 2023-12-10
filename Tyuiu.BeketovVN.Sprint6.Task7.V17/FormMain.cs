using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.BeketovVN.Sprint6.Task7.V17.Lib;

namespace Tyuiu.BeketovVN.Sprint6.Task7.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            OpenFileDialog_BVN.Filter = "Значения, разделененые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            SaveFileDialog_BVN.Filter = "Значения, разделененые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int colums;
        static string openFilePath;
        DataService ds = new DataService();

        public int[,] LoadFromFileData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_m = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_m[j]);
                }
            }
            return arrayValues;
        }

        private void ButtonOpen_BVN_Click(object sender, EventArgs e)
        {
            OpenFileDialog_BVN.ShowDialog();
            openFilePath = OpenFileDialog_BVN.FileName;

            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);

            DataGridViewInput_BVN.ColumnCount = colums;
            DataGridViewInput_BVN.RowCount = rows;
            DataGridViewOutput_BVN.ColumnCount = colums;
            DataGridViewOutput_BVN.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                DataGridViewInput_BVN.Columns[i].Width = 50;
                DataGridViewOutput_BVN.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    DataGridViewInput_BVN.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            ButtonDone_BVN.Enabled = true;
        }

        private void ButtonDone_BVN_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    DataGridViewOutput_BVN.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            ButtonSave_BVN.Enabled = true;
        }

        private void ButtonSave_BVN_Click(object sender, EventArgs e)
        {
            SaveFileDialog_BVN.FileName = "OutPutFileTask7V10.csv";
            SaveFileDialog_BVN.InitialDirectory = Directory.GetCurrentDirectory();
            SaveFileDialog_BVN.ShowDialog();

            string path = SaveFileDialog_BVN.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = DataGridViewOutput_BVN.RowCount;
            int colums = DataGridViewOutput_BVN.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + DataGridViewOutput_BVN.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + DataGridViewOutput_BVN.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void ButtonOpen_BVN_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_BVN.ToolTipTitle = "Открыть файл";
        }

        private void ButtonDone_BVN_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_BVN.ToolTipTitle = "Выполнить";
        }

        private void ButtonSave_BVN_MouseEnter(object sender, EventArgs e)
        {
            ToolTip_BVN.ToolTipTitle = "Сохранить в файл";
        }

        private void ButtonInfo_BVN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            DataGridViewInput_BVN.ColumnCount = 50;
            DataGridViewOutput_BVN.ColumnCount = 50;

            DataGridViewInput_BVN.RowCount = 50;
            DataGridViewOutput_BVN.RowCount = 50;

            PanelLeft_BVN.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                DataGridViewInput_BVN.Columns[i].Width = 25;
                DataGridViewOutput_BVN.Columns[i].Width = 25;
            }
        }
    }
}
