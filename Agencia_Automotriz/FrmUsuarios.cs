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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuarios mu;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuarios();
            if (FrmAgregarUsuario.idUsuarios > 0)
            {
                txtNombre.Text = FrmAgregarUsuario.nombre;
                txtApellidoP.Text = FrmAgregarUsuario.apellidop;
                txtApellidoM.Text = FrmAgregarUsuario.apellidom;
                dtpFecha.Text = FrmAgregarUsuario.fechanacimiento;
                txtRfc.Text = FrmAgregarUsuario.rfc;
                txtUser.Text = FrmAgregarUsuario.nombreusuario;
                txtPass.Text = FrmAgregarUsuario.clave;
                cmbRol.Text = FrmAgregarUsuario.rol;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FrmAgregarUsuario.idUsuarios > 0)
            {

                mu.Modificar(txtNombre, txtApellidoP,txtApellidoM,dtpFecha,txtRfc,txtUser,txtPass,cmbRol, FrmAgregarUsuario.idUsuarios);
            }
            else
            {
                mu.Guardar(txtNombre,txtApellidoP,txtApellidoM,dtpFecha,txtRfc,txtUser,txtPass,cmbRol);
            }
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
