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
using Tyuiu.PozhdinAA.Sprint6.Task6.V27.Lib;

namespace Tyuiu.PozhdinAA.Sprint6.Task6.V27
{
    public partial class FormMain_PAA : Form
    {
        public FormMain_PAA()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;
            textBoxInput_PAA.Text = File.ReadAllText(openFilePath);
            groupBoxInput_PAA.Text = groupBoxInput_PAA.Text + ' ' + openFileDialogTask.FileName;
            buttonDone_PAA.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput_PAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
