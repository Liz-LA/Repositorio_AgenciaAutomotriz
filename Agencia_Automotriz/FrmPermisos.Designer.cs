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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUsuarioSeleccionado = new System.Windows.Forms.Button();
            this.dgtvPermisos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardarPermisos = new System.Windows.Forms.Button();
            this.chkUsuarios = new System.Windows.Forms.CheckBox();
            this.chkProductos = new System.Windows.Forms.CheckBox();
            this.chkHerramientas = new System.Windows.Forms.CheckBox();
            this.chkActualizacion = new System.Windows.Forms.CheckBox();
            this.chkEscritura = new System.Windows.Forms.CheckBox();
            this.chkLectura = new System.Windows.Forms.CheckBox();
            this.chkEliminacion = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvPermisos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.AllowUserToAddRows = false;
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(103, 123);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.RowHeadersWidth = 62;
            this.dtgvUsuarios.Size = new System.Drawing.Size(524, 316);
            this.dtgvUsuarios.TabIndex = 1;
            this.dtgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Permisos de formularios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Permisos modificaciones";
            // 
            // btnUsuarioSeleccionado
            // 
            this.btnUsuarioSeleccionado.Location = new System.Drawing.Point(346, 53);
            this.btnUsuarioSeleccionado.Name = "btnUsuarioSeleccionado";
            this.btnUsuarioSeleccionado.Size = new System.Drawing.Size(270, 32);
            this.btnUsuarioSeleccionado.TabIndex = 7;
            this.btnUsuarioSeleccionado.UseVisualStyleBackColor = true;
            // 
            // dgtvPermisos
            // 
            this.dgtvPermisos.AllowUserToAddRows = false;
            this.dgtvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvPermisos.Location = new System.Drawing.Point(679, 123);
            this.dgtvPermisos.Name = "dgtvPermisos";
            this.dgtvPermisos.RowHeadersWidth = 62;
            this.dgtvPermisos.Size = new System.Drawing.Size(740, 304);
            this.dgtvPermisos.TabIndex = 8;
            this.dgtvPermisos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtvPermisos_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(955, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Permisos";
            // 
            // btnGuardarPermisos
            // 
            this.btnGuardarPermisos.Location = new System.Drawing.Point(335, 769);
            this.btnGuardarPermisos.Name = "btnGuardarPermisos";
            this.btnGuardarPermisos.Size = new System.Drawing.Size(159, 49);
            this.btnGuardarPermisos.TabIndex = 10;
            this.btnGuardarPermisos.Text = "Guardar Permisos";
            this.btnGuardarPermisos.UseVisualStyleBackColor = true;
            this.btnGuardarPermisos.Click += new System.EventHandler(this.btnGuardarPermisos_Click);
            // 
            // chkUsuarios
            // 
            this.chkUsuarios.AutoSize = true;
            this.chkUsuarios.Location = new System.Drawing.Point(147, 553);
            this.chkUsuarios.Name = "chkUsuarios";
            this.chkUsuarios.Size = new System.Drawing.Size(98, 24);
            this.chkUsuarios.TabIndex = 11;
            this.chkUsuarios.Text = "Usuarios";
            this.chkUsuarios.UseVisualStyleBackColor = true;
            // 
            // chkProductos
            // 
            this.chkProductos.AutoSize = true;
            this.chkProductos.Location = new System.Drawing.Point(147, 597);
            this.chkProductos.Name = "chkProductos";
            this.chkProductos.Size = new System.Drawing.Size(107, 24);
            this.chkProductos.TabIndex = 12;
            this.chkProductos.Text = "Productos";
            this.chkProductos.UseVisualStyleBackColor = true;
            // 
            // chkHerramientas
            // 
            this.chkHerramientas.AutoSize = true;
            this.chkHerramientas.Location = new System.Drawing.Point(147, 643);
            this.chkHerramientas.Name = "chkHerramientas";
            this.chkHerramientas.Size = new System.Drawing.Size(131, 24);
            this.chkHerramientas.TabIndex = 13;
            this.chkHerramientas.Text = "Herramientas";
            this.chkHerramientas.UseVisualStyleBackColor = true;
            // 
            // chkActualizacion
            // 
            this.chkActualizacion.AutoSize = true;
            this.chkActualizacion.Location = new System.Drawing.Point(626, 616);
            this.chkActualizacion.Name = "chkActualizacion";
            this.chkActualizacion.Size = new System.Drawing.Size(129, 24);
            this.chkActualizacion.TabIndex = 16;
            this.chkActualizacion.Text = "Actualizacion";
            this.chkActualizacion.UseVisualStyleBackColor = true;
            // 
            // chkEscritura
            // 
            this.chkEscritura.AutoSize = true;
            this.chkEscritura.Location = new System.Drawing.Point(626, 572);
            this.chkEscritura.Name = "chkEscritura";
            this.chkEscritura.Size = new System.Drawing.Size(98, 24);
            this.chkEscritura.TabIndex = 15;
            this.chkEscritura.Text = "Escritura";
            this.chkEscritura.UseVisualStyleBackColor = true;
            // 
            // chkLectura
            // 
            this.chkLectura.AutoSize = true;
            this.chkLectura.Location = new System.Drawing.Point(459, 572);
            this.chkLectura.Name = "chkLectura";
            this.chkLectura.Size = new System.Drawing.Size(89, 24);
            this.chkLectura.TabIndex = 14;
            this.chkLectura.Text = "Lectura";
            this.chkLectura.UseVisualStyleBackColor = true;
            // 
            // chkEliminacion
            // 
            this.chkEliminacion.AutoSize = true;
            this.chkEliminacion.Location = new System.Drawing.Point(459, 616);
            this.chkEliminacion.Name = "chkEliminacion";
            this.chkEliminacion.Size = new System.Drawing.Size(115, 24);
            this.chkEliminacion.TabIndex = 17;
            this.chkEliminacion.Text = "Eliminacion";
            this.chkEliminacion.UseVisualStyleBackColor = true;
            // 
            // FrmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 868);
            this.Controls.Add(this.chkEliminacion);
            this.Controls.Add(this.chkActualizacion);
            this.Controls.Add(this.chkEscritura);
            this.Controls.Add(this.chkLectura);
            this.Controls.Add(this.chkHerramientas);
            this.Controls.Add(this.chkProductos);
            this.Controls.Add(this.chkUsuarios);
            this.Controls.Add(this.btnGuardarPermisos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgtvPermisos);
            this.Controls.Add(this.btnUsuarioSeleccionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvUsuarios);
            this.Name = "FrmPermisos";
            this.Text = "FrmPermisos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUsuarioSeleccionado;
        private System.Windows.Forms.DataGridView dgtvPermisos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardarPermisos;
        private System.Windows.Forms.CheckBox chkUsuarios;
        private System.Windows.Forms.CheckBox chkProductos;
        private System.Windows.Forms.CheckBox chkHerramientas;
        private System.Windows.Forms.CheckBox chkActualizacion;
        private System.Windows.Forms.CheckBox chkEscritura;
        private System.Windows.Forms.CheckBox chkLectura;
        private System.Windows.Forms.CheckBox chkEliminacion;
    }
}