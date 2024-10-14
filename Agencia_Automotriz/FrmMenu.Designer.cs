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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPermisos
            // 
            this.btnPermisos.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermisos.Image = global::Agencia_Automotriz.Properties.Resources.permiso1;
            this.btnPermisos.Location = new System.Drawing.Point(1182, 265);
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
            this.btnSalir.Location = new System.Drawing.Point(1311, 30);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 62);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOpHerramientas
            // 
            this.btnOpHerramientas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnOpHerramientas.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpHerramientas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpHerramientas.Image = global::Agencia_Automotriz.Properties.Resources.caja_de_herramientas1;
            this.btnOpHerramientas.Location = new System.Drawing.Point(834, 226);
            this.btnOpHerramientas.Name = "btnOpHerramientas";
            this.btnOpHerramientas.Size = new System.Drawing.Size(297, 197);
            this.btnOpHerramientas.TabIndex = 2;
            this.btnOpHerramientas.Text = "Herramientas";
            this.btnOpHerramientas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpHerramientas.UseVisualStyleBackColor = false;
            this.btnOpHerramientas.Click += new System.EventHandler(this.btnOpHerramientas_Click);
            // 
            // btnOpProductos
            // 
            this.btnOpProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnOpProductos.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpProductos.Image = global::Agencia_Automotriz.Properties.Resources.agregar_producto1;
            this.btnOpProductos.Location = new System.Drawing.Point(516, 226);
            this.btnOpProductos.Name = "btnOpProductos";
            this.btnOpProductos.Size = new System.Drawing.Size(297, 197);
            this.btnOpProductos.TabIndex = 1;
            this.btnOpProductos.Text = "Productos";
            this.btnOpProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpProductos.UseVisualStyleBackColor = false;
            this.btnOpProductos.Click += new System.EventHandler(this.btnOpProductos_Click);
            // 
            // btnOpUsuarios
            // 
            this.btnOpUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnOpUsuarios.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnOpUsuarios.Image = global::Agencia_Automotriz.Properties.Resources.perfil_del_usuario2;
            this.btnOpUsuarios.Location = new System.Drawing.Point(207, 226);
            this.btnOpUsuarios.Name = "btnOpUsuarios";
            this.btnOpUsuarios.Size = new System.Drawing.Size(297, 197);
            this.btnOpUsuarios.TabIndex = 0;
            this.btnOpUsuarios.Text = "Usuarios";
            this.btnOpUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpUsuarios.UseVisualStyleBackColor = false;
            this.btnOpUsuarios.Click += new System.EventHandler(this.btnOpUsuarios_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(79, 39);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(296, 40);
            this.lblBienvenida.TabIndex = 4;
            this.lblBienvenida.Text = "label1";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lblBienvenida);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Location = new System.Drawing.Point(0, -18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1395, 99);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Agencia_Automotriz.Properties.Resources.usuario2;
            this.pictureBox2.Location = new System.Drawing.Point(27, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.ClientSize = new System.Drawing.Size(1395, 587);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPermisos);
            this.Controls.Add(this.btnOpHerramientas);
            this.Controls.Add(this.btnOpProductos);
            this.Controls.Add(this.btnOpUsuarios);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpUsuarios;
        private System.Windows.Forms.Button btnOpProductos;
        private System.Windows.Forms.Button btnOpHerramientas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}