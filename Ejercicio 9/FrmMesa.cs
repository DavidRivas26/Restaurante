using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_9.Cbx;

namespace Ejercicio_9
{
    public sealed partial class FrmMesa : Form
    {
        public static FrmMesa Singleton { get; } = new FrmMesa();
        private FrmMesa()
        {
            InitializeComponent();
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            CargarCbxMesas();
        }

        private void cbxMesa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Validacion();
        }

        public void CargarCbxMesas()
        {

            CbxMesas OpcionDefecto = new CbxMesas
            {
                Texto = "Seleccione una opcion",
                Valor = null
            };

            CbxMesas Mesa4 = new CbxMesas
            {
                Texto = "Mesa 4",
                Valor = 1
            };

            CbxMesas Mesa5 = new CbxMesas
            {
                Texto = "Mesa 5",
                Valor = 2
            };

            CbxMesas Mesa6 = new CbxMesas
            {
                Texto = "Mesa 6",
                Valor = 3
            };

            CbxMesas Mesa7 = new CbxMesas
            {
                Texto = "Mesa 7",
                Valor = 4
            };

            CbxMesas Mesa8 = new CbxMesas
            {
                Texto = "Mesa 8",
                Valor = 5
            };

            cbxMesa.Items.Add(OpcionDefecto);
            cbxMesa.Items.Add(Mesa4);
            cbxMesa.Items.Add(Mesa5);
            cbxMesa.Items.Add(Mesa6);
            cbxMesa.Items.Add(Mesa7);
            cbxMesa.Items.Add(Mesa8);
            cbxMesa.SelectedItem = OpcionDefecto;

        }

        public void Validacion()
        {


                CbxMesas MesaSeleccionada = cbxMesa.SelectedItem as CbxMesas;

                if (MesaSeleccionada.Valor == null)
                {
                    MessageBox.Show("Debe seleccionar una mesa", "Error");
                }

                else
                {

                FrmPersona.Singleton.Show();
                this.Hide();

                }

        }

    }
}