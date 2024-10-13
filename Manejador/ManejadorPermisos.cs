using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorPermisos
    {
        Funciones f = new Funciones();
        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select idUsuario,NombreUsuario,Rol from Usuarios",
                "Usuarios").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();

        }
    }
}
