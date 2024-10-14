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
    public partial class FrmProductos : Form
    {
        ManejadorProductos mp;
        public FrmProductos()
        {
            
            mp = new ManejadorProductos();
            InitializeComponent();
            if (FrmAgregarProducto.codigobarra > 0)
            {
                txtCodigo.Text = FrmAgregarProducto.codigobarra.ToString();
                txtNombre.Text = FrmAgregarProducto.nombre;
                txtDescripcion.Text = FrmAgregarProducto.descripcion;
                txtMarca.Text = FrmAgregarProducto.marca;
                
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (FrmAgregarProducto.codigobarra > 0)
            {

                mp.Modificar(txtCodigo,txtNombre,txtDescripcion,txtMarca ,FrmAgregarProducto.codigobarra);
            }
            else
            {
                mp.Guardar(txtCodigo,txtNombre,txtDescripcion,txtMarca);
            }
            Close();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
