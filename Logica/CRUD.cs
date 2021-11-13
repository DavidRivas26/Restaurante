using System;
using System.Collections.Generic;
using System.Text;

namespace Logica
{
    public class CRUD
    {

        public void Agregar(Orden orden)
        {
            Singleton.singleton.ordenes.Add(orden);
        }

        public void Editar(Orden orden, int indice)
        {
            Singleton.singleton.ordenes[indice] = orden;
        }

        public void Eliminar(int indice)
        {
            Singleton.singleton.ordenes.RemoveAt(indice);
        }

        public Orden ObtenerEstudiante(int indice)
        {
            return Singleton.singleton.ordenes[indice];
        }

        public List<Orden> ObtenerTodos()
        {
            return Singleton.singleton.ordenes;
        }

    }
}
