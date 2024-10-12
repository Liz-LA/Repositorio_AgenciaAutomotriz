using System;
using System.Windows.Forms;
using Manejador;


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
                this.Hide();

                switch (r[1].ToLower())
                {
                    case "superusuario":
                        FrmMenu m = new FrmMenu();
                        m.Show();
                        break;

                    case "usuario":
                        FrmMenu a = new FrmMenu();
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
