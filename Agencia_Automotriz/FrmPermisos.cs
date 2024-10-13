using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;
using Manejador;
using static Entidades.UsuarioPantalla;

namespace Agencia_Automotriz
{
    

    public partial class FrmPermisos : Form
    {
        private string usuarioSeleccionado;


        int fila = 0, columna = 0;
        public static string nombre = "", apellidop = "", apellidom = "", rfc = "", clave = "", nombreusuario = "", rol = "", fechanacimiento = "";
        public static int idUsuarios = 0;


        private void btnGuardarPermisos_Click(object sender, EventArgs e)
        {
            // Verificar que hay un usuario seleccionado en el botón
            if (string.IsNullOrEmpty(btnUsuarioSeleccionado.Text))
            {
                MessageBox.Show("Por favor, selecciona un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = ObtenerIdUsuario(btnUsuarioSeleccionado.Text);

            if (idUsuario == -1)
            {
                MessageBox.Show("No se encontró el usuario seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Capturar los valores de permisos desde los CheckBoxes
            int lectura = chkLectura.Checked ? 1 : 0;
            int escritura = chkEscritura.Checked ? 1 : 0;
            int actualizacion = chkActualizacion.Checked ? 1 : 0;
            int eliminacion = chkEliminacion.Checked ? 1 : 0;

            if (chkUsuarios.Checked)
            {
                mp.GuardarOActualizarPermisos(idUsuario, 1, lectura, escritura, actualizacion, eliminacion); // idFormulario = 1 para "Usuarios"
            }
            if (chkProductos.Checked)
            {
                mp.GuardarOActualizarPermisos(idUsuario, 2, lectura, escritura, actualizacion, eliminacion); // idFormulario = 2 para "Productos"
            }
            if (chkHerramientas.Checked)
            {
                mp.GuardarOActualizarPermisos(idUsuario, 3, lectura, escritura, actualizacion, eliminacion); // idFormulario = 3 para "Herramientas"
            }

            MessageBox.Show("Permisos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int ObtenerIdUsuario(string nombreUsuario)
        {
            foreach (DataGridViewRow row in dtgvUsuarios.Rows)
            {
                if (row.Cells["NombreUsuario"].Value != null &&
                    row.Cells["NombreUsuario"].Value.ToString() == nombreUsuario)
                {
                    return Convert.ToInt32(row.Cells["idUsuario"].Value);
                }
            }
            return -1; // Si no se encontró el usuario
        }

        private void dgtvPermisos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Capturar los valores de permisos desde la fila seleccionada
                bool lectura = Convert.ToBoolean(dgtvPermisos.Rows[e.RowIndex].Cells["Lectura"].Value);
                bool escritura = Convert.ToBoolean(dgtvPermisos.Rows[e.RowIndex].Cells["Escritura"].Value);
                bool actualizacion = Convert.ToBoolean(dgtvPermisos.Rows[e.RowIndex].Cells["Actualizacion"].Value);
                bool eliminacion = Convert.ToBoolean(dgtvPermisos.Rows[e.RowIndex].Cells["Eliminacion"].Value);

                // Asignar los valores a los CheckBoxes
                chkLectura.Checked = lectura;
                chkEscritura.Checked = escritura;
                chkActualizacion.Checked = actualizacion;
                chkEliminacion.Checked = eliminacion;
            }

        }

        ManejadorPermisos mp;
        
        public FrmPermisos()
        {
            
            InitializeComponent();
            mp = new ManejadorPermisos();
            mp.MostrarUsuarios(dtgvUsuarios);
            mp.MostrarPermisos(dgtvPermisos);
            dtgvUsuarios.CellClick += dtgvUsuarios_CellClick;
        }

        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;

            if (e.RowIndex >= 0)
            {
                // Capturar el nombre del usuario y asignarlo al botón
                string nombreUsuario = dtgvUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();
                btnUsuarioSeleccionado.Text = nombreUsuario;
            }
        }
    }
}
