
namespace Tyuiu.PozhdinAA.Sprint6.Task2.V25
{
    partial class FormMain
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
            this.groupBoxText_PAA = new System.Windows.Forms.GroupBox();
            this.labelText_PAA = new System.Windows.Forms.Label();
            this.groupBoxIn_PAA = new System.Windows.Forms.GroupBox();
            this.textBoxInTwo_PAA = new System.Windows.Forms.TextBox();
            this.textBoxInOne_PAA = new System.Windows.Forms.TextBox();
            this.labelInTwo_PAA = new System.Windows.Forms.Label();
            this.labelInOne_PAA = new System.Windows.Forms.Label();
            this.buttonDone_PAA = new System.Windows.Forms.Button();
            this.buttonInfo_PAA = new System.Windows.Forms.Button();
            this.groupBoxOut_PAA = new System.Windows.Forms.GroupBox();
            this.chartGraf_PAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewOut_PAA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Function = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxText_PAA.SuspendLayout();
            this.groupBoxIn_PAA.SuspendLayout();
            this.groupBoxOut_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_PAA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_PAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxText_PAA
            // 
            this.groupBoxText_PAA.Controls.Add(this.labelText_PAA);
            this.groupBoxText_PAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxText_PAA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxText_PAA.Name = "groupBoxText_PAA";
            this.groupBoxText_PAA.Size = new System.Drawing.Size(442, 375);
            this.groupBoxText_PAA.TabIndex = 0;
            this.groupBoxText_PAA.TabStop = false;
            this.groupBoxText_PAA.Text = "Условие";
            // 
            // labelText_PAA
            // 
            this.labelText_PAA.AutoSize = true;
            this.labelText_PAA.Location = new System.Drawing.Point(7, 20);
            this.labelText_PAA.Name = "labelText_PAA";
            this.labelText_PAA.Size = new System.Drawing.Size(434, 45);
            this.labelText_PAA.TabIndex = 0;
            this.labelText_PAA.Text = "Протабулировать функцию ((5*x+2,5)/(sin(x)-2))+2 \r\nна заданном диапазоне.\r\nРезуль" +
    "тат вывести в DataGrid View и построить график функции.";
            // 
            // groupBoxIn_PAA
            // 
            this.groupBoxIn_PAA.Controls.Add(this.textBoxInTwo_PAA);
            this.groupBoxIn_PAA.Controls.Add(this.textBoxInOne_PAA);
            this.groupBoxIn_PAA.Controls.Add(this.labelInTwo_PAA);
            this.groupBoxIn_PAA.Controls.Add(this.labelInOne_PAA);
            this.groupBoxIn_PAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxIn_PAA.Location = new System.Drawing.Point(12, 394);
            this.groupBoxIn_PAA.Name = "groupBoxIn_PAA";
            this.groupBoxIn_PAA.Size = new System.Drawing.Size(272, 68);
            this.groupBoxIn_PAA.TabIndex = 1;
            this.groupBoxIn_PAA.TabStop = false;
            this.groupBoxIn_PAA.Text = "Ввод данных";
            // 
            // textBoxInTwo_PAA
            // 
            this.textBoxInTwo_PAA.Location = new System.Drawing.Point(140, 39);
            this.textBoxInTwo_PAA.Name = "textBoxInTwo_PAA";
            this.textBoxInTwo_PAA.Size = new System.Drawing.Size(127, 23);
            this.textBoxInTwo_PAA.TabIndex = 3;
            // 
            // textBoxInOne_PAA
            // 
            this.textBoxInOne_PAA.Location = new System.Drawing.Point(7, 39);
            this.textBoxInOne_PAA.Name = "textBoxInOne_PAA";
            this.textBoxInOne_PAA.Size = new System.Drawing.Size(127, 23);
            this.textBoxInOne_PAA.TabIndex = 2;
            // 
            // labelInTwo_PAA
            // 
            this.labelInTwo_PAA.AutoSize = true;
            this.labelInTwo_PAA.Location = new System.Drawing.Point(137, 21);
            this.labelInTwo_PAA.Name = "labelInTwo_PAA";
            this.labelInTwo_PAA.Size = new System.Drawing.Size(84, 15);
            this.labelInTwo_PAA.TabIndex = 1;
            this.labelInTwo_PAA.Text = "Конец шага:";
            // 
            // labelInOne_PAA
            // 
            this.labelInOne_PAA.AutoSize = true;
            this.labelInOne_PAA.Location = new System.Drawing.Point(7, 20);
            this.labelInOne_PAA.Name = "labelInOne_PAA";
            this.labelInOne_PAA.Size = new System.Drawing.Size(84, 15);
            this.labelInOne_PAA.TabIndex = 0;
            this.labelInOne_PAA.Text = "Страт шага:";
            // 
            // buttonDone_PAA
            // 
            this.buttonDone_PAA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_PAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDone_PAA.Location = new System.Drawing.Point(360, 402);
            this.buttonDone_PAA.Name = "buttonDone_PAA";
            this.buttonDone_PAA.Size = new System.Drawing.Size(95, 60);
            this.buttonDone_PAA.TabIndex = 1;
            this.buttonDone_PAA.Text = "Выполнить";
            this.buttonDone_PAA.UseVisualStyleBackColor = false;
            this.buttonDone_PAA.Click += new System.EventHandler(this.buttonDone_PAA_Click);
            this.buttonDone_PAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PAA_MouseDown);
            this.buttonDone_PAA.MouseEnter += new System.EventHandler(this.buttonDone_PAA_MouseEnter);
            this.buttonDone_PAA.MouseLeave += new System.EventHandler(this.buttonDone_PAA_MouseLeave);
            // 
            // buttonInfo_PAA
            // 
            this.buttonInfo_PAA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_PAA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInfo_PAA.Location = new System.Drawing.Point(290, 402);
            this.buttonInfo_PAA.Name = "buttonInfo_PAA";
            this.buttonInfo_PAA.Size = new System.Drawing.Size(64, 60);
            this.buttonInfo_PAA.TabIndex = 2;
            this.buttonInfo_PAA.Text = "Справка";
            this.buttonInfo_PAA.UseVisualStyleBackColor = false;
            this.buttonInfo_PAA.Click += new System.EventHandler(this.buttonInfo_PAA_Click);
            // 
            // groupBoxOut_PAA
            // 
            this.groupBoxOut_PAA.Controls.Add(this.chartGraf_PAA);
            this.groupBoxOut_PAA.Controls.Add(this.dataGridViewOut_PAA);
            this.groupBoxOut_PAA.Location = new System.Drawing.Point(460, 13);
            this.groupBoxOut_PAA.Name = "groupBoxOut_PAA";
            this.groupBoxOut_PAA.Size = new System.Drawing.Size(474, 449);
            this.groupBoxOut_PAA.TabIndex = 3;
            this.groupBoxOut_PAA.TabStop = false;
            this.groupBoxOut_PAA.Text = "Вывод данных";
            // 
            // chartGraf_PAA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraf_PAA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraf_PAA.Legends.Add(legend1);
            this.chartGraf_PAA.Location = new System.Drawing.Point(117, 20);
            this.chartGraf_PAA.Name = "chartGraf_PAA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraf_PAA.Series.Add(series1);
            this.chartGraf_PAA.Size = new System.Drawing.Size(351, 423);
            this.chartGraf_PAA.TabIndex = 1;
            this.chartGraf_PAA.Text = "chart1";
            // 
            // dataGridViewOut_PAA
            // 
            this.dataGridViewOut_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_PAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Function});
            this.dataGridViewOut_PAA.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewOut_PAA.Name = "dataGridViewOut_PAA";
            this.dataGridViewOut_PAA.RowHeadersVisible = false;
            this.dataGridViewOut_PAA.Size = new System.Drawing.Size(104, 423);
            this.dataGridViewOut_PAA.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Function
            // 
            this.Function.HeaderText = "F(x)";
            this.Function.Name = "Function";
            this.Function.ReadOnly = true;
            this.Function.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 474);
            this.Controls.Add(this.groupBoxOut_PAA);
            this.Controls.Add(this.buttonInfo_PAA);
            this.Controls.Add(this.buttonDone_PAA);
            this.Controls.Add(this.groupBoxIn_PAA);
            this.Controls.Add(this.groupBoxText_PAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 25 | Пождин А.А";
            this.groupBoxText_PAA.ResumeLayout(false);
            this.groupBoxText_PAA.PerformLayout();
            this.groupBoxIn_PAA.ResumeLayout(false);
            this.groupBoxIn_PAA.PerformLayout();
            this.groupBoxOut_PAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_PAA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_PAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxText_PAA;
        private System.Windows.Forms.Label labelText_PAA;
        private System.Windows.Forms.GroupBox groupBoxIn_PAA;
        private System.Windows.Forms.TextBox textBoxInTwo_PAA;
        private System.Windows.Forms.TextBox textBoxInOne_PAA;
        private System.Windows.Forms.Label labelInTwo_PAA;
        private System.Windows.Forms.Label labelInOne_PAA;
        private System.Windows.Forms.Button buttonDone_PAA;
        private System.Windows.Forms.Button buttonInfo_PAA;
        private System.Windows.Forms.GroupBox groupBoxOut_PAA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf_PAA;
        private System.Windows.Forms.DataGridView dataGridViewOut_PAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Function;
    }
}

