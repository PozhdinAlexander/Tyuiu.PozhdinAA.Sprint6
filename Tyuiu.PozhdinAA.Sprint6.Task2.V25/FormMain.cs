using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PozhdinAA.Sprint6.Task2.V25.Lib;

namespace Tyuiu.PozhdinAA.Sprint6.Task2.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_PAA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInOne_PAA.Text);
                int stopStep = Convert.ToInt32(textBoxInTwo_PAA.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartGraf_PAA.Titles.Add("График функции");
                this.chartGraf_PAA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartGraf_PAA.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewOut_PAA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartGraf_PAA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_PAA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PAA.BackColor = Color.Red;
        }

        private void buttonDone_PAA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PAA.BackColor = Color.Green;
        }

        private void buttonDone_PAA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PAA.BackColor = Color.Blue;
        }
        private void buttonInfo_PAA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-1 Пождин Александр Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
