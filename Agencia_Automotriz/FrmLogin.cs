using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Entidades;  
using Manejador;
using static Agencia_Automotriz.FrmMenu;


namespace Agencia_Automotriz
{
    public partial class FrmLogin : Form
    {

        
        ManejadorLogin ml;

        public FrmLogin()
        {


            ml = new ManejadorLogin();
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            string[] r = ml.Validar(txtUser.Text, txtClave.Text);

            if (r[0].Equals("C0rr3ct0"))
            {
                // Crear el objeto Usuario con el nombre y rol obtenidos.
                string nombreUsuario = txtUser.Text;
                string rolUsuario = r[1];

                var usuario = new Entidades.UsuarioPantalla.Usuario(nombreUsuario, rolUsuario);

                this.Hide();

                switch (rolUsuario.ToLower())
                {
                    case "superusuario":
                        
                        FrmMenu m = new FrmMenu(usuario);
                        m.Show();
                        break;

                    case "usuario":
                        
                        FrmMenu a = new FrmMenu(usuario);
                        a.Show();
                        break;

                    default:
                        MessageBox.Show("Rol no reconocido.");
                        break;
                }
            }
            else
            {
                
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
