
namespace Tyuiu.PozhdinAA.Sprint6.Task0.V1
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
            this.groupBoxTask0_PAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PAA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula_PAA = new System.Windows.Forms.PictureBox();
            this.groupBoxDannue_PAA = new System.Windows.Forms.GroupBox();
            this.labelVarX_PAA = new System.Windows.Forms.Label();
            this.textBoxVarX_PAA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_PAA = new System.Windows.Forms.GroupBox();
            this.labelResult_PAA = new System.Windows.Forms.Label();
            this.textBoxResult_PAA = new System.Windows.Forms.TextBox();
            this.buttonPushMe_PAA = new System.Windows.Forms.Button();
            this.buttonInfo_PAA = new System.Windows.Forms.Button();
            this.groupBoxTask0_PAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PAA)).BeginInit();
            this.groupBoxDannue_PAA.SuspendLayout();
            this.groupBoxResult_PAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask0_PAA
            // 
            this.groupBoxTask0_PAA.Controls.Add(this.textBoxTask_PAA);
            this.groupBoxTask0_PAA.Controls.Add(this.pictureBoxFormula_PAA);
            this.groupBoxTask0_PAA.Location = new System.Drawing.Point(14, 27);
            this.groupBoxTask0_PAA.Name = "groupBoxTask0_PAA";
            this.groupBoxTask0_PAA.Size = new System.Drawing.Size(462, 150);
            this.groupBoxTask0_PAA.TabIndex = 0;
            this.groupBoxTask0_PAA.TabStop = false;
            this.groupBoxTask0_PAA.Text = "Условие";
            // 
            // textBoxTask_PAA
            // 
            this.textBoxTask_PAA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_PAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PAA.Location = new System.Drawing.Point(11, 19);
            this.textBoxTask_PAA.Multiline = true;
            this.textBoxTask_PAA.Name = "textBoxTask_PAA";
            this.textBoxTask_PAA.ReadOnly = true;
            this.textBoxTask_PAA.Size = new System.Drawing.Size(197, 125);
            this.textBoxTask_PAA.TabIndex = 2;
            this.textBoxTask_PAA.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_PAA
            // 
            this.pictureBoxFormula_PAA.Image = global::Tyuiu.PozhdinAA.Sprint6.Task0.V1.Properties.Resources.Untitled;
            this.pictureBoxFormula_PAA.InitialImage = null;
            this.pictureBoxFormula_PAA.Location = new System.Drawing.Point(298, 19);
            this.pictureBoxFormula_PAA.Name = "pictureBoxFormula_PAA";
            this.pictureBoxFormula_PAA.Size = new System.Drawing.Size(141, 72);
            this.pictureBoxFormula_PAA.TabIndex = 1;
            this.pictureBoxFormula_PAA.TabStop = false;
            this.pictureBoxFormula_PAA.Click += new System.EventHandler(this.pictureBoxFormula_PAA_Click);
            // 
            // groupBoxDannue_PAA
            // 
            this.groupBoxDannue_PAA.Controls.Add(this.labelVarX_PAA);
            this.groupBoxDannue_PAA.Controls.Add(this.textBoxVarX_PAA);
            this.groupBoxDannue_PAA.Location = new System.Drawing.Point(14, 183);
            this.groupBoxDannue_PAA.Name = "groupBoxDannue_PAA";
            this.groupBoxDannue_PAA.Size = new System.Drawing.Size(292, 100);
            this.groupBoxDannue_PAA.TabIndex = 1;
            this.groupBoxDannue_PAA.TabStop = false;
            this.groupBoxDannue_PAA.Text = "Ввод данных";
            // 
            // labelVarX_PAA
            // 
            this.labelVarX_PAA.AutoSize = true;
            this.labelVarX_PAA.Location = new System.Drawing.Point(8, 34);
            this.labelVarX_PAA.Name = "labelVarX_PAA";
            this.labelVarX_PAA.Size = new System.Drawing.Size(90, 13);
            this.labelVarX_PAA.TabIndex = 2;
            this.labelVarX_PAA.Text = "Переменная X : ";
            // 
            // textBoxVarX_PAA
            // 
            this.textBoxVarX_PAA.Location = new System.Drawing.Point(11, 50);
            this.textBoxVarX_PAA.Name = "textBoxVarX_PAA";
            this.textBoxVarX_PAA.Size = new System.Drawing.Size(100, 20);
            this.textBoxVarX_PAA.TabIndex = 0;
            this.textBoxVarX_PAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_PAA_KeyPress);
            // 
            // groupBoxResult_PAA
            // 
            this.groupBoxResult_PAA.Controls.Add(this.labelResult_PAA);
            this.groupBoxResult_PAA.Controls.Add(this.textBoxResult_PAA);
            this.groupBoxResult_PAA.Location = new System.Drawing.Point(312, 183);
            this.groupBoxResult_PAA.Name = "groupBoxResult_PAA";
            this.groupBoxResult_PAA.Size = new System.Drawing.Size(164, 100);
            this.groupBoxResult_PAA.TabIndex = 2;
            this.groupBoxResult_PAA.TabStop = false;
            this.groupBoxResult_PAA.Text = "Вывод данных";
            this.groupBoxResult_PAA.Enter += new System.EventHandler(this.groupBoxResult_PAA_Enter);
            // 
            // labelResult_PAA
            // 
            this.labelResult_PAA.AutoSize = true;
            this.labelResult_PAA.Location = new System.Drawing.Point(9, 34);
            this.labelResult_PAA.Name = "labelResult_PAA";
            this.labelResult_PAA.Size = new System.Drawing.Size(65, 13);
            this.labelResult_PAA.TabIndex = 2;
            this.labelResult_PAA.Text = "Результат :";
            // 
            // textBoxResult_PAA
            // 
            this.textBoxResult_PAA.Location = new System.Drawing.Point(12, 50);
            this.textBoxResult_PAA.Name = "textBoxResult_PAA";
            this.textBoxResult_PAA.ReadOnly = true;
            this.textBoxResult_PAA.Size = new System.Drawing.Size(141, 20);
            this.textBoxResult_PAA.TabIndex = 3;
            this.textBoxResult_PAA.TextChanged += new System.EventHandler(this.textBoxResult_PAA_TextChanged);
            // 
            // buttonPushMe_PAA
            // 
            this.buttonPushMe_PAA.Location = new System.Drawing.Point(362, 289);
            this.buttonPushMe_PAA.Name = "buttonPushMe_PAA";
            this.buttonPushMe_PAA.Size = new System.Drawing.Size(114, 28);
            this.buttonPushMe_PAA.TabIndex = 3;
            this.buttonPushMe_PAA.Text = "Выполнить";
            this.buttonPushMe_PAA.UseVisualStyleBackColor = true;
            this.buttonPushMe_PAA.Click += new System.EventHandler(this.buttonPushMe_PAA_Click);
            // 
            // buttonInfo_PAA
            // 
            this.buttonInfo_PAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_PAA.Location = new System.Drawing.Point(312, 289);
            this.buttonInfo_PAA.Name = "buttonInfo_PAA";
            this.buttonInfo_PAA.Size = new System.Drawing.Size(33, 28);
            this.buttonInfo_PAA.TabIndex = 4;
            this.buttonInfo_PAA.Text = "?";
            this.buttonInfo_PAA.UseVisualStyleBackColor = true;
            this.buttonInfo_PAA.Click += new System.EventHandler(this.buttonInfo_PAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 322);
            this.Controls.Add(this.buttonInfo_PAA);
            this.Controls.Add(this.buttonPushMe_PAA);
            this.Controls.Add(this.groupBoxResult_PAA);
            this.Controls.Add(this.groupBoxDannue_PAA);
            this.Controls.Add(this.groupBoxTask0_PAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 1 | Пождин А.А";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask0_PAA.ResumeLayout(false);
            this.groupBoxTask0_PAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_PAA)).EndInit();
            this.groupBoxDannue_PAA.ResumeLayout(false);
            this.groupBoxDannue_PAA.PerformLayout();
            this.groupBoxResult_PAA.ResumeLayout(false);
            this.groupBoxResult_PAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask0_PAA;
        private System.Windows.Forms.GroupBox groupBoxDannue_PAA;
        private System.Windows.Forms.Label labelVarX_PAA;
        private System.Windows.Forms.TextBox textBoxVarX_PAA;
        private System.Windows.Forms.GroupBox groupBoxResult_PAA;
        private System.Windows.Forms.Label labelResult_PAA;
        private System.Windows.Forms.TextBox textBoxResult_PAA;
        private System.Windows.Forms.Button buttonPushMe_PAA;
        private System.Windows.Forms.Button buttonInfo_PAA;
        private System.Windows.Forms.TextBox textBoxTask_PAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_PAA;
    }
}

