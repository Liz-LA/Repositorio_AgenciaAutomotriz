namespace Agencia_Automotriz
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPermisos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOpHerramientas = new System.Windows.Forms.Button();
            this.btnOpProductos = new System.Windows.Forms.Button();
            this.btnOpUsuarios = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPermisos
            // 
            this.btnPermisos.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermisos.Image = global::Agencia_Automotriz.Properties.Resources.permiso1;
            this.btnPermisos.Location = new System.Drawing.Point(1199, 279);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(144, 118);
            this.btnPermisos.TabIndex = 3;
            this.btnPermisos.Text = "Permisos";
            this.btnPermisos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPermisos.UseVisualStyleBackColor = true;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Agencia_Automotriz.Properties.Resources.boton;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(1305, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 62);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOpHerramientas
            // 
            this.btnOpHerramientas.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpHerramientas.Image = global::Agencia_Automotriz.Properties.Resources.caja_de_herramientas1;
            this.btnOpHerramientas.Location = new System.Drawing.Point(852, 241);
            this.btnOpHerramientas.Name = "btnOpHerramientas";
            this.btnOpHerramientas.Size = new System.Drawing.Size(297, 197);
            this.btnOpHerramientas.TabIndex = 2;
            this.btnOpHerramientas.Text = "Herramientas";
            this.btnOpHerramientas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpHerramientas.UseVisualStyleBackColor = true;
            this.btnOpHerramientas.Click += new System.EventHandler(this.btnOpHerramientas_Click);
            // 
            // btnOpProductos
            // 
            this.btnOpProductos.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpProductos.Image = global::Agencia_Automotriz.Properties.Resources.agregar_producto1;
            this.btnOpProductos.Location = new System.Drawing.Point(534, 241);
            this.btnOpProductos.Name = "btnOpProductos";
            this.btnOpProductos.Size = new System.Drawing.Size(297, 197);
            this.btnOpProductos.TabIndex = 1;
            this.btnOpProductos.Text = "Productos";
            this.btnOpProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpProductos.UseVisualStyleBackColor = true;
            this.btnOpProductos.Click += new System.EventHandler(this.btnOpProductos_Click);
            // 
            // btnOpUsuarios
            // 
            this.btnOpUsuarios.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpUsuarios.Image = global::Agencia_Automotriz.Properties.Resources.perfil_del_usuario2;
            this.btnOpUsuarios.Location = new System.Drawing.Point(225, 241);
            this.btnOpUsuarios.Name = "btnOpUsuarios";
            this.btnOpUsuarios.Size = new System.Drawing.Size(297, 197);
            this.btnOpUsuarios.TabIndex = 0;
            this.btnOpUsuarios.Text = "Usuarios";
            this.btnOpUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpUsuarios.UseVisualStyleBackColor = true;
            this.btnOpUsuarios.Click += new System.EventHandler(this.btnOpUsuarios_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(58, 45);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(81, 29);
            this.lblBienvenida.TabIndex = 4;
            this.lblBienvenida.Text = "label1";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1395, 652);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnPermisos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOpHerramientas);
            this.Controls.Add(this.btnOpProductos);
            this.Controls.Add(this.btnOpUsuarios);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpUsuarios;
        private System.Windows.Forms.Button btnOpProductos;
        private System.Windows.Forms.Button btnOpHerramientas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Label lblBienvenida;
    }
}