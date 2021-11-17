namespace ComparadorArchivos
{
    partial class FormDiferencias
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
            this.Texto2 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.volverACompararToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Texto1 = new System.Windows.Forms.RichTextBox();
            this.Grupo1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Grupo2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.Grupo1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Grupo2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Texto2
            // 
            this.Texto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Texto2.ContextMenuStrip = this.contextMenuStrip1;
            this.Texto2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Texto2.ForeColor = System.Drawing.Color.Yellow;
            this.Texto2.Location = new System.Drawing.Point(3, 16);
            this.Texto2.Name = "Texto2";
            this.Texto2.Size = new System.Drawing.Size(344, 672);
            this.Texto2.TabIndex = 0;
            this.Texto2.Text = "hola";
            this.Texto2.WordWrap = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverACompararToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 26);
            // 
            // volverACompararToolStripMenuItem
            // 
            this.volverACompararToolStripMenuItem.Name = "volverACompararToolStripMenuItem";
            this.volverACompararToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.volverACompararToolStripMenuItem.Text = "Volver a comparar";
            this.volverACompararToolStripMenuItem.Click += new System.EventHandler(this.volverACompararToolStripMenuItem_Click);
            // 
            // Texto1
            // 
            this.Texto1.AcceptsTab = true;
            this.Texto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Texto1.ContextMenuStrip = this.contextMenuStrip1;
            this.Texto1.DetectUrls = false;
            this.Texto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Texto1.ForeColor = System.Drawing.Color.Yellow;
            this.Texto1.Location = new System.Drawing.Point(3, 16);
            this.Texto1.Name = "Texto1";
            this.Texto1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Texto1.Size = new System.Drawing.Size(348, 672);
            this.Texto1.TabIndex = 0;
            this.Texto1.Text = "hola";
            this.Texto1.WordWrap = false;
            // 
            // Grupo1
            // 
            this.Grupo1.Controls.Add(this.Texto1);
            this.Grupo1.Controls.Add(this.textBox1);
            this.Grupo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grupo1.Location = new System.Drawing.Point(0, 0);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Size = new System.Drawing.Size(354, 691);
            this.Grupo1.TabIndex = 0;
            this.Grupo1.TabStop = false;
            this.Grupo1.Text = "Archivo 1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Grupo1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Grupo2);
            this.splitContainer1.Size = new System.Drawing.Size(708, 691);
            this.splitContainer1.SplitterDistance = 354;
            this.splitContainer1.TabIndex = 1;
            // 
            // Grupo2
            // 
            this.Grupo2.Controls.Add(this.Texto2);
            this.Grupo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grupo2.Location = new System.Drawing.Point(0, 0);
            this.Grupo2.Name = "Grupo2";
            this.Grupo2.Size = new System.Drawing.Size(350, 691);
            this.Grupo2.TabIndex = 0;
            this.Grupo2.TabStop = false;
            this.Grupo2.Text = "Archivo 2";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 668);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(708, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(108, 20);
            this.textBox1.TabIndex = 1;
            // 
            // FormDiferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 691);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormDiferencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDiferencias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDiferencias_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.Grupo1.ResumeLayout(false);
            this.Grupo1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Grupo2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Texto2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem volverACompararToolStripMenuItem;
        private System.Windows.Forms.RichTextBox Texto1;
        private System.Windows.Forms.GroupBox Grupo1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox Grupo2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;

    }
}