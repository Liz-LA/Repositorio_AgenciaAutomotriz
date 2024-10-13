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
    

    public partial class FrmPermisos : Form
    {
        int fila = 0, columna = 0;
        public static string nombre = "", apellidop = "", apellidom = "", rfc = "", clave = "", nombreusuario = "", rol = "", fechanacimiento = "";
        public static int idUsuarios = 0;
        ManejadorPermisos mp;
        public FrmPermisos()
        {
            mp = new ManejadorPermisos();
            InitializeComponent();
            mp.Mostrar(dtgvUsuarios);
        }

        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;

        }
    }
}
