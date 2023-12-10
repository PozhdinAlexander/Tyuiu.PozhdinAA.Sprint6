
namespace Tyuiu.PozhdinAA.Sprint6.Task5.V7
{
    partial class FormMain_PAA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelProperty__PAA = new System.Windows.Forms.Panel();
            this.buttonInfo_PAA = new System.Windows.Forms.Button();
            this.buttonOpenFile__PAA = new System.Windows.Forms.Button();
            this.buttonResult__PAA = new System.Windows.Forms.Button();
            this.groupBoxProperty__PAA = new System.Windows.Forms.GroupBox();
            this.textBoxProperty__PAA = new System.Windows.Forms.TextBox();
            this.panelOutputData__PAA = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_PAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums__PAA = new System.Windows.Forms.DataGridView();
            this.chartGraf__PAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelProperty__PAA.SuspendLayout();
            this.groupBoxProperty__PAA.SuspendLayout();
            this.panelOutputData__PAA.SuspendLayout();
            this.groupBoxOutPutData_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums__PAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf__PAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProperty__PAA
            // 
            this.panelProperty__PAA.Controls.Add(this.buttonInfo_PAA);
            this.panelProperty__PAA.Controls.Add(this.buttonOpenFile__PAA);
            this.panelProperty__PAA.Controls.Add(this.buttonResult__PAA);
            this.panelProperty__PAA.Controls.Add(this.groupBoxProperty__PAA);
            this.panelProperty__PAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProperty__PAA.Location = new System.Drawing.Point(0, 0);
            this.panelProperty__PAA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelProperty__PAA.Name = "panelProperty__PAA";
            this.panelProperty__PAA.Size = new System.Drawing.Size(690, 77);
            this.panelProperty__PAA.TabIndex = 0;
            // 
            // buttonInfo_PAA
            // 
            this.buttonInfo_PAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_PAA.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInfo_PAA.Location = new System.Drawing.Point(601, 8);
            this.buttonInfo_PAA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInfo_PAA.Name = "buttonInfo_PAA";
            this.buttonInfo_PAA.Size = new System.Drawing.Size(81, 62);
            this.buttonInfo_PAA.TabIndex = 1;
            this.buttonInfo_PAA.Text = "Справка";
            this.buttonInfo_PAA.UseVisualStyleBackColor = false;
            this.buttonInfo_PAA.Click += new System.EventHandler(this.buttonInfo_PAA_Click);
            // 
            // buttonOpenFile__PAA
            // 
            this.buttonOpenFile__PAA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOpenFile__PAA.Location = new System.Drawing.Point(454, 8);
            this.buttonOpenFile__PAA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenFile__PAA.Name = "buttonOpenFile__PAA";
            this.buttonOpenFile__PAA.Size = new System.Drawing.Size(81, 62);
            this.buttonOpenFile__PAA.TabIndex = 1;
            this.buttonOpenFile__PAA.Text = "Открыть файл";
            this.buttonOpenFile__PAA.UseVisualStyleBackColor = false;
            this.buttonOpenFile__PAA.Click += new System.EventHandler(this.buttonOpenFile_PAA_Click);
            // 
            // buttonResult__PAA
            // 
            this.buttonResult__PAA.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonResult__PAA.Location = new System.Drawing.Point(369, 8);
            this.buttonResult__PAA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonResult__PAA.Name = "buttonResult__PAA";
            this.buttonResult__PAA.Size = new System.Drawing.Size(81, 62);
            this.buttonResult__PAA.TabIndex = 1;
            this.buttonResult__PAA.Text = "Выполнить";
            this.buttonResult__PAA.UseVisualStyleBackColor = false;
            this.buttonResult__PAA.Click += new System.EventHandler(this.buttonResult_PAA_Click);
            // 
            // groupBoxProperty__PAA
            // 
            this.groupBoxProperty__PAA.Controls.Add(this.textBoxProperty__PAA);
            this.groupBoxProperty__PAA.Location = new System.Drawing.Point(9, 8);
            this.groupBoxProperty__PAA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProperty__PAA.Name = "groupBoxProperty__PAA";
            this.groupBoxProperty__PAA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxProperty__PAA.Size = new System.Drawing.Size(356, 64);
            this.groupBoxProperty__PAA.TabIndex = 0;
            this.groupBoxProperty__PAA.TabStop = false;
            this.groupBoxProperty__PAA.Text = "Условие:";
            // 
            // textBoxProperty__PAA
            // 
            this.textBoxProperty__PAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProperty__PAA.Location = new System.Drawing.Point(5, 17);
            this.textBoxProperty__PAA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxProperty__PAA.Multiline = true;
            this.textBoxProperty__PAA.Name = "textBoxProperty__PAA";
            this.textBoxProperty__PAA.ReadOnly = true;
            this.textBoxProperty__PAA.Size = new System.Drawing.Size(347, 45);
            this.textBoxProperty__PAA.TabIndex = 0;
            this.textBoxProperty__PAA.Text = "Прочитать данные из файла InPutFileTask5V7.txt. Вывести в dataGridView. Дан списо" +
    "к из 20 чисел. Вывести все числа, больше 5. Построить диаграмму по этим значения" +
    "м";
            // 
            // panelOutputData__PAA
            // 
            this.panelOutputData__PAA.Controls.Add(this.groupBoxOutPutData_PAA);
            this.panelOutputData__PAA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutputData__PAA.Location = new System.Drawing.Point(0, 77);
            this.panelOutputData__PAA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelOutputData__PAA.Name = "panelOutputData__PAA";
            this.panelOutputData__PAA.Size = new System.Drawing.Size(133, 252);
            this.panelOutputData__PAA.TabIndex = 1;
            // 
            // groupBoxOutPutData_PAA
            // 
            this.groupBoxOutPutData_PAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOutPutData_PAA.Controls.Add(this.dataGridViewNums__PAA);
            this.groupBoxOutPutData_PAA.Location = new System.Drawing.Point(9, 5);
            this.groupBoxOutPutData_PAA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPutData_PAA.Name = "groupBoxOutPutData_PAA";
            this.groupBoxOutPutData_PAA.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPutData_PAA.Size = new System.Drawing.Size(123, 209);
            this.groupBoxOutPutData_PAA.TabIndex = 0;
            this.groupBoxOutPutData_PAA.TabStop = false;
            this.groupBoxOutPutData_PAA.Text = "Вывод данных:";
            // 
            // dataGridViewNums__PAA
            // 
            this.dataGridViewNums__PAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNums__PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums__PAA.ColumnHeadersVisible = false;
            this.dataGridViewNums__PAA.Location = new System.Drawing.Point(0, 17);
            this.dataGridViewNums__PAA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewNums__PAA.Name = "dataGridViewNums__PAA";
            this.dataGridViewNums__PAA.RowHeadersVisible = false;
            this.dataGridViewNums__PAA.RowHeadersWidth = 62;
            this.dataGridViewNums__PAA.RowTemplate.Height = 28;
            this.dataGridViewNums__PAA.Size = new System.Drawing.Size(119, 187);
            this.dataGridViewNums__PAA.TabIndex = 0;
            // 
            // chartGraf__PAA
            // 
            this.chartGraf__PAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartGraf__PAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraf__PAA.Legends.Add(legend1);
            this.chartGraf__PAA.Location = new System.Drawing.Point(153, 81);
            this.chartGraf__PAA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartGraf__PAA.Name = "chartGraf__PAA";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraf__PAA.Series.Add(series1);
            this.chartGraf__PAA.Size = new System.Drawing.Size(529, 240);
            this.chartGraf__PAA.TabIndex = 2;
            this.chartGraf__PAA.Text = "chart1";
            // 
            // FormMain_PAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 329);
            this.Controls.Add(this.chartGraf__PAA);
            this.Controls.Add(this.panelOutputData__PAA);
            this.Controls.Add(this.panelProperty__PAA);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(695, 343);
            this.Name = "FormMain_PAA";
            this.Text = "Спринт 6 | Таск 5 | Вариант 7 | Пождин А.А.";
            this.Load += new System.EventHandler(this.FormMain_PAA_Load);
            this.panelProperty__PAA.ResumeLayout(false);
            this.groupBoxProperty__PAA.ResumeLayout(false);
            this.groupBoxProperty__PAA.PerformLayout();
            this.panelOutputData__PAA.ResumeLayout(false);
            this.groupBoxOutPutData_PAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums__PAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf__PAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProperty__PAA;
        private System.Windows.Forms.Button buttonInfo_PAA;
        private System.Windows.Forms.Button buttonOpenFile__PAA;
        private System.Windows.Forms.Button buttonResult__PAA;
        private System.Windows.Forms.GroupBox groupBoxProperty__PAA;
        private System.Windows.Forms.TextBox textBoxProperty__PAA;
        private System.Windows.Forms.Panel panelOutputData__PAA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_PAA;
        private System.Windows.Forms.DataGridView dataGridViewNums__PAA;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartGraf__PAA;
    }
}

