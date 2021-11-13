using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ejercicio_9.Cbx;

namespace Ejercicio_9
{
    public sealed partial class FrmPersona : Form
    {
        public static FrmPersona Singleton { get; } = new FrmPersona();

        private FrmPersona()
        {
            InitializeComponent();
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            CargarCbxPersonas();
        }

        private void cbxMesa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Validacion();
        }

        public void CargarCbxPersonas()
        {

            CbxPersonas OpcionDefecto = new CbxPersonas
            {
                Texto = "Seleccione una opcion",
                Valor = null
            };

            CbxPersonas Persona1 = new CbxPersonas
            {
                Texto = "1 Persona",
                Valor = 1
            };

            CbxPersonas Persona2 = new CbxPersonas
            {
                Texto = "2 Personas",
                Valor = 2
            };

            CbxPersonas Persona3 = new CbxPersonas
            {
                Texto = "3 Personas",
                Valor = 3
            };

            CbxPersonas Persona4 = new CbxPersonas
            {
                Texto = "4 Personas",
                Valor = 4
            };

            cbxPersona.Items.Add(OpcionDefecto);
            cbxPersona.Items.Add(Persona1);
            cbxPersona.Items.Add(Persona2);
            cbxPersona.Items.Add(Persona3);
            cbxPersona.Items.Add(Persona4);
            cbxPersona.SelectedItem = OpcionDefecto;

        }

        public void Validacion()
        {


            CbxPersonas PersonaSeleccionada = cbxPersona.SelectedItem as CbxPersonas;

            if (PersonaSeleccionada.Valor == null)
            {
                MessageBox.Show("Debe seleccionar una mesa", "Error");
            }

            else
            {

                FrmOrden.Singleton.Show();
                this.Hide();

            }

        }

    }
}
