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
    public partial class FrmAgregarProducto : Form
    {
        ManejadorProductos mp;
        int fila = 0, columna = 0;
        public static string  nombre = "", descripcion = "", marca = "";
        public static int codigobarra = 0;

        private void dtgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;

        }
        public void ConfigurarBotones(bool permisoAgregar, bool permisoEditar, bool permisoEliminar)
        {
            btnAgregar.Enabled = permisoAgregar;
            btnModificar.Enabled = permisoEditar;
            btnEliminar.Enabled = permisoEliminar;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            codigobarra = int.Parse(dtgvProducto.Rows[fila].Cells[0].Value.ToString());
            mp.Borrar(codigobarra, dtgvProducto.Rows[fila].Cells[1].Value.ToString());
            dtgvProducto.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            dtgvProducto.Visible = false;

            codigobarra = int.Parse(dtgvProducto.Rows[fila].Cells[0].Value.ToString());
            nombre = dtgvProducto.Rows[fila].Cells[1].Value.ToString();
            descripcion = dtgvProducto.Rows[fila].Cells[2].Value.ToString();
            marca = dtgvProducto.Rows[fila].Cells[3].Value.ToString();



            FrmProductos ap = new FrmProductos();
            ap.ShowDialog();
            dtgvProducto.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgvProducto.Visible = false;
            codigobarra = 0; nombre = ""; descripcion = ""; marca = "";
            FrmProductos p = new FrmProductos();
            p.ShowDialog();
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void dtgvProducto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dtgvProducto.Visible = true;
            mp.Mostrar(dtgvProducto, txtNombre.Text);
        }
    

        public FrmAgregarProducto()
        {
            mp = new ManejadorProductos();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            codigobarra = 0; nombre = ""; descripcion = ""; marca = "";
            FrmProductos p = new FrmProductos();
            p.ShowDialog();
            txtNombre.Focus();
        }
    }
}
