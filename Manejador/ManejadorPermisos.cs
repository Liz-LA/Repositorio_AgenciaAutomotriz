using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public void MostrarUsuarios(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select idUsuario,NombreUsuario,Rol from Usuarios",
                "Usuarios").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();

        }

        public void MostrarPermisos(DataGridView tabla)
        {
            tabla.Columns.Clear();

            // Consulta ajustada para mostrar solo los datos necesarios
            string consulta = @"
            SELECT p.idPermiso,u.NombreUsuario, f.NombreFormulario, 
             p.Lectura, p.Escritura, p.Actualizacion, p.Eliminacion
            FROM Permisos p
            JOIN Usuarios u ON p.idUsuario = u.idUsuario
            JOIN Formularios f ON p.idFormulario = f.idFormulario;";

            tabla.DataSource = f.Mostrar(consulta, "Permisos").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }


        public void GuardarOActualizarPermisos(int idUsuario, int idFormulario, int lectura, int escritura, int actualizacion, int eliminacion)
        {
            
            string consulta = $@"
            INSERT INTO Permisos (idUsuario, idFormulario, Lectura, Escritura, Actualizacion, Eliminacion)
            VALUES ({idUsuario}, {idFormulario}, {lectura}, {escritura}, {actualizacion}, {eliminacion})
            ON DUPLICATE KEY UPDATE 
            Lectura = VALUES(Lectura), 
            Escritura = VALUES(Escritura), 
            Actualizacion = VALUES(Actualizacion), 
            Eliminacion = VALUES(Eliminacion);";

            string resultado = f.Modificar(consulta);

            Console.WriteLine($"Resultado: {resultado}");
        }





    }
}
