using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparadorArchivos
{
    public enum TipoAccion
    {
        INICIO
        ,DIFERENCIA
    };
    public class CProgreso
    {
        public TipoAccion Tipo;
        public int Leng;
        public int SelectionStart1;
        public int SelectionLength1;
        public System.Drawing.Color SelectionColor1;
        public System.Drawing.Color SelectionBackColor1;

        public int SelectionStart2;
        public int SelectionLength2;
        public System.Drawing.Color SelectionColor2;
        public System.Drawing.Color SelectionBackColor2;

    }
}
