using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace QuickSpark
{
    class Carta : PictureBox
    {
        bool bandera;
        int valor;
        int pos;

        public bool Bandera
        {
            get { return bandera; }
            set { bandera = value; }
        }


        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }



        public int Pos
        {
            get { return pos; }
            set { pos = value; }
        }
    }
}
