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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpUsuarios = new System.Windows.Forms.ToolStripButton();
            this.OpProductos = new System.Windows.Forms.ToolStripButton();
            this.Opherramientas = new System.Windows.Forms.ToolStripButton();
            this.OpSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpUsuarios,
            this.OpProductos,
            this.Opherramientas,
            this.OpSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(86, 652);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpUsuarios
            // 
            this.OpUsuarios.AutoSize = false;
            this.OpUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("OpUsuarios.Image")));
            this.OpUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpUsuarios.Name = "OpUsuarios";
            this.OpUsuarios.Size = new System.Drawing.Size(84, 84);
            this.OpUsuarios.Text = "toolStripButton1";
            this.OpUsuarios.Click += new System.EventHandler(this.OpUsuarios_Click);
            // 
            // OpProductos
            // 
            this.OpProductos.AutoSize = false;
            this.OpProductos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpProductos.Image = ((System.Drawing.Image)(resources.GetObject("OpProductos.Image")));
            this.OpProductos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpProductos.Name = "OpProductos";
            this.OpProductos.Size = new System.Drawing.Size(84, 84);
            this.OpProductos.Text = "toolStripButton2";
            this.OpProductos.Click += new System.EventHandler(this.OpProductos_Click);
            // 
            // Opherramientas
            // 
            this.Opherramientas.AutoSize = false;
            this.Opherramientas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Opherramientas.Image = ((System.Drawing.Image)(resources.GetObject("Opherramientas.Image")));
            this.Opherramientas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Opherramientas.Name = "Opherramientas";
            this.Opherramientas.Size = new System.Drawing.Size(84, 84);
            this.Opherramientas.Text = "toolStripButton3";
            this.Opherramientas.Click += new System.EventHandler(this.Opherramientas_Click);
            // 
            // OpSalir
            // 
            this.OpSalir.AutoSize = false;
            this.OpSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpSalir.Image = ((System.Drawing.Image)(resources.GetObject("OpSalir.Image")));
            this.OpSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpSalir.Name = "OpSalir";
            this.OpSalir.Size = new System.Drawing.Size(84, 84);
            this.OpSalir.Text = "toolStripButton4";
            this.OpSalir.Click += new System.EventHandler(this.OpSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 652);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton OpUsuarios;
        private System.Windows.Forms.ToolStripButton OpProductos;
        private System.Windows.Forms.ToolStripButton Opherramientas;
        private System.Windows.Forms.ToolStripButton OpSalir;
    }
}