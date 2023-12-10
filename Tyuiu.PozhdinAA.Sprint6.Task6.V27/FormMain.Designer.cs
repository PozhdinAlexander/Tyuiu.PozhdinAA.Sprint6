
namespace Tyuiu.PozhdinAA.Sprint6.Task6.V27
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_PAA));
            this.panelButtons_PAA = new System.Windows.Forms.Panel();
            this.buttonAbout_PAA = new System.Windows.Forms.Button();
            this.buttonDone_PAA = new System.Windows.Forms.Button();
            this.buttonOpenFile_PAA = new System.Windows.Forms.Button();
            this.panelTask = new System.Windows.Forms.Panel();
            this.groupBoxTask_PAA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_PAA = new System.Windows.Forms.TextBox();
            this.panelInput = new System.Windows.Forms.Panel();
            this.groupBoxInput_PAA = new System.Windows.Forms.GroupBox();
            this.textBoxInput_PAA = new System.Windows.Forms.TextBox();
            this.panelOutput = new System.Windows.Forms.Panel();
            this.groupBoxOutput_PAA = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_PAA = new System.Windows.Forms.TextBox();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panelButtons_PAA.SuspendLayout();
            this.panelTask.SuspendLayout();
            this.groupBoxTask_PAA.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.groupBoxInput_PAA.SuspendLayout();
            this.panelOutput.SuspendLayout();
            this.groupBoxOutput_PAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_PAA
            // 
            this.panelButtons_PAA.Controls.Add(this.buttonAbout_PAA);
            this.panelButtons_PAA.Controls.Add(this.buttonDone_PAA);
            this.panelButtons_PAA.Controls.Add(this.buttonOpenFile_PAA);
            this.panelButtons_PAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_PAA.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_PAA.Name = "panelButtons_PAA";
            this.panelButtons_PAA.Size = new System.Drawing.Size(884, 63);
            this.panelButtons_PAA.TabIndex = 0;
            // 
            // buttonAbout_PAA
            // 
            this.buttonAbout_PAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout_PAA.Location = new System.Drawing.Point(792, 4);
            this.buttonAbout_PAA.Name = "buttonAbout_PAA";
            this.buttonAbout_PAA.Size = new System.Drawing.Size(89, 56);
            this.buttonAbout_PAA.TabIndex = 2;
            this.buttonAbout_PAA.Text = "О программе";
            this.buttonAbout_PAA.UseVisualStyleBackColor = true;
            this.buttonAbout_PAA.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonDone_PAA
            // 
            this.buttonDone_PAA.Location = new System.Drawing.Point(99, 4);
            this.buttonDone_PAA.Name = "buttonDone_PAA";
            this.buttonDone_PAA.Size = new System.Drawing.Size(89, 56);
            this.buttonDone_PAA.TabIndex = 1;
            this.buttonDone_PAA.Text = "Выполнить";
            this.buttonDone_PAA.UseVisualStyleBackColor = true;
            this.buttonDone_PAA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile_PAA
            // 
            this.buttonOpenFile_PAA.Location = new System.Drawing.Point(4, 4);
            this.buttonOpenFile_PAA.Name = "buttonOpenFile_PAA";
            this.buttonOpenFile_PAA.Size = new System.Drawing.Size(89, 56);
            this.buttonOpenFile_PAA.TabIndex = 0;
            this.buttonOpenFile_PAA.Text = "Открыть файл";
            this.buttonOpenFile_PAA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_PAA.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // panelTask
            // 
            this.panelTask.Controls.Add(this.groupBoxTask_PAA);
            this.panelTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask.Location = new System.Drawing.Point(0, 63);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(884, 62);
            this.panelTask.TabIndex = 1;
            // 
            // groupBoxTask_PAA
            // 
            this.groupBoxTask_PAA.Controls.Add(this.textBoxTask_PAA);
            this.groupBoxTask_PAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_PAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_PAA.Name = "groupBoxTask_PAA";
            this.groupBoxTask_PAA.Size = new System.Drawing.Size(884, 62);
            this.groupBoxTask_PAA.TabIndex = 0;
            this.groupBoxTask_PAA.TabStop = false;
            this.groupBoxTask_PAA.Text = "Условие:";
            // 
            // textBoxTask_PAA
            // 
            this.textBoxTask_PAA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_PAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_PAA.Location = new System.Drawing.Point(3, 16);
            this.textBoxTask_PAA.Multiline = true;
            this.textBoxTask_PAA.Name = "textBoxTask_PAA";
            this.textBoxTask_PAA.ReadOnly = true;
            this.textBoxTask_PAA.Size = new System.Drawing.Size(878, 43);
            this.textBoxTask_PAA.TabIndex = 0;
            this.textBoxTask_PAA.Text = resources.GetString("textBoxTask_PAA.Text");
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.groupBoxInput_PAA);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInput.Location = new System.Drawing.Point(0, 125);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(450, 386);
            this.panelInput.TabIndex = 2;
            // 
            // groupBoxInput_PAA
            // 
            this.groupBoxInput_PAA.Controls.Add(this.textBoxInput_PAA);
            this.groupBoxInput_PAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_PAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_PAA.Name = "groupBoxInput_PAA";
            this.groupBoxInput_PAA.Size = new System.Drawing.Size(450, 386);
            this.groupBoxInput_PAA.TabIndex = 0;
            this.groupBoxInput_PAA.TabStop = false;
            this.groupBoxInput_PAA.Text = "Ввод:";
            // 
            // textBoxInput_PAA
            // 
            this.textBoxInput_PAA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxInput_PAA.Location = new System.Drawing.Point(3, 16);
            this.textBoxInput_PAA.Multiline = true;
            this.textBoxInput_PAA.Name = "textBoxInput_PAA";
            this.textBoxInput_PAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_PAA.Size = new System.Drawing.Size(444, 367);
            this.textBoxInput_PAA.TabIndex = 0;
            // 
            // panelOutput
            // 
            this.panelOutput.Controls.Add(this.groupBoxOutput_PAA);
            this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutput.Location = new System.Drawing.Point(450, 125);
            this.panelOutput.Name = "panelOutput";
            this.panelOutput.Size = new System.Drawing.Size(434, 386);
            this.panelOutput.TabIndex = 3;
            // 
            // groupBoxOutput_PAA
            // 
            this.groupBoxOutput_PAA.Controls.Add(this.textBoxOutput_PAA);
            this.groupBoxOutput_PAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_PAA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_PAA.Name = "groupBoxOutput_PAA";
            this.groupBoxOutput_PAA.Size = new System.Drawing.Size(434, 386);
            this.groupBoxOutput_PAA.TabIndex = 0;
            this.groupBoxOutput_PAA.TabStop = false;
            this.groupBoxOutput_PAA.Text = "Вывод:";
            // 
            // textBoxOutput_PAA
            // 
            this.textBoxOutput_PAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput_PAA.Location = new System.Drawing.Point(3, 16);
            this.textBoxOutput_PAA.Multiline = true;
            this.textBoxOutput_PAA.Name = "textBoxOutput_PAA";
            this.textBoxOutput_PAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_PAA.Size = new System.Drawing.Size(428, 367);
            this.textBoxOutput_PAA.TabIndex = 1;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // FormMain_PAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.panelOutput);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.panelButtons_PAA);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "FormMain_PAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 27 | Пождин А. А.";
            this.panelButtons_PAA.ResumeLayout(false);
            this.panelTask.ResumeLayout(false);
            this.groupBoxTask_PAA.ResumeLayout(false);
            this.groupBoxTask_PAA.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.groupBoxInput_PAA.ResumeLayout(false);
            this.groupBoxInput_PAA.PerformLayout();
            this.panelOutput.ResumeLayout(false);
            this.groupBoxOutput_PAA.ResumeLayout(false);
            this.groupBoxOutput_PAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_PAA;
        private System.Windows.Forms.Button buttonAbout_PAA;
        private System.Windows.Forms.Button buttonDone_PAA;
        private System.Windows.Forms.Button buttonOpenFile_PAA;
        private System.Windows.Forms.Panel panelTask;
        private System.Windows.Forms.GroupBox groupBoxTask_PAA;
        private System.Windows.Forms.TextBox textBoxTask_PAA;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.GroupBox groupBoxInput_PAA;
        private System.Windows.Forms.TextBox textBoxInput_PAA;
        private System.Windows.Forms.Panel panelOutput;
        private System.Windows.Forms.GroupBox groupBoxOutput_PAA;
        private System.Windows.Forms.TextBox textBoxOutput_PAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

