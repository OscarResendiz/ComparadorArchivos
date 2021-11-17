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
    public partial class Form1 : Form
    {
        private List<CAnalisis> ListaAnalisis;
        private List<string> Archivos1;
        public Form1()
        {
            InitializeComponent();
        }

        private void BBuscar1_Click(object sender, EventArgs e)
        {
            if (ForderDlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            TxtRuta1.Text = ForderDlg.SelectedPath;
        }

        private void BBuscar2_Click(object sender, EventArgs e)
        {
            if (ForderDlg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            TxtRuta2.Text = ForderDlg.SelectedPath;

        }
        public bool Enabled
        {
            set
            {
                TxtRuta1.Enabled = value;
                TxtRuta2.Enabled = value;
                BBuscar1.Enabled = value;
                BBuscar2.Enabled = value;
                Banalizar.Enabled = value;
            }
        }
        public string Msg
        {
            set
            {
                label3.Text = value;
            }
        }
        private void Banalizar_Click(object sender, EventArgs e)
        {
            if (TxtRuta1.Text == "")
            {
                Msg = "Falta la ruta 1";
                return;
            }
            if (TxtRuta1.Text == "")
            {
                Msg = "Falta la ruta 2";
                return;
            }
            Enabled = false;
            Lista.Items.Clear();
            backgroundWorker1.RunWorkerAsync();
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (System.IO.File.Exists(Application.StartupPath + "\\Rutas.txt"))
            {
                System.IO.StreamReader sr;
                sr = System.IO.File.OpenText(Application.StartupPath + "\\Rutas.txt");
                TxtRuta1.Text = sr.ReadLine();
                TxtRuta2.Text = sr.ReadLine();
                sr.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                
                System.IO.StreamWriter sw;
                sw = System.IO.File.CreateText(Application.StartupPath + "\\Rutas.txt");
                sw.WriteLine(TxtRuta1.Text);
                sw.WriteLine(TxtRuta2.Text);
                sw.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if(ListaAnalisis==null)
                ListaAnalisis = new List<CAnalisis>();
            ListaAnalisis.Clear();
            Archivos1 = AnalizaDirectorio(TxtRuta1.Text);
            //ahora empiezo a comprar cada arcii
            foreach (string archivo in Archivos1)
            {
                CAnalisis a;
                a=AnalizaArchivo(archivo);
                if (a.Descripcion != "")
                {
                    //se encontro alguna diferencia
                    backgroundWorker1.ReportProgress(0, a);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 0:
                    CAnalisis a=(CAnalisis)e.UserState;
                    Lista.Items.Add(a);
                    break;
                case 1:
                    Msg = e.UserState.ToString();
                    break;
            }
        }
        private List<string > AnalizaDirectorio(string origen)
        {
            backgroundWorker1.ReportProgress(1,"Analizando directorio"+origen);
            List<string> l = new List<string>();
            string[] files;
            string[] directorios;
            //recorre todos los directorios y regresa la lista de archivos que hay
            files = System.IO.Directory.GetFiles(origen);
            foreach (string file in files)
            {
                l.Add(file);
            }
            //me traigo primero todos los archivos
            directorios = System.IO.Directory.GetDirectories(origen);
            //recorro todos los directorios
            foreach (string dir in directorios)
            {
                l.AddRange(AnalizaDirectorio(dir));
            }
            return l;
        }
        private CAnalisis AnalizaArchivo(string archivo)
        {
            backgroundWorker1.ReportProgress(1, "Analizando archivo" + archivo);
            string s1, s2;
            System.IO.StreamReader sr1, sr2;
            CAnalisis analisis = new CAnalisis();
            string archivo2;
            int n=TxtRuta1.Text.Length;
            archivo2 = TxtRuta2.Text+archivo.Substring(n);
            analisis.Archivo1 = archivo;
            analisis.Archivo2 = archivo2;
            //verifico si existe el archivo
            if (System.IO.File.Exists(archivo2) == false)
            {
                //no existe el archivo
                analisis.Descripcion = "No existe el archivo";
                return analisis;
            }
            //si existe el archivo, por lo que ahora comparo las cadenas
            try
            {
                sr1 = System.IO.File.OpenText(archivo);
                s1 = sr1.ReadToEnd();
                sr1.Close();
                sr2 = System.IO.File.OpenText(archivo2);
                s2 = sr2.ReadToEnd();
                sr2.Close();
            }
            catch (System.Exception ex)
            {
                analisis.Descripcion = ex.Message;
                return analisis;
            }
            if (s1 != s2)
            {
                analisis.Descripcion = "Los archivos son diferentes";
                return analisis;
            }
            return analisis;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Enabled = true;
            Msg = "Archivos con diferencias: "+Lista.Items.Count.ToString();
        }

        private void MenuDiferencias_Click(object sender, EventArgs e)
        {
            if (Lista.SelectedIndex == -1)
                return;
            CAnalisis obj = (CAnalisis)Lista.SelectedItem;
            //me traigo los nosmbres de los archivos
            FormDiferencias dlg = new FormDiferencias(obj.TextoArchivo1, obj.Archivo1, obj.TextoArchivo2, obj.Archivo2);
            dlg.ShowDialog();
        }

            
    }
}
