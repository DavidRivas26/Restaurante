using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_9.Cbx
{
    public class CbxPostres
    {

        public string Texto { get; set; }
        public object Valor { get; set; }

        public override string ToString()
        {
            return Texto;
        }

    }
}
