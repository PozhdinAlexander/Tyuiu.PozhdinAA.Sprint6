using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PozhdinAA.Sprint6.Task1.V26.Lib;

namespace Tyuiu.PozhdinAA.Sprint6.Task1.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        
        private void pictureBox_PAA_Load(object sender, EventArgs e)
        {

        }
        private void buttonHelp_PAA_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-1 Пождин Александр Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_PAA_Click_1(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                int startStep = Convert.ToInt32(textBox2_PAA.Text);
                int stopStep = Convert.ToInt32(textBox3_PAA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxRezult_PAA.AppendText("+-----------+------------+" + Environment.NewLine);
                textBoxRezult_PAA.AppendText("|     X     |    f(x)    |" + Environment.NewLine);
                textBoxRezult_PAA.AppendText("+-----------+------------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,5:f2}    |", startStep, valueArray[i]);
                    textBoxRezult_PAA.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxRezult_PAA.AppendText("+-----------+------------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Неверный ввод данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
