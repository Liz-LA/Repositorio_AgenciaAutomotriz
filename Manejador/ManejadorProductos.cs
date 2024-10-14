using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorProductos
    {
        Funciones f = new Funciones();

        public void Guardar(TextBox Codigo_Barra, TextBox Nombre, TextBox Descripcion,  TextBox Marca )
        {

            string query = $"CALL p_insertar_producto({Codigo_Barra.Text}, '{Nombre.Text}', '{Descripcion.Text}', '{Marca.Text}')";
            MessageBox.Show(f.Guardar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int Codigo_Barras, string nombreUsuario)
        {
            DialogResult rs = MessageBox.Show($"¿Estás seguro de borrar el producto '{nombreUsuario}'?", "!Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"CALL p_eliminar_producto({Codigo_Barras})");
                MessageBox.Show("Registro Eliminado", "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(TextBox Codigo_Barra, TextBox Nombre, TextBox Descripcion, TextBox Marca, int Codigo_Barras)
        {
            try
            {
                // Generar la consulta SQL usando los valores correspondientes
                string query = $"CALL p_actualizar_producto({Codigo_Barras}, '{Nombre.Text}', '{Descripcion.Text}', '{Marca.Text}')";

                // Asumimos que f.Modificar ejecuta la consulta y devuelve un mensaje
                MessageBox.Show(f.Modificar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el producto: {ex.Message}", "!Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            tabla.DataSource = f.Mostrar($"select * from Productos where nombre like '%{filtro}%'",
                "Productos").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

    }
}
