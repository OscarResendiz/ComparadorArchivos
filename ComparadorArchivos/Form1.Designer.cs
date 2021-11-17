namespace ComparadorArchivos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BCerrar = new System.Windows.Forms.Button();
            this.Banalizar = new System.Windows.Forms.Button();
            this.BBuscar2 = new System.Windows.Forms.Button();
            this.BBuscar1 = new System.Windows.Forms.Button();
            this.TxtRuta2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRuta1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ForderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.Lista = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuDiferencias = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbrir1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbrir2 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BCerrar);
            this.panel1.Controls.Add(this.Banalizar);
            this.panel1.Controls.Add(this.BBuscar2);
            this.panel1.Controls.Add(this.BBuscar1);
            this.panel1.Controls.Add(this.TxtRuta2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxtRuta1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 91);
            this.panel1.TabIndex = 0;
            // 
            // BCerrar
            // 
            this.BCerrar.Location = new System.Drawing.Point(613, 45);
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.Size = new System.Drawing.Size(75, 23);
            this.BCerrar.TabIndex = 7;
            this.BCerrar.Text = "Cerrar";
            this.BCerrar.UseVisualStyleBackColor = true;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // Banalizar
            // 
            this.Banalizar.Location = new System.Drawing.Point(613, 10);
            this.Banalizar.Name = "Banalizar";
            this.Banalizar.Size = new System.Drawing.Size(75, 23);
            this.Banalizar.TabIndex = 6;
            this.Banalizar.Text = "Analizar";
            this.Banalizar.UseVisualStyleBackColor = true;
            this.Banalizar.Click += new System.EventHandler(this.Banalizar_Click);
            // 
            // BBuscar2
            // 
            this.BBuscar2.Location = new System.Drawing.Point(537, 45);
            this.BBuscar2.Name = "BBuscar2";
            this.BBuscar2.Size = new System.Drawing.Size(36, 23);
            this.BBuscar2.TabIndex = 5;
            this.BBuscar2.Text = "...";
            this.BBuscar2.UseVisualStyleBackColor = true;
            this.BBuscar2.Click += new System.EventHandler(this.BBuscar2_Click);
            // 
            // BBuscar1
            // 
            this.BBuscar1.Location = new System.Drawing.Point(537, 12);
            this.BBuscar1.Name = "BBuscar1";
            this.BBuscar1.Size = new System.Drawing.Size(36, 23);
            this.BBuscar1.TabIndex = 4;
            this.BBuscar1.Text = "...";
            this.BBuscar1.UseVisualStyleBackColor = true;
            this.BBuscar1.Click += new System.EventHandler(this.BBuscar1_Click);
            // 
            // TxtRuta2
            // 
            this.TxtRuta2.Location = new System.Drawing.Point(67, 47);
            this.TxtRuta2.Name = "TxtRuta2";
            this.TxtRuta2.Size = new System.Drawing.Size(464, 20);
            this.TxtRuta2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ruta 2";
            // 
            // TxtRuta1
            // 
            this.TxtRuta1.Location = new System.Drawing.Point(64, 13);
            this.TxtRuta1.Name = "TxtRuta1";
            this.TxtRuta1.Size = new System.Drawing.Size(467, 20);
            this.TxtRuta1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta 1";
            // 
            // Lista
            // 
            this.Lista.ContextMenuStrip = this.contextMenuStrip1;
            this.Lista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(0, 91);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(700, 450);
            this.Lista.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDiferencias,
            this.MenuAbrir1,
            this.MenuAbrir2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 70);
            // 
            // MenuDiferencias
            // 
            this.MenuDiferencias.Name = "MenuDiferencias";
            this.MenuDiferencias.Size = new System.Drawing.Size(153, 22);
            this.MenuDiferencias.Text = "Ver Diferencia";
            this.MenuDiferencias.Click += new System.EventHandler(this.MenuDiferencias_Click);
            // 
            // MenuAbrir1
            // 
            this.MenuAbrir1.Name = "MenuAbrir1";
            this.MenuAbrir1.Size = new System.Drawing.Size(153, 22);
            this.MenuAbrir1.Text = "Abrir Archivo 1";
            // 
            // MenuAbrir2
            // 
            this.MenuAbrir2.Name = "MenuAbrir2";
            this.MenuAbrir2.Size = new System.Drawing.Size(153, 22);
            this.MenuAbrir2.Text = "Abrir Archivo 2";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 29);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 570);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Analizador de archivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.Button Banalizar;
        private System.Windows.Forms.Button BBuscar2;
        private System.Windows.Forms.Button BBuscar1;
        private System.Windows.Forms.TextBox TxtRuta2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRuta1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog ForderDlg;
        private System.Windows.Forms.ListBox Lista;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuDiferencias;
        private System.Windows.Forms.ToolStripMenuItem MenuAbrir1;
        private System.Windows.Forms.ToolStripMenuItem MenuAbrir2;
    }
}

