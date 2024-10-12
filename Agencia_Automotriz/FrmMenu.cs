using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_Automotriz
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void OpUsuarios_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario u = new FrmAgregarUsuario();
            u.MdiParent = this;
            u.Show();
        }

        private void OpProductos_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto p = new FrmAgregarProducto();
            p.MdiParent = this;
            p.Show();
        }

        private void Opherramientas_Click(object sender, EventArgs e)
        {
            FrmAgregarHerramienta h = new FrmAgregarHerramienta();
            h.MdiParent = this;
            h.Show();
        }

        private void OpSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
