namespace Presentacion
{
    partial class BotonArticulo
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnDetalles = new FontAwesome.Sharp.IconButton();
            this.imgProducto = new System.Windows.Forms.PictureBox();
            this.elipseDetalles = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elipseEliminar = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.guna2Panel1.BorderRadius = 18;
            this.guna2Panel1.BorderThickness = 4;
            this.guna2Panel1.Controls.Add(this.lblNombreProducto);
            this.guna2Panel1.Controls.Add(this.lblPrecio);
            this.guna2Panel1.Controls.Add(this.btnEliminar);
            this.guna2Panel1.Controls.Add(this.btnDetalles);
            this.guna2Panel1.Controls.Add(this.imgProducto);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(175, 291);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.lblNombreProducto.Location = new System.Drawing.Point(14, 13);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(147, 23);
            this.lblNombreProducto.TabIndex = 10;
            this.lblNombreProducto.Text = "Nombre Producto";
            this.lblNombreProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrecio
            // 
            this.lblPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrecio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblPrecio.Location = new System.Drawing.Point(14, 164);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(147, 23);
            this.lblPrecio.TabIndex = 9;
            this.lblPrecio.Text = "$ 1234,56";
            this.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.Red;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.Location = new System.Drawing.Point(18, 235);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(143, 39);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnDetalles
            // 
            this.btnDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(81)))), ((int)(((byte)(110)))));
            this.btnDetalles.FlatAppearance.BorderSize = 0;
            this.btnDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalles.ForeColor = System.Drawing.Color.White;
            this.btnDetalles.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnDetalles.IconColor = System.Drawing.Color.White;
            this.btnDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetalles.IconSize = 30;
            this.btnDetalles.Location = new System.Drawing.Point(18, 190);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(143, 39);
            this.btnDetalles.TabIndex = 7;
            this.btnDetalles.Text = "Ver Detalles";
            this.btnDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetalles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetalles.UseVisualStyleBackColor = false;
            this.btnDetalles.Click += new System.EventHandler(this.BtnDetalles_Click);
            // 
            // imgProducto
            // 
            this.imgProducto.ImageLocation = "";
            this.imgProducto.Location = new System.Drawing.Point(30, 43);
            this.imgProducto.Name = "imgProducto";
            this.imgProducto.Size = new System.Drawing.Size(110, 118);
            this.imgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProducto.TabIndex = 6;
            this.imgProducto.TabStop = false;
            // 
            // elipseDetalles
            // 
            this.elipseDetalles.TargetControl = this.btnDetalles;
            // 
            // elipseEliminar
            // 
            this.elipseEliminar.TargetControl = this.btnEliminar;
            // 
            // BotonArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "BotonArticulo";
            this.Size = new System.Drawing.Size(175, 291);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnDetalles;
        private System.Windows.Forms.PictureBox imgProducto;
        private Guna.UI2.WinForms.Guna2Elipse elipseDetalles;
        private Guna.UI2.WinForms.Guna2Elipse elipseEliminar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombreProducto;
    }
}
