namespace Agencia_Automotriz
{
    partial class FrmPermisos
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
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuarioSeleccionado = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEliminacion = new System.Windows.Forms.CheckBox();
            this.chkActualizacion = new System.Windows.Forms.CheckBox();
            this.chkEscritura = new System.Windows.Forms.CheckBox();
            this.chkLectura = new System.Windows.Forms.CheckBox();
            this.chkHerramientas = new System.Windows.Forms.CheckBox();
            this.chkProductos = new System.Windows.Forms.CheckBox();
            this.chkUsuarios = new System.Windows.Forms.CheckBox();
            this.btnGuardarPermisos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgtvPermisos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.AllowUserToAddRows = false;
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(96, 296);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.RowHeadersWidth = 62;
            this.dtgvUsuarios.Size = new System.Drawing.Size(528, 304);
            this.dtgvUsuarios.TabIndex = 1;
            this.dtgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuarios";
            // 
            // btnUsuarioSeleccionado
            // 
            this.btnUsuarioSeleccionado.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioSeleccionado.Location = new System.Drawing.Point(205, 676);
            this.btnUsuarioSeleccionado.Name = "btnUsuarioSeleccionado";
            this.btnUsuarioSeleccionado.Size = new System.Drawing.Size(277, 43);
            this.btnUsuarioSeleccionado.TabIndex = 7;
            this.btnUsuarioSeleccionado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(251, 735);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Usuario Seleccionado";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(179)))), ((int)(((byte)(178)))));
            this.groupBox1.Controls.Add(this.chkEliminacion);
            this.groupBox1.Controls.Add(this.chkActualizacion);
            this.groupBox1.Controls.Add(this.chkEscritura);
            this.groupBox1.Controls.Add(this.chkLectura);
            this.groupBox1.Controls.Add(this.chkHerramientas);
            this.groupBox1.Controls.Add(this.chkProductos);
            this.groupBox1.Controls.Add(this.chkUsuarios);
            this.groupBox1.Controls.Add(this.btnGuardarPermisos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgtvPermisos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(682, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 810);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // chkEliminacion
            // 
            this.chkEliminacion.AutoSize = true;
            this.chkEliminacion.Location = new System.Drawing.Point(437, 575);
            this.chkEliminacion.Name = "chkEliminacion";
            this.chkEliminacion.Size = new System.Drawing.Size(115, 24);
            this.chkEliminacion.TabIndex = 29;
            this.chkEliminacion.Text = "Eliminacion";
            this.chkEliminacion.UseVisualStyleBackColor = true;
            // 
            // chkActualizacion
            // 
            this.chkActualizacion.AutoSize = true;
            this.chkActualizacion.Location = new System.Drawing.Point(604, 575);
            this.chkActualizacion.Name = "chkActualizacion";
            this.chkActualizacion.Size = new System.Drawing.Size(129, 24);
            this.chkActualizacion.TabIndex = 28;
            this.chkActualizacion.Text = "Actualizacion";
            this.chkActualizacion.UseVisualStyleBackColor = true;
            // 
            // chkEscritura
            // 
            this.chkEscritura.AutoSize = true;
            this.chkEscritura.Location = new System.Drawing.Point(604, 531);
            this.chkEscritura.Name = "chkEscritura";
            this.chkEscritura.Size = new System.Drawing.Size(98, 24);
            this.chkEscritura.TabIndex = 27;
            this.chkEscritura.Text = "Escritura";
            this.chkEscritura.UseVisualStyleBackColor = true;
            // 
            // chkLectura
            // 
            this.chkLectura.AutoSize = true;
            this.chkLectura.Location = new System.Drawing.Point(437, 531);
            this.chkLectura.Name = "chkLectura";
            this.chkLectura.Size = new System.Drawing.Size(89, 24);
            this.chkLectura.TabIndex = 26;
            this.chkLectura.Text = "Lectura";
            this.chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkHerramientas
            // 
            this.chkHerramientas.AutoSize = true;
            this.chkHerramientas.Location = new System.Drawing.Point(125, 602);
            this.chkHerramientas.Name = "chkHerramientas";
            this.chkHerramientas.Size = new System.Drawing.Size(131, 24);
            this.chkHerramientas.TabIndex = 25;
            this.chkHerramientas.Text = "Herramientas";
            this.chkHerramientas.UseVisualStyleBackColor = true;
            // 
            // chkProductos
            // 
            this.chkProductos.AutoSize = true;
            this.chkProductos.Location = new System.Drawing.Point(125, 556);
            this.chkProductos.Name = "chkProductos";
            this.chkProductos.Size = new System.Drawing.Size(107, 24);
            this.chkProductos.TabIndex = 24;
            this.chkProductos.Text = "Productos";
            this.chkProductos.UseVisualStyleBackColor = true;
            // 
            // chkUsuarios
            // 
            this.chkUsuarios.AutoSize = true;
            this.chkUsuarios.Location = new System.Drawing.Point(125, 512);
            this.chkUsuarios.Name = "chkUsuarios";
            this.chkUsuarios.Size = new System.Drawing.Size(98, 24);
            this.chkUsuarios.TabIndex = 23;
            this.chkUsuarios.Text = "Usuarios";
            this.chkUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnGuardarPermisos
            // 
            this.btnGuardarPermisos.Location = new System.Drawing.Point(330, 694);
            this.btnGuardarPermisos.Name = "btnGuardarPermisos";
            this.btnGuardarPermisos.Size = new System.Drawing.Size(159, 49);
            this.btnGuardarPermisos.TabIndex = 22;
            this.btnGuardarPermisos.Text = "Guardar Permisos";
            this.btnGuardarPermisos.UseVisualStyleBackColor = true;
            this.btnGuardarPermisos.Click += new System.EventHandler(this.btnGuardarPermisos_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 39);
            this.label4.TabIndex = 21;
            this.label4.Text = "Permisos";
            // 
            // dgtvPermisos
            // 
            this.dgtvPermisos.AllowUserToAddRows = false;
            this.dgtvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvPermisos.Location = new System.Drawing.Point(49, 98);
            this.dgtvPermisos.Name = "dgtvPermisos";
            this.dgtvPermisos.RowHeadersWidth = 62;
            this.dgtvPermisos.Size = new System.Drawing.Size(740, 304);
            this.dgtvPermisos.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Permisos modificaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Permisos de formularios";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Agencia_Automotriz.Properties.Resources.boton;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(1505, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(78, 62);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(145)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(1595, 994);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUsuarioSeleccionado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPermisos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsuarioSeleccionado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkEliminacion;
        private System.Windows.Forms.CheckBox chkActualizacion;
        private System.Windows.Forms.CheckBox chkEscritura;
        private System.Windows.Forms.CheckBox chkLectura;
        private System.Windows.Forms.CheckBox chkHerramientas;
        private System.Windows.Forms.CheckBox chkProductos;
        private System.Windows.Forms.CheckBox chkUsuarios;
        private System.Windows.Forms.Button btnGuardarPermisos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgtvPermisos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}