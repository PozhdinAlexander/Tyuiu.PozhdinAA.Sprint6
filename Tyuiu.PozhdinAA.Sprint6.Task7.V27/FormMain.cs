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
using Tyuiu.PozhdinAA.Sprint6.Task7.V27.Lib;

namespace Tyuiu.PozhdinAA.Sprint6.Task7.V27
{
    public partial class FormMain_PAA : Form
    {
        DataService service = new DataService();
        string path;
        public FormMain_PAA()
        {
            InitializeComponent();
            openFileDialog.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog.Filter = "Значения разделённые точками(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        private void buttonFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            groupBoxInput_PAA.Text += " " + path;
            buttonExecute_PAA.Enabled = true;
            buttonSave_PAA.Enabled = true;


            string content = File.ReadAllText(path);
            int[,] matrix = new int[content.Count(x => x == '\n'), content.Split('\n')[0].Split(';').Length];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] str = content.Split('\n');
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(str[i].Split(';')[j]);
                }
            }
            dataGridViewInput_PAA.ColumnCount = matrix.GetLength(1);
            dataGridViewInput_PAA.RowCount = matrix.GetLength(0);

            dataGridViewOutput_PAA.ColumnCount = matrix.GetLength(1);
            dataGridViewOutput_PAA.RowCount = matrix.GetLength(0);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewInput_PAA.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_PAA.ColumnCount = 50;
            dataGridViewOutput_PAA.ColumnCount = 50;

            dataGridViewInput_PAA.RowCount = 50;
            dataGridViewOutput_PAA.RowCount = 50;

            for (int i = 0; i < dataGridViewInput_PAA.ColumnCount; i++)
            {
                dataGridViewInput_PAA.Columns[i].Width = 25;
                dataGridViewOutput_PAA.Columns[i].Width = 25;
            }
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int[,] serviceMatrix = service.GetMatrix(path);
            for (int i = 0; i < serviceMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < serviceMatrix.GetLength(1); j++)
                {
                    dataGridViewOutput_PAA.Rows[i].Cells[j].Value = serviceMatrix[i, j];
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int[,] serviceMatrix = service.GetMatrix(path);
            saveFileDialog.FileName = "OutputFileTask7";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();

            string savePath = saveFileDialog.FileName;

            string str = "";
            for (int i = 0; i < serviceMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < serviceMatrix.GetLength(1); j++)
                {
                    if (j != serviceMatrix.GetLength(1) - 1)
                    {
                        str += serviceMatrix[i, j].ToString() + ";";
                    }
                    else
                    {
                        str += serviceMatrix[i, j].ToString() + Environment.NewLine;
                    }
                }
            }
            File.WriteAllText(savePath, str);
        }

        private void dataGridViewInput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
