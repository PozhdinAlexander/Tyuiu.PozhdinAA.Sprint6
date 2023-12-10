
namespace Tyuiu.PozhdinAA.Sprint6.Task7.V27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_PAA));
            this.groupBox1_PAA = new System.Windows.Forms.GroupBox();
            this.textBox2_PAA = new System.Windows.Forms.TextBox();
            this.groupBoxInput_PAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput_PAA = new System.Windows.Forms.DataGridView();
            this.groupBox3_PAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput_PAA = new System.Windows.Forms.DataGridView();
            this.buttonSave_PAA = new System.Windows.Forms.Button();
            this.buttonHelp_PAA = new System.Windows.Forms.Button();
            this.buttonExecute_PAA = new System.Windows.Forms.Button();
            this.buttonFileDialog_PAA = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1_PAA.SuspendLayout();
            this.groupBoxInput_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_PAA)).BeginInit();
            this.groupBox3_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_PAA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1_PAA
            // 
            this.groupBox1_PAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1_PAA.Controls.Add(this.textBox2_PAA);
            this.groupBox1_PAA.Location = new System.Drawing.Point(12, 76);
            this.groupBox1_PAA.Name = "groupBox1_PAA";
            this.groupBox1_PAA.Size = new System.Drawing.Size(1157, 71);
            this.groupBox1_PAA.TabIndex = 23;
            this.groupBox1_PAA.TabStop = false;
            this.groupBox1_PAA.Text = "Условие";
            // 
            // textBox2_PAA
            // 
            this.textBox2_PAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2_PAA.Location = new System.Drawing.Point(3, 16);
            this.textBox2_PAA.Multiline = true;
            this.textBox2_PAA.Name = "textBox2_PAA";
            this.textBox2_PAA.ReadOnly = true;
            this.textBox2_PAA.Size = new System.Drawing.Size(1151, 52);
            this.textBox2_PAA.TabIndex = 0;
            this.textBox2_PAA.Text = resources.GetString("textBox2_PAA.Text");
            // 
            // groupBoxInput_PAA
            // 
            this.groupBoxInput_PAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxInput_PAA.Controls.Add(this.dataGridViewInput_PAA);
            this.groupBoxInput_PAA.Location = new System.Drawing.Point(15, 151);
            this.groupBoxInput_PAA.Name = "groupBoxInput_PAA";
            this.groupBoxInput_PAA.Size = new System.Drawing.Size(734, 431);
            this.groupBoxInput_PAA.TabIndex = 31;
            this.groupBoxInput_PAA.TabStop = false;
            this.groupBoxInput_PAA.Text = "Ввод:";
            // 
            // dataGridViewInput_PAA
            // 
            this.dataGridViewInput_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_PAA.ColumnHeadersVisible = false;
            this.dataGridViewInput_PAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput_PAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewInput_PAA.Name = "dataGridViewInput_PAA";
            this.dataGridViewInput_PAA.RowHeadersVisible = false;
            this.dataGridViewInput_PAA.Size = new System.Drawing.Size(728, 412);
            this.dataGridViewInput_PAA.TabIndex = 0;
            this.dataGridViewInput_PAA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInput_CellContentClick);
            // 
            // groupBox3_PAA
            // 
            this.groupBox3_PAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3_PAA.Controls.Add(this.dataGridViewOutput_PAA);
            this.groupBox3_PAA.Location = new System.Drawing.Point(755, 151);
            this.groupBox3_PAA.Name = "groupBox3_PAA";
            this.groupBox3_PAA.Size = new System.Drawing.Size(410, 431);
            this.groupBox3_PAA.TabIndex = 32;
            this.groupBox3_PAA.TabStop = false;
            this.groupBox3_PAA.Text = "Вывод:";
            // 
            // dataGridViewOutput_PAA
            // 
            this.dataGridViewOutput_PAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_PAA.ColumnHeadersVisible = false;
            this.dataGridViewOutput_PAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput_PAA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewOutput_PAA.Name = "dataGridViewOutput_PAA";
            this.dataGridViewOutput_PAA.RowHeadersVisible = false;
            this.dataGridViewOutput_PAA.Size = new System.Drawing.Size(404, 412);
            this.dataGridViewOutput_PAA.TabIndex = 0;
            // 
            // buttonSave_PAA
            // 
            this.buttonSave_PAA.Enabled = false;
            this.buttonSave_PAA.Image = global::Tyuiu.KosovskihVA.Sprint6.Task7.V27.Properties.Resources.disk;
            this.buttonSave_PAA.Location = new System.Drawing.Point(167, 12);
            this.buttonSave_PAA.Name = "buttonSave_PAA";
            this.buttonSave_PAA.Size = new System.Drawing.Size(70, 60);
            this.buttonSave_PAA.TabIndex = 30;
            this.buttonSave_PAA.UseVisualStyleBackColor = true;
            this.buttonSave_PAA.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonHelp_PAA
            // 
            this.buttonHelp_PAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_PAA.Image = global::Tyuiu.KosovskihVA.Sprint6.Task7.V27.Properties.Resources.comment;
            this.buttonHelp_PAA.Location = new System.Drawing.Point(1099, 12);
            this.buttonHelp_PAA.Name = "buttonHelp_PAA";
            this.buttonHelp_PAA.Size = new System.Drawing.Size(70, 60);
            this.buttonHelp_PAA.TabIndex = 29;
            this.buttonHelp_PAA.UseVisualStyleBackColor = true;
            this.buttonHelp_PAA.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonExecute_PAA
            // 
            this.buttonExecute_PAA.Enabled = false;
            this.buttonExecute_PAA.Image = global::Tyuiu.KosovskihVA.Sprint6.Task7.V27.Properties.Resources.application_go;
            this.buttonExecute_PAA.Location = new System.Drawing.Point(91, 12);
            this.buttonExecute_PAA.Name = "buttonExecute_PAA";
            this.buttonExecute_PAA.Size = new System.Drawing.Size(70, 60);
            this.buttonExecute_PAA.TabIndex = 28;
            this.buttonExecute_PAA.UseVisualStyleBackColor = true;
            this.buttonExecute_PAA.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonFileDialog_PAA
            // 
            this.buttonFileDialog_PAA.Image = global::Tyuiu.KosovskihVA.Sprint6.Task7.V27.Properties.Resources.application_add;
            this.buttonFileDialog_PAA.Location = new System.Drawing.Point(15, 12);
            this.buttonFileDialog_PAA.Name = "buttonFileDialog_PAA";
            this.buttonFileDialog_PAA.Size = new System.Drawing.Size(70, 60);
            this.buttonFileDialog_PAA.TabIndex = 27;
            this.buttonFileDialog_PAA.UseVisualStyleBackColor = true;
            this.buttonFileDialog_PAA.Click += new System.EventHandler(this.buttonFileDialog_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // FormMain_PAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 594);
            this.Controls.Add(this.groupBox3_PAA);
            this.Controls.Add(this.groupBoxInput_PAA);
            this.Controls.Add(this.buttonSave_PAA);
            this.Controls.Add(this.buttonHelp_PAA);
            this.Controls.Add(this.buttonExecute_PAA);
            this.Controls.Add(this.buttonFileDialog_PAA);
            this.Controls.Add(this.groupBox1_PAA);
            this.Name = "FormMain_PAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 27 | Пождин А.А. АСОиУБ-23-1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1_PAA.ResumeLayout(false);
            this.groupBox1_PAA.PerformLayout();
            this.groupBoxInput_PAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_PAA)).EndInit();
            this.groupBox3_PAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_PAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_PAA;
        private System.Windows.Forms.TextBox textBox2_PAA;
        private System.Windows.Forms.Button buttonHelp_PAA;
        private System.Windows.Forms.Button buttonExecute_PAA;
        private System.Windows.Forms.Button buttonFileDialog_PAA;
        private System.Windows.Forms.Button buttonSave_PAA;
        private System.Windows.Forms.GroupBox groupBoxInput_PAA;
        private System.Windows.Forms.DataGridView dataGridViewInput_PAA;
        private System.Windows.Forms.GroupBox groupBox3_PAA;
        private System.Windows.Forms.DataGridView dataGridViewOutput_PAA;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

