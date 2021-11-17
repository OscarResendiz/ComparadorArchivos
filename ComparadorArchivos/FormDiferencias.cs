using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComparadorArchivos
{
    public partial class FormDiferencias : Form
    {
        private string Codigo1;
        private string Codigo2;
        private string Caption1;
        private string Caption2;
        public FormDiferencias()
        {
            InitializeComponent();
        }

        public FormDiferencias(string codigo1, string caption1, string codigo2, string caption2)
        {
            Codigo1 = codigo1;
            Codigo2 = codigo2;
            Caption1 = caption1;
            Caption2 = caption2;
            InitializeComponent();
        }

        private void FormDiferencias_Load(object sender, EventArgs e)
        {
            Texto1.Text = Codigo1;
            Texto2.Text = Codigo2;
            Grupo1.Text = Caption1;
            Grupo2.Text = Caption2;
            progressBar1.Value = 0;
            timer1.Enabled = true;

        }

        private void volverACompararToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Texto1.SelectionStart = 0;
            Texto1.SelectionLength = Texto1.Text.Length;
            Texto1.SelectionColor = Color.Yellow;
            Texto1.SelectionBackColor = Texto1.BackColor;

            Texto2.SelectionStart = 0;
            Texto2.SelectionLength = Texto2.Text.Length;
            Texto2.SelectionColor = Color.Yellow;
            Texto2.SelectionBackColor = Texto2.BackColor;
            Codigo1 = Texto1.Text;
            Codigo2 = Texto2.Text;
            progressBar1.Value = 0;
            textBox1.Focus();

            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ComparaCadenas();
        }
        void ComparaCadenas()
        {
            int i, n,k,a;
            if (Codigo1.Length <= Codigo2.Length)
                n = Codigo1.Length;
            else
                n = Codigo2.Length;
            CProgreso pro=new CProgreso();
            pro.Tipo= TipoAccion.INICIO;
            pro.Leng = n;
            backgroundWorker1.ReportProgress(0, pro);
            i = 0;
            while (i < n)
            {
                if (Codigo1[i] != Codigo2[i])
                {
                    a = i;
                    k = 1;
                    while (i<n && Codigo1[i] != Codigo2[i])
                    {
                        k++;
                        i++;
                    }
                    // hay una diferencia
                    //la marco en los dos editores
                    pro = new CProgreso();
                    pro.SelectionStart1 = a;
                    pro.SelectionLength1 = k;
                    pro.SelectionColor1 = Color.Red;
                    pro.SelectionBackColor1 = Color.DarkGray;

                    pro.SelectionStart2 = a;
                    pro.SelectionLength2 = k;
                    pro.SelectionColor2 = Color.Red;
                    pro.SelectionBackColor2 = Color.DarkGray;
                    pro.Leng = i;
                    pro.Tipo = TipoAccion.DIFERENCIA;
                    backgroundWorker1.ReportProgress(0, pro);
                }
                else
                {
                    i++;
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            CProgreso pro = (CProgreso)e.UserState;
            switch (pro.Tipo)
            {
                case TipoAccion.INICIO:
                    //inicializa valores
                    progressBar1.Maximum = pro.Leng;
                    progressBar1.Value = 0;
                    break;
                case TipoAccion.DIFERENCIA:
                    Texto1.SelectionStart = pro.SelectionStart1;
                    Texto1.SelectionLength = pro.SelectionLength1;
                    Texto1.SelectionColor = pro.SelectionColor1;
                    Texto1.SelectionBackColor = pro.SelectionBackColor1;

                    Texto2.SelectionStart = pro.SelectionStart2;
                    Texto2.SelectionLength = pro.SelectionLength2;
                    Texto2.SelectionColor = pro.SelectionColor2;
                    Texto2.SelectionBackColor = pro.SelectionBackColor2;
                    if(progressBar1.Maximum>=pro.Leng)
                        progressBar1.Value = pro.Leng;
                  //  progressBar1.Refresh();
                    break;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Texto2.Refresh();
            Texto1.Refresh();
           // MessageBox.Show("Analisis terminado");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            textBox1.Focus();
            backgroundWorker1.RunWorkerAsync();

        }
    }
}
