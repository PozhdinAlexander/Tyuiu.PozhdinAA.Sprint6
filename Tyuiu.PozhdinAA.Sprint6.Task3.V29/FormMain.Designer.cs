
namespace Tyuiu.PozhdinAA.Sprint6.Task3.V29
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_PAA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxResult_PAA = new System.Windows.Forms.GroupBox();
            this.labelResult_PAA = new System.Windows.Forms.Label();
            this.dataGridViewRes_PAA = new System.Windows.Forms.DataGridView();
            this.buttonHelp_PAA = new System.Windows.Forms.Button();
            this.buttonDone_PAA = new System.Windows.Forms.Button();
            this.groupBoxInPut_PAA = new System.Windows.Forms.GroupBox();
            this.labelInPut_PAA = new System.Windows.Forms.Label();
            this.dataGridViewInPut_PAA = new System.Windows.Forms.DataGridView();
            this.groupBoxTask_PAA.SuspendLayout();
            this.groupBoxResult_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_PAA)).BeginInit();
            this.groupBoxInPut_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_PAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_PAA
            // 
            this.groupBoxTask_PAA.Controls.Add(this.textBox1);
            this.groupBoxTask_PAA.Location = new System.Drawing.Point(9, 8);
            this.groupBoxTask_PAA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_PAA.Name = "groupBoxTask_PAA";
            this.groupBoxTask_PAA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTask_PAA.Size = new System.Drawing.Size(185, 276);
            this.groupBoxTask_PAA.TabIndex = 0;
            this.groupBoxTask_PAA.TabStop = false;
            this.groupBoxTask_PAA.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(177, 257);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxResult_PAA
            // 
            this.groupBoxResult_PAA.Controls.Add(this.labelResult_PAA);
            this.groupBoxResult_PAA.Controls.Add(this.dataGridViewRes_PAA);
            this.groupBoxResult_PAA.Location = new System.Drawing.Point(369, 8);
            this.groupBoxResult_PAA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_PAA.Name = "groupBoxResult_PAA";
            this.groupBoxResult_PAA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxResult_PAA.Size = new System.Drawing.Size(157, 248);
            this.groupBoxResult_PAA.TabIndex = 1;
            this.groupBoxResult_PAA.TabStop = false;
            this.groupBoxResult_PAA.Text = "Вывод данных";
            // 
            // labelResult_PAA
            // 
            this.labelResult_PAA.AutoSize = true;
            this.labelResult_PAA.Location = new System.Drawing.Point(43, 25);
            this.labelResult_PAA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult_PAA.Name = "labelResult_PAA";
            this.labelResult_PAA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_PAA.TabIndex = 1;
            this.labelResult_PAA.Text = "Результат:";
            // 
            // dataGridViewRes_PAA
            // 
            this.dataGridViewRes_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_PAA.ColumnHeadersVisible = false;
            this.dataGridViewRes_PAA.Location = new System.Drawing.Point(15, 49);
            this.dataGridViewRes_PAA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewRes_PAA.Name = "dataGridViewRes_PAA";
            this.dataGridViewRes_PAA.RowHeadersVisible = false;
            this.dataGridViewRes_PAA.RowHeadersWidth = 62;
            this.dataGridViewRes_PAA.RowTemplate.Height = 28;
            this.dataGridViewRes_PAA.Size = new System.Drawing.Size(129, 146);
            this.dataGridViewRes_PAA.TabIndex = 0;
            // 
            // buttonHelp_PAA
            // 
            this.buttonHelp_PAA.Location = new System.Drawing.Point(404, 259);
            this.buttonHelp_PAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp_PAA.Name = "buttonHelp_PAA";
            this.buttonHelp_PAA.Size = new System.Drawing.Size(25, 25);
            this.buttonHelp_PAA.TabIndex = 2;
            this.buttonHelp_PAA.Text = " ? ";
            this.buttonHelp_PAA.UseVisualStyleBackColor = true;
            this.buttonHelp_PAA.Click += new System.EventHandler(this.buttonHelp_PAA_Click);
            // 
            // buttonDone_PAA
            // 
            this.buttonDone_PAA.Location = new System.Drawing.Point(433, 259);
            this.buttonDone_PAA.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDone_PAA.Name = "buttonDone_PAA";
            this.buttonDone_PAA.Size = new System.Drawing.Size(93, 25);
            this.buttonDone_PAA.TabIndex = 3;
            this.buttonDone_PAA.Text = "Выполнить";
            this.buttonDone_PAA.UseVisualStyleBackColor = true;
            this.buttonDone_PAA.Click += new System.EventHandler(this.buttonDone_PAA_Click);
            // 
            // groupBoxInPut_PAA
            // 
            this.groupBoxInPut_PAA.Controls.Add(this.labelInPut_PAA);
            this.groupBoxInPut_PAA.Controls.Add(this.dataGridViewInPut_PAA);
            this.groupBoxInPut_PAA.Location = new System.Drawing.Point(198, 8);
            this.groupBoxInPut_PAA.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInPut_PAA.Name = "groupBoxInPut_PAA";
            this.groupBoxInPut_PAA.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInPut_PAA.Size = new System.Drawing.Size(167, 247);
            this.groupBoxInPut_PAA.TabIndex = 4;
            this.groupBoxInPut_PAA.TabStop = false;
            this.groupBoxInPut_PAA.Text = "Исходные данные";
            // 
            // labelInPut_PAA
            // 
            this.labelInPut_PAA.AutoSize = true;
            this.labelInPut_PAA.Location = new System.Drawing.Point(51, 25);
            this.labelInPut_PAA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInPut_PAA.Name = "labelInPut_PAA";
            this.labelInPut_PAA.Size = new System.Drawing.Size(54, 13);
            this.labelInPut_PAA.TabIndex = 1;
            this.labelInPut_PAA.Text = "Матрица:";
            // 
            // dataGridViewInPut_PAA
            // 
            this.dataGridViewInPut_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_PAA.ColumnHeadersVisible = false;
            this.dataGridViewInPut_PAA.Location = new System.Drawing.Point(15, 49);
            this.dataGridViewInPut_PAA.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInPut_PAA.Name = "dataGridViewInPut_PAA";
            this.dataGridViewInPut_PAA.RowHeadersVisible = false;
            this.dataGridViewInPut_PAA.RowHeadersWidth = 62;
            this.dataGridViewInPut_PAA.RowTemplate.Height = 28;
            this.dataGridViewInPut_PAA.Size = new System.Drawing.Size(129, 146);
            this.dataGridViewInPut_PAA.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.groupBoxInPut_PAA);
            this.Controls.Add(this.buttonDone_PAA);
            this.Controls.Add(this.buttonHelp_PAA);
            this.Controls.Add(this.groupBoxResult_PAA);
            this.Controls.Add(this.groupBoxTask_PAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 29 | Пождин А.А";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_PAA.ResumeLayout(false);
            this.groupBoxTask_PAA.PerformLayout();
            this.groupBoxResult_PAA.ResumeLayout(false);
            this.groupBoxResult_PAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_PAA)).EndInit();
            this.groupBoxInPut_PAA.ResumeLayout(false);
            this.groupBoxInPut_PAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_PAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_PAA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxResult_PAA;
        private System.Windows.Forms.Label labelResult_PAA;
        private System.Windows.Forms.DataGridView dataGridViewRes_PAA;
        private System.Windows.Forms.Button buttonHelp_PAA;
        private System.Windows.Forms.Button buttonDone_PAA;
        private System.Windows.Forms.GroupBox groupBoxInPut_PAA;
        private System.Windows.Forms.Label labelInPut_PAA;
        private System.Windows.Forms.DataGridView dataGridViewInPut_PAA;
    }
}

