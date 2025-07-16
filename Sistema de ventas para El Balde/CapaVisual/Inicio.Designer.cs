namespace CapaVisual
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.gbEncabezado = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUsuarioEncabezado = new System.Windows.Forms.Label();
            this.lblTituloEncabezado = new System.Windows.Forms.Label();
            this.gbModulos = new System.Windows.Forms.GroupBox();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.gbEncabezado.SuspendLayout();
            this.gbModulos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEncabezado
            // 
            this.gbEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.gbEncabezado.Controls.Add(this.btnClose);
            this.gbEncabezado.Controls.Add(this.lblUsuarioEncabezado);
            this.gbEncabezado.Controls.Add(this.lblTituloEncabezado);
            this.gbEncabezado.Location = new System.Drawing.Point(-2, -9);
            this.gbEncabezado.Name = "gbEncabezado";
            this.gbEncabezado.Size = new System.Drawing.Size(900, 60);
            this.gbEncabezado.TabIndex = 0;
            this.gbEncabezado.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(829, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 41);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblUsuarioEncabezado
            // 
            this.lblUsuarioEncabezado.AutoSize = true;
            this.lblUsuarioEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioEncabezado.Location = new System.Drawing.Point(522, 32);
            this.lblUsuarioEncabezado.Name = "lblUsuarioEncabezado";
            this.lblUsuarioEncabezado.Size = new System.Drawing.Size(68, 20);
            this.lblUsuarioEncabezado.TabIndex = 1;
            this.lblUsuarioEncabezado.Text = "Usuario:";
            this.lblUsuarioEncabezado.Click += new System.EventHandler(this.lblUsuarioEncabezado_Click);
            // 
            // lblTituloEncabezado
            // 
            this.lblTituloEncabezado.AutoSize = true;
            this.lblTituloEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblTituloEncabezado.Location = new System.Drawing.Point(6, 21);
            this.lblTituloEncabezado.Name = "lblTituloEncabezado";
            this.lblTituloEncabezado.Size = new System.Drawing.Size(209, 25);
            this.lblTituloEncabezado.TabIndex = 0;
            this.lblTituloEncabezado.Text = "Sistema de Ventas";
            this.lblTituloEncabezado.Click += new System.EventHandler(this.lblTituloEncabezado_Click);
            // 
            // gbModulos
            // 
            this.gbModulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.gbModulos.Controls.Add(this.btnAcercaDe);
            this.gbModulos.Controls.Add(this.btnMantenimiento);
            this.gbModulos.Controls.Add(this.btnReportes);
            this.gbModulos.Controls.Add(this.btnClientes);
            this.gbModulos.Controls.Add(this.btnProveedores);
            this.gbModulos.Controls.Add(this.btnCompras);
            this.gbModulos.Controls.Add(this.btnVentas);
            this.gbModulos.Controls.Add(this.btnUsuario);
            this.gbModulos.Location = new System.Drawing.Point(-2, 57);
            this.gbModulos.Name = "gbModulos";
            this.gbModulos.Size = new System.Drawing.Size(99, 505);
            this.gbModulos.TabIndex = 1;
            this.gbModulos.TabStop = false;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcercaDe.Image = ((System.Drawing.Image)(resources.GetObject("btnAcercaDe.Image")));
            this.btnAcercaDe.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 413);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(99, 60);
            this.btnAcercaDe.TabIndex = 7;
            this.btnAcercaDe.Text = "Acerca De";
            this.btnAcercaDe.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAcercaDe.UseVisualStyleBackColor = false;
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnMantenimiento.Image")));
            this.btnMantenimiento.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMantenimiento.Location = new System.Drawing.Point(0, 354);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(99, 60);
            this.btnMantenimiento.TabIndex = 6;
            this.btnMantenimiento.Text = "Mantenimiento";
            this.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMantenimiento.UseVisualStyleBackColor = false;
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportes.Location = new System.Drawing.Point(0, 295);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(99, 60);
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(0, 236);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(99, 60);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProveedores.Location = new System.Drawing.Point(0, 177);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(99, 60);
            this.btnProveedores.TabIndex = 3;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompras.Location = new System.Drawing.Point(0, 118);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCompras.Size = new System.Drawing.Size(99, 60);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVentas.Location = new System.Drawing.Point(0, 59);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(99, 60);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.UseVisualStyleBackColor = false;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(99, 60);
            this.btnUsuario.TabIndex = 0;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Location = new System.Drawing.Point(103, 57);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(772, 492);
            this.pnlContenedor.TabIndex = 2;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.gbModulos);
            this.Controls.Add(this.gbEncabezado);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.gbEncabezado.ResumeLayout(false);
            this.gbEncabezado.PerformLayout();
            this.gbModulos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEncabezado;
        private System.Windows.Forms.Label lblUsuarioEncabezado;
        private System.Windows.Forms.Label lblTituloEncabezado;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbModulos;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnMantenimiento;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}

