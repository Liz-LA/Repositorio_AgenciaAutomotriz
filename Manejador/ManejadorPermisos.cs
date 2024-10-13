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

            string consulta = @"
            SELECT 
            u.NombreUsuario AS Usuario,
            f.NombreFormulario AS Formulario,
            p.Lectura,
            p.Escritura,
            p.Actualizacion,
            p.Eliminacion
            FROM Permisos p
            JOIN Usuarios u ON p.idUsuario = u.idUsuario
            JOIN Formularios f ON p.idFormulario = f.idFormulario";

            tabla.DataSource = f.Mostrar(consulta, "Permisos").Tables[0];

            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        // ----------------------------------------------------------------------------------------------------------


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





        public void ActualizarPermisos(int idUsuario, int idFormulario, int lectura, int escritura, int actualizacion, int eliminacion)
        {
            // Consulta para actualizar los permisos
            string consulta = $@"
            UPDATE Permisos 
            SET Lectura = {lectura}, 
            Escritura = {escritura}, 
            Actualizacion = {actualizacion}, 
            Eliminacion = {eliminacion}
            WHERE idUsuario = {idUsuario} AND idFormulario = {idFormulario};";

            string resultado = f.Modificar(consulta);

            Console.WriteLine($"Resultado de la actualización: {resultado}");
        }


        public void GuardarPermisos(int idUsuario, int idFormulario, int lectura, int escritura, int actualizacion, int eliminacion)
        {
            string consulta = $@"
            INSERT INTO Permisos (idUsuario, idFormulario, Lectura, Escritura, Actualizacion, Eliminacion)
            VALUES ({idUsuario}, {idFormulario}, {lectura}, {escritura}, {actualizacion}, {eliminacion});";

            string resultado = f.Modificar(consulta);

            Console.WriteLine($"Resultado de la inserción: {resultado}");
        }

        private bool VerificarPermisosExistentes(int idUsuario, int idFormulario)
        {
            // Consulta SQL para verificar si ya existen permisos
            string consulta = $@"
            SELECT COUNT(*) 
            FROM Permisos 
            WHERE idUsuario = {idUsuario} AND idFormulario = {idFormulario};";

            string resultado = f.ObtenerDato(consulta, "Permisos", "COUNT(*)");

            // Verificar y convertir el resultado de forma segura
            if (int.TryParse(resultado, out int count))
            {
                return count > 0; // Retorna true si el conteo es mayor que 0
            }
            else
            {
                return false; // Si no se puede convertir, asumir que no existen permisos
            }
        }


    }
}
