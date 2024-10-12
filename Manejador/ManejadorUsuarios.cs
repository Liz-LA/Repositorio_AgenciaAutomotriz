using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public  class ManejadorUsuarios
    {
        Funciones f = new Funciones();

        public void Guardar(TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, DateTimePicker FechaNacimiento, TextBox Rfc, TextBox NombreUsuario, TextBox Clave, ComboBox Rol)
        {
            try
            {
                // Formatear la fecha de nacimiento como yyyy-MM-dd para SQL
                string query = $"CALL p_insertar_usuario('{Nombre.Text}', '{ApellidoP.Text}', '{ApellidoM.Text}', '{FechaNacimiento.Value.ToString("yyyy-MM-dd")}', '{Rfc.Text}', '{NombreUsuario.Text}', '{Sha1(Clave.Text)}', '{Rol.Text}')";

                // Asumimos que f.Guardar ejecuta la consulta en la base de datos y devuelve un mensaje
                MessageBox.Show(f.Guardar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el usuario: {ex.Message}", "!Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Borrar(int idUsuario, string nombreUsuario)
        {
            DialogResult rs = MessageBox.Show($"¿Estás seguro de borrar al usuario '{nombreUsuario}'?", "!Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"CALL p_eliminar_usuario({idUsuario})");
                MessageBox.Show("Registro Eliminado", "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, DateTimePicker FechaNacimiento, TextBox Rfc, TextBox NombreUsuario, TextBox Clave, ComboBox Rol, int idUsuario)
        {
            string query = $"CALL p_modificar_usuario({idUsuario}, '{Nombre.Text}', '{ApellidoP.Text}', '{ApellidoM.Text}', '{FechaNacimiento.Value.ToString("yyyy-MM-dd")}', '{Rfc.Text}', '{NombreUsuario.Text}','{Clave.Text}','{Rol.Text}')";
            MessageBox.Show(f.Modificar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static string Sha1(String texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
        DataGridViewButtonColumn Boton(string t, Color co)
        {
            DataGridViewButtonColumn bo = new DataGridViewButtonColumn();
            bo.Text = t;
            bo.UseColumnTextForButtonValue = true;
            bo.FlatStyle = FlatStyle.Popup;
            bo.DefaultCellStyle.BackColor = co;
            bo.DefaultCellStyle.ForeColor = Color.White;
            return bo;
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from Usuarios where nombre like '%{filtro}%'",
                "Usuarios").Tables[0];
            tabla.Columns.Insert(9, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(10, Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

    }
}
