using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using static Agencia_Automotriz.FrmLogin;
using Manejador;


namespace Agencia_Automotriz
{
    

    public partial class FrmMenu : Form
    {
        private Entidades.UsuarioPantalla.Usuario usuario;
        ManejadorPermisos mp;

        private FrmPermisos frmPermisos = new FrmPermisos();  // Instancia de FrmPermisos


        public FrmMenu(Entidades.UsuarioPantalla.Usuario usuarioAutenticado)
        {
            mp = new ManejadorPermisos();
            InitializeComponent();
            usuario = usuarioAutenticado;
            ConfigurarInterfaz();

        }

        private void ConfigurarInterfaz()
        {
            lblBienvenida.Text = $"Bienvenido, {usuario.Nombre}";

            if (usuario.Rol.ToLower() == "superusuario")
            {
                btnPermisos.Visible = true;
            }
            else
            {
                btnPermisos.Visible = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            FrmLogin fl = new FrmLogin();
            fl.Show();
        }


        //--------Botones-------------------------------------------

       
        private void btnOpUsuarios_Click(object sender, EventArgs e)
        {

            if (frmPermisos.VerificarPermisosUsuarioActual(usuario.Nombre, "Usuarios"))
            {
                FrmAgregarUsuario u = new FrmAgregarUsuario();
                u.Show();
            }
            else
            {
                MessageBox.Show("Acceso denegado. No tienes permisos para acceder a Usuarios.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            /*FrmAgregarUsuario u = new FrmAgregarUsuario();
            u.Show(); */

        }


        private void btnOpProductos_Click(object sender, EventArgs e)
        {
            if (frmPermisos.VerificarPermisosUsuarioActual(usuario.Nombre, "Productos"))
            {
                FrmAgregarProducto p = new FrmAgregarProducto();
                p.Show();
            }
            else
            {
                MessageBox.Show("Acceso denegado. No tienes permisos para acceder a Productos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            /*FrmAgregarProducto p = new FrmAgregarProducto();
            p.Show(); */

        }

        private void btnOpHerramientas_Click(object sender, EventArgs e)
        {
            if (frmPermisos.VerificarPermisosUsuarioActual(usuario.Nombre, "Herramientas"))
            {
                FrmAgregarHerramienta h = new FrmAgregarHerramienta();
                h.Show();
            }
            else
            {
                MessageBox.Show("Acceso denegado. No tienes permisos para acceder a Herramientas.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            /* FrmAgregarHerramienta h = new FrmAgregarHerramienta();
             h.Show(); */
        }

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            FrmPermisos p = new FrmPermisos();
            p.Show();
        }


        // ------




    }
}
