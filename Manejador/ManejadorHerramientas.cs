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
    public class ManejadorHerramientas
    {
        Funciones f = new Funciones();

        public void Guardar(TextBox Codigo_Herramienta, TextBox Nombre,TextBox Medida, TextBox Descripcion, TextBox Marca)
        {

            string query = $"CALL p_insertar_herramienta('{Codigo_Herramienta.Text}', '{Nombre.Text}', '{Medida.Text}','{Descripcion.Text}', '{Marca.Text}')";
            MessageBox.Show(f.Guardar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int Codigo_Herramientas, string nombreUsuario)
        {
            DialogResult rs = MessageBox.Show($"¿Estás seguro de borrar la herramienta '{nombreUsuario}'?", "!Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"CALL p_eliminar_herramienta({Codigo_Herramientas})");
                MessageBox.Show("Registro Eliminado", "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(TextBox Codigo_Herramienta, TextBox Nombre,TextBox Medida, TextBox Descripcion, TextBox Marca, int  Codigo_Herramientas)
        {
            string query = $"CALL p_actualizar_herramienta({Codigo_Herramientas},  '{Nombre.Text}', '{Medida.Text}','{Descripcion.Text}', '{Marca.Text}')";
            MessageBox.Show(f.Modificar(query), "!Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tabla.DataSource = f.Mostrar($"select * from Herramientas where nombre like '%{filtro}%'",
                "Herramientas").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

    }
}

