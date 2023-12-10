using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PozhdinAA.Sprint6.Task5.V7.Lib;

namespace Tyuiu.PozhdinAA.Sprint6.Task5.V7
{
    public partial class FormMain_PAA : Form
    {
        public FormMain_PAA()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"C:\Users\xMeT1oRx\source\repos\Tyuiu.PozhdinAA.Sprint6\Tyuiu.PozhdinAA.Sprint6.Task5.V7\bin\Debug\InPutFileTask5V7.txt";


        private void FormMain_PAA_Load(object sender, EventArgs e)
        {

        }

        private void buttonResult_PAA_Click(object sender, EventArgs e)
        {
            dataGridViewNums__PAA.ColumnCount = 2;
            dataGridViewNums__PAA.Columns[0].Width = 20;
            dataGridViewNums__PAA.Columns[1].Width = 50;
            this.chartGraf__PAA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGraf__PAA.ChartAreas[0].AxisY.Title = "Ось Y";
            chartGraf__PAA.Series[0].Points.Clear();
            double[] massive = new double[ds.len];
            massive = ds.LoadFromDataFile(path);
            for (int i = 0; i < massive.Length; i++)
            {
                dataGridViewNums__PAA.Rows.Add(Convert.ToString(i), Convert.ToString(massive[i]));
                chartGraf__PAA.Series[0].Points.AddXY(i, massive[i]);
            }


        }

        private void buttonOpenFile_PAA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-1 Пождин Александр Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
