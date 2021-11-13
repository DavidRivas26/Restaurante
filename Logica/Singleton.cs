using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public sealed class Singleton
    {

        public List<Orden> ordenes { get; set; } = new List<Orden>();

        public static Singleton singleton { get; } = new Singleton(); 

        private Singleton()
        {

        }

    }
}
