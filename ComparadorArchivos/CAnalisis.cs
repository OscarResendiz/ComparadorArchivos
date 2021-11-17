using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparadorArchivos
{
    public class CAnalisis
    {
        public string Archivo1;
        public string Archivo2;
        public string Descripcion;
        public CAnalisis()
        {
            Descripcion = "";
        }
        public override string ToString()
        {
            return Archivo2 + "->" + Descripcion;
        }
        private string LeeArchivo(string nombre)
        {
            string s = "";
            if (System.IO.File.Exists(nombre))
            {
                System.IO.StreamReader sr;
                sr = System.IO.File.OpenText(nombre);
                s = sr.ReadToEnd();
                sr.Close();
            }
            return s;
        }
        public string TextoArchivo1
        {
            get
            {
                //lee el archivo, y regresa el texto
                return LeeArchivo(Archivo1);
            }
        }
        public string TextoArchivo2
        {
            get
            {
                //lee el archivo, y regresa el texto
                return LeeArchivo(Archivo2);
            }
        }
    }
}
