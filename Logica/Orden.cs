using System;

namespace Logica
{
    public class Orden
    {

        public string Nombre { get; set; }
        public string Entrada { get; set; }
        public string Plato_Fuerte { get; set; }
        public string Bebida { get; set; }
        public string Postre { get; set; }

        public string Imprimir()
        {
            return "Nombre: " + Nombre + "\tEntrada: " + Entrada + "\tPlato Fuerte: " + Plato_Fuerte + "\tPostre: " + Postre + "\tBebida: " + Bebida;
        }

    }
}
