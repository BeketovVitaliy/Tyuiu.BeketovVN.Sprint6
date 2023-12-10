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
using Tyuiu.BeketovVN.Sprint6.Task6.V25.Lib;

namespace Tyuiu.BeketovVN.Sprint6.Task6.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;
        private void buttonOpenFile_BVN_Click(object sender, EventArgs e)
        {
            openFileDialogTask_BVN.ShowDialog();
            openFilePath = openFileDialogTask_BVN.FileName;
            textBoxInPut_BVN.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_BVN.Text = groupBoxOutPut_BVN.Text + " " + openFileDialogTask_BVN.FileName;
            buttonDone_BVN.Enabled = true;
        }

        private void toolTipTask_BVN_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonDone_BVN_Click(object sender, EventArgs e)
        {
            textBoxOutPut_BVN.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_BVN_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
