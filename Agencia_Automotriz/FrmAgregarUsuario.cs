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
using static Entidades.UsuarioPantalla;

namespace Agencia_Automotriz
{
    public partial class FrmAgregarUsuario : Form
    {
        ManejadorUsuarios mu;
        int fila = 0, columna = 0;
        public static string nombre = "", apellidop = "", apellidom = "", rfc = "", clave = "", nombreusuario = "", rol = "", fechanacimiento = "";

        private void btnSalir_Click(object sender, EventArgs e)
        {
            

            Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            idUsuarios = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
            nombre = dtgvUsuarios.Rows[fila].Cells[1].Value.ToString();
            apellidop = dtgvUsuarios.Rows[fila].Cells[2].Value.ToString();
            apellidom = dtgvUsuarios.Rows[fila].Cells[3].Value.ToString();
            fechanacimiento = dtgvUsuarios.Rows[fila].Cells[4].Value.ToString();
            rfc = dtgvUsuarios.Rows[fila].Cells[5].Value.ToString();
            nombreusuario = dtgvUsuarios.Rows[fila].Cells[6].Value.ToString();
            
            rol = dtgvUsuarios.Rows[fila].Cells[7].Value.ToString();




            FrmUsuarios au = new FrmUsuarios();
            au.ShowDialog();
            dtgvUsuarios.Visible = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            idUsuarios = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
            mu.Borrar(idUsuarios, dtgvUsuarios.Rows[fila].Cells[1].Value.ToString());
            dtgvUsuarios.Visible = false;
        }

        public static int idUsuarios = 0;
        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
           /* switch (columna)
            {
                case 9:
                    {
                        idUsuarios = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        mu.Borrar(idUsuarios, dtgvUsuarios.Rows[fila].Cells[1].Value.ToString());
                        dtgvUsuarios.Visible = false;
                    }
                    break;
                case 10:
                    {

                        idUsuarios = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        nombre = dtgvUsuarios.Rows[fila].Cells[1].Value.ToString();
                        apellidop = dtgvUsuarios.Rows[fila].Cells[2].Value.ToString();
                        apellidom = dtgvUsuarios.Rows[fila].Cells[3].Value.ToString();
                        fechanacimiento = dtgvUsuarios.Rows[fila].Cells[4].Value.ToString();
                        rfc = dtgvUsuarios.Rows[fila].Cells[5].Value.ToString();
                        nombreusuario = dtgvUsuarios.Rows[fila].Cells[6].Value.ToString();
                        clave = dtgvUsuarios.Rows[fila].Cells[7].Value.ToString();
                        rol = dtgvUsuarios.Rows[fila].Cells[8].Value.ToString();
                        


                        FrmUsuarios au = new FrmUsuarios();
                        au.ShowDialog();
                        dtgvUsuarios.Visible = false;

                    }
                    break;
            } */
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dtgvUsuarios.Visible = true;
            mu.Mostrar(dtgvUsuarios, txtNombre.Text);
        }

        
        public FrmAgregarUsuario()
        {
            mu = new ManejadorUsuarios();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            idUsuarios = 0; nombre= ""; apellidop = ""; apellidom = ""; rfc = "";  clave = ""; nombreusuario = "";  rol = ""; fechanacimiento = "";
            FrmUsuarios au = new FrmUsuarios();
            au.ShowDialog();
            txtNombre.Focus();
        }
    }
}
