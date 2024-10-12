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
            switch (columna)
            {
                case 4:
                    {
                        codigobarra = int.Parse(dtgvProducto.Rows[fila].Cells[0].Value.ToString());
                        mp.Borrar(codigobarra, dtgvProducto.Rows[fila].Cells[1].Value.ToString());
                        dtgvProducto.Visible = false;
                    }
                    break;
                case 5:
                    {

                        codigobarra = int.Parse(dtgvProducto.Rows[fila].Cells[0].Value.ToString());
                        nombre = dtgvProducto.Rows[fila].Cells[1].Value.ToString();
                        descripcion = dtgvProducto.Rows[fila].Cells[2].Value.ToString();
                        marca = dtgvProducto.Rows[fila].Cells[3].Value.ToString();
                       


                        FrmProductos ap = new FrmProductos();
                        ap.ShowDialog();
                        dtgvProducto.Visible = false;

                    }
                    break;
            }
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
