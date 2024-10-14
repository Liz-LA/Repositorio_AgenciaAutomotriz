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
    public partial class FrmAgregarHerramienta : Form
    {
        ManejadorHerramientas mh;
        int fila = 0, columna = 0;
        public static string nombre = "", descripcion = "", marca = "", medida = "";


        public void ConfigurarBotones(bool permisoAgregar, bool permisoEditar, bool permisoEliminar)
        {
            btnAgregar.Enabled = permisoAgregar;
            btnModificar.Enabled = permisoEditar;
            btnEliminar.Enabled = permisoEliminar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgvHerramienta.Visible = false;
            codigoherramienta = 0; nombre = ""; medida = ""; descripcion = ""; marca = "";
            FrmHerramientas h = new FrmHerramientas();
            h.ShowDialog();
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            codigoherramienta = int.Parse(dtgvHerramienta.Rows[fila].Cells[0].Value.ToString());
            mh.Borrar(codigoherramienta, dtgvHerramienta.Rows[fila].Cells[1].Value.ToString());
            dtgvHerramienta.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dtgvHerramienta.Visible = false;
            codigoherramienta = int.Parse(dtgvHerramienta.Rows[fila].Cells[0].Value.ToString());
            nombre = dtgvHerramienta.Rows[fila].Cells[1].Value.ToString();
            medida = dtgvHerramienta.Rows[fila].Cells[2].Value.ToString();
            descripcion = dtgvHerramienta.Rows[fila].Cells[2].Value.ToString();
            marca = dtgvHerramienta.Rows[fila].Cells[3].Value.ToString();



            FrmHerramientas h = new FrmHerramientas();
            h.ShowDialog();
            dtgvHerramienta.Visible = false;
        }

        private void dtgvHerramienta_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dtgvHerramienta.Visible = true;
            mh.Mostrar(dtgvHerramienta, txtNombre.Text);
        }

        public static int codigoherramienta = 0;
        public FrmAgregarHerramienta()
        {
            mh = new ManejadorHerramientas();
            InitializeComponent();
        }
    }
}
