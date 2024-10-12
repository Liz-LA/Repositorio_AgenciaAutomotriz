using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace Agencia_Automotriz
{
    public partial class FrmHerramientas : Form
    {
        ManejadorHerramientas mh;
        public FrmHerramientas()
        {
            mh = new ManejadorHerramientas();
            InitializeComponent();
            if (FrmAgregarHerramienta.codigoherramienta > 0)
            {
                txtCodigo.Text = FrmAgregarHerramienta.codigoherramienta.ToString();
                txtNombre.Text = FrmAgregarHerramienta.nombre;
                txtMedida.Text = FrmAgregarHerramienta.medida;
                txtDescripcion.Text = FrmAgregarHerramienta.descripcion;
                txtMarca.Text = FrmAgregarHerramienta.marca;

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (FrmAgregarHerramienta.codigoherramienta > 0)
            {

                mh.Modificar(txtCodigo, txtNombre, txtMedida,txtDescripcion, txtMarca, FrmAgregarHerramienta.codigoherramienta);
            }
            else
            {
                mh.Guardar(txtCodigo, txtNombre, txtMedida,txtDescripcion, txtMarca);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
