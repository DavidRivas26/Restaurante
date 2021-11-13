using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ejercicio_9.Cbx;
using Logica;

namespace Ejercicio_9
{
    public partial class FrmOrdenAgregar : Form
    {
        private CRUD crud;
        public int? indice;

        public FrmOrdenAgregar()
        {
            InitializeComponent();
            crud = new CRUD();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Validacion();

        }

        private void FrmOrdenAgregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmOrden.Singleton.Show();
        }

        private void FrmOrdenAgregar_Load(object sender, EventArgs e)
        {

            CargarCbxBebida();
            CargarCbxEntrada();
            CargarCbxPlatos();
            CargarCbxPostre();

            if(indice != null)
            {
                Orden orden = crud.ObtenerEstudiante(indice.Value);
                txtNombre.Text = orden.Nombre;
                cbxEntrada.Text = orden.Entrada;
                cbxBebida.Text = orden.Bebida;
                cbxPlatoFuerte.Text = orden.Plato_Fuerte;
                cbxPostre.Text = orden.Postre;

            }

        }

        private void Agregar()
        {

            Orden orden = new Orden()
            {

                Nombre = txtNombre.Text,
                Entrada = cbxEntrada.Text,
                Plato_Fuerte = cbxPlatoFuerte.Text,
                Postre = cbxPostre.Text,
                Bebida = cbxBebida.Text

            };

            crud.Agregar(orden);
            MessageBox.Show("Se ha agregado correctamente", "Exito");
            this.Close();

        }

        private void Editar()
        {

            Orden orden = new Orden()
            {

                Nombre = txtNombre.Text,
                Entrada = cbxEntrada.Text,
                Plato_Fuerte = cbxPlatoFuerte.Text,
                Postre = cbxPostre.Text,
                Bebida = cbxBebida.Text

            };

            if(indice != null)
            {
                crud.Editar(orden, indice.Value);
                MessageBox.Show("Se ha editado correctamente", "Exito");
            }

            this.Close();

        }

        public void CargarCbxEntrada()
        {

            CbxEntradas OpcionDefecto = new CbxEntradas
            {
                Texto = "Seleccione una opcion",
                Valor = null
            };

            CbxEntradas Entrada1 = new CbxEntradas
            {
                Texto = "Palitos de pan",
                Valor = 1
            };

            CbxEntradas Entrada2 = new CbxEntradas
            {
                Texto = "Palitos de platanos",
                Valor = 2
            };

            CbxEntradas Entrada3 = new CbxEntradas
            {
                Texto = "Ensalada Cesar",
                Valor = 3
            };

            CbxEntradas Entrada4 = new CbxEntradas
            {
                Texto = "Pan Baguette",
                Valor = 4
            };

            CbxEntradas Entrada5 = new CbxEntradas
            {
                Texto = "Pan de ajo",
                Valor = 5
            };

            cbxEntrada.Items.Add(OpcionDefecto);
            cbxEntrada.Items.Add(Entrada1);
            cbxEntrada.Items.Add(Entrada2);
            cbxEntrada.Items.Add(Entrada3);
            cbxEntrada.Items.Add(Entrada4);
            cbxEntrada.Items.Add(Entrada5);
            cbxEntrada.SelectedItem = OpcionDefecto;

        }

        public void CargarCbxPlatos()
        {

            CbxPlatos OpcionDefecto = new CbxPlatos
            {
                Texto = "Seleccione una opcion",
                Valor = null
            };

            CbxPlatos Plato1 = new CbxPlatos
            {
                Texto = "Arroz",
                Valor = 1
            };

            CbxPlatos Plato2 = new CbxPlatos
            {
                Texto = "Pasta",
                Valor = 2
            };

            CbxPlatos Plato3 = new CbxPlatos
            {
                Texto = "Lasagna",
                Valor = 3
            };

            CbxPlatos Plato4 = new CbxPlatos
            {
                Texto = "Pizza",
                Valor = 4
            };

            CbxPlatos Plato5 = new CbxPlatos
            {
                Texto = "Paella",
                Valor = 5
            };

            CbxPlatos Plato6 = new CbxPlatos
            {
                Texto = "Calzone",
                Valor = 6
            };

            CbxPlatos Plato7 = new CbxPlatos
            {
                Texto = "Mangu",
                Valor = 7
            };

            CbxPlatos Plato8 = new CbxPlatos
            {
                Texto = "Hamburguesa",
                Valor = 8
            };

            CbxPlatos Plato9 = new CbxPlatos
            {
                Texto = "Chow-Fan",
                Valor = 9
            };

            CbxPlatos Plato10 = new CbxPlatos
            {
                Texto = "Low-Mein",
                Valor = 10
            };

            cbxPlatoFuerte.Items.Add(OpcionDefecto);
            cbxPlatoFuerte.Items.Add(Plato1);
            cbxPlatoFuerte.Items.Add(Plato2);
            cbxPlatoFuerte.Items.Add(Plato3);
            cbxPlatoFuerte.Items.Add(Plato4);
            cbxPlatoFuerte.Items.Add(Plato5);
            cbxPlatoFuerte.Items.Add(Plato6);
            cbxPlatoFuerte.Items.Add(Plato7);
            cbxPlatoFuerte.Items.Add(Plato8);
            cbxPlatoFuerte.Items.Add(Plato9);
            cbxPlatoFuerte.Items.Add(Plato10);
            cbxPlatoFuerte.SelectedItem = OpcionDefecto;

        }

        public void CargarCbxPostre()
        {

            CbxPostres OpcionDefecto = new CbxPostres
            {
                Texto = "Seleccione una opcion",
                Valor = null
            };

            CbxPostres Postre1 = new CbxPostres
            {
                Texto = "Helado",
                Valor = 1
            };

            CbxPostres Postre2 = new CbxPostres
            {
                Texto = "Brownie",
                Valor = 2
            };

            CbxPostres Postre3 = new CbxPostres
            {
                Texto = "Bizcocho",
                Valor = 3
            };

            CbxPostres Postre4 = new CbxPostres
            {
                Texto = "Tresleche",
                Valor = 4
            };

            CbxPostres Postre5 = new CbxPostres
            {
                Texto = "Majarete",
                Valor = 5
            };

            CbxPostres Postre6 = new CbxPostres
            {
                Texto = "Cheseecake",
                Valor = 6
            };

            CbxPostres Postre7 = new CbxPostres
            {
                Texto = "Arroz con leche",
                Valor = 7
            };

            CbxPostres Postre8 = new CbxPostres
            {
                Texto = "Habichuelas con dulce",
                Valor = 8
            };

            CbxPostres Postre9 = new CbxPostres
            {
                Texto = "Dulce de coco",
                Valor = 9
            };

            CbxPostres Postre10 = new CbxPostres
            {
                Texto = "Dulce de leche",
                Valor = 10
            };

            cbxPostre.Items.Add(OpcionDefecto);
            cbxPostre.Items.Add(Postre1);
            cbxPostre.Items.Add(Postre2);
            cbxPostre.Items.Add(Postre3);
            cbxPostre.Items.Add(Postre4);
            cbxPostre.Items.Add(Postre5);
            cbxPostre.Items.Add(Postre6);
            cbxPostre.Items.Add(Postre7);
            cbxPostre.Items.Add(Postre8);
            cbxPostre.Items.Add(Postre9);
            cbxPostre.Items.Add(Postre10);
            cbxPostre.SelectedItem = OpcionDefecto;

        }

        public void CargarCbxBebida()
        {

            CbxBebidas OpcionDefecto = new CbxBebidas
            {
                Texto = "Seleccione una opcion",
                Valor = null
            };

            CbxBebidas Bebida1 = new CbxBebidas
            {
                Texto = "Refresco",
                Valor = 1
            };

            CbxBebidas Bebida2 = new CbxBebidas
            {
                Texto = "Cerveza",
                Valor = 2
            };

            CbxBebidas Bebida3 = new CbxBebidas
            {
                Texto = "Agua",
                Valor = 3
            };

            CbxBebidas Bebida4 = new CbxBebidas
            {
                Texto = "Piña colada",
                Valor = 4
            };

            CbxBebidas Bebida5 = new CbxBebidas
            {
                Texto = "Jugo",
                Valor = 5
            };

            cbxBebida.Items.Add(OpcionDefecto);
            cbxBebida.Items.Add(Bebida1);
            cbxBebida.Items.Add(Bebida2);
            cbxBebida.Items.Add(Bebida3);
            cbxBebida.Items.Add(Bebida4);
            cbxBebida.Items.Add(Bebida5);
            cbxBebida.SelectedItem = OpcionDefecto;

        }

        public void Validacion()
        {


            CbxEntradas EntradasSeleccionada = cbxEntrada.SelectedItem as CbxEntradas;
            CbxPlatos PlatosSeleccionados = cbxPlatoFuerte.SelectedItem as CbxPlatos;
            CbxPostres PostresSeleccionados = cbxPostre.SelectedItem as CbxPostres;
            CbxBebidas BebidasSeleccionadas = cbxBebida.SelectedItem as CbxBebidas;

            if (EntradasSeleccionada.Valor == null || PlatosSeleccionados.Valor == null || PostresSeleccionados.Valor == null || BebidasSeleccionadas.Valor == null || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe llenar todos los campos", "Error");
            }

            else
            {

                if (indice == null)
                {
                    Agregar();
                }
                else
                {
                    Editar();
                }

            }

        }
    }
}
