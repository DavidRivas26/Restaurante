using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Logica;
using Ejercicio_9.Cbx;

namespace Ejercicio_9
{
    public sealed partial class FrmOrden : Form
    {
        public static FrmOrden Singleton { get; } = new FrmOrden();
        private CRUD crud;
        private FrmOrden()
        {
            InitializeComponent();
            crud = new CRUD();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            FrmOrdenAgregar agregar = new FrmOrdenAgregar();
            agregar.Show();
            this.Hide();
        }

        private void CargarOrdenes()
        {

            List<Orden> ordenes = crud.ObtenerTodos();

            lbOrden.BeginUpdate();

            lbOrden.Items.Clear();

            foreach(Orden orden in ordenes)
            {
                lbOrden.Items.Add(orden.Imprimir());
            }

            lbOrden.EndUpdate();

        }

        private void Eliminar()
        {
            int indice = lbOrden.SelectedIndex;

            if(indice < 0)
            {
                MessageBox.Show("Debe seleccionar una orden", "Error");
            }
            else
            {

                DialogResult respuesta = MessageBox.Show("Está seguro que desea eliminar esta orden", "Advertencia", MessageBoxButtons.YesNo);

                if(respuesta == DialogResult.Yes)
                {
                    crud.Eliminar(indice);
                    CargarOrdenes();
                }

            }
        }

        private void Editar()
        {
            int indice = lbOrden.SelectedIndex;

            if (indice < 0)
            {
                MessageBox.Show("Debe seleccionar una orden", "Error");
            }
            else
            {

                FrmOrdenAgregar editar = new FrmOrdenAgregar();
                editar.indice = indice;
                editar.Show();
                this.Hide();

            }
            
        }

        private void FrmOrden_VisibleChanged(object sender, EventArgs e)
        {
            CargarOrdenes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
    }
}