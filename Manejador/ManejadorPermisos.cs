using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorPermisos
    {
        Funciones f = new Funciones();
        public void GuardarPermiso(int idUsuario, int idFormulario, bool lectura, bool escritura, bool actualizacion, bool eliminacion)
        {
            // Construimos la consulta SQL llamando al procedure
            string query = $"CALL p_AsignarPermisos({idUsuario}, {idFormulario}, {Convert.ToInt32(lectura)}, {Convert.ToInt32(escritura)}, {Convert.ToInt32(actualizacion)}, {Convert.ToInt32(eliminacion)})";

            // Ejecutamos la consulta y mostramos el mensaje de confirmación
            MessageBox.Show(f.Guardar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool TienePermiso(int idUsuario, int idFormulario, string tipoPermiso)
        {
            try
            {
                // Construimos la consulta para obtener el permiso específico
                string query = $"SELECT {tipoPermiso} FROM Permisos WHERE idUsuario = {idUsuario} AND idFormulario = {idFormulario}";

                // Usamos ObtenerDato para obtener el valor del permiso como string
                string resultado = f.ObtenerDato(query, "Permisos", tipoPermiso);

                // Verificamos si el resultado es válido y lo convertimos a booleano
                return !string.IsNullOrEmpty(resultado) && Convert.ToBoolean(resultado);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }
    }

}
