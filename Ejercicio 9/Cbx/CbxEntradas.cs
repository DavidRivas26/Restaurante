using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_9.Cbx
{
    public class CbxEntradas
    {

        public string Texto { get; set; }
        public object Valor { get; set; }

        public override string ToString()
        {
            return Texto;
        }

    }
}
