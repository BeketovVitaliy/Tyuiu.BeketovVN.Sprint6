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
using Tyuiu.BeketovVN.Sprint6.SprintReview.V29.Lib;

namespace Tyuiu.BeketovVN.Sprint6.SprintReview.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static int m;
        static int n;
        static int n1;
        static int n2;
        static int k;
        static int l;
        static int c;
        static int[,] arrayValues;
        Random rand = new Random();

        private void panelOne_BVN_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void buttonCreat_BVN_Click(object sender, EventArgs e)
        {
            try
            {
                int k = Convert.ToInt32(textBoxK_BVN.Text);
                int l = Convert.ToInt32(textBoxL_BVN.Text);
                int c = Convert.ToInt32(textBoxC_BVN.Text);

                int sum = ds.GetMatrix(arrayValues, c, k, l);

                textBoxResult_BVN.Text = Convert.ToString(sum);
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void buttonHelp_BVN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonChange_BVN_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(textBoxShir_BVN.Text);
            int n = Convert.ToInt32(textBoxVisot_BVN.Text);
            int n1 = Convert.ToInt32(textBoxStart_BVN.Text);
            int n2 = Convert.ToInt32(textBoxStop_BVN.Text);

            int[,] arrayValues = ds.GetRandomMatrix(n, m, n1, n2);

            dataGridViewMatrix_BVN.RowCount = n;
            dataGridViewMatrix_BVN.ColumnCount = m;

            for (int i = 0; i < m; i++)
            {
                dataGridViewMatrix_BVN.Columns[i].Width = 50;
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < m; c++)
                {
                    dataGridViewMatrix_BVN.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

        }
    }
}
