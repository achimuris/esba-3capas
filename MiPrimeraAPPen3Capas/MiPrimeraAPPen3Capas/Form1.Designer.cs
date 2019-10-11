namespace MiPrimeraAPPen3Capas
{
    partial class Form1
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
            this.lblCodigoDeProducto = new System.Windows.Forms.Label();
            this.lblDescripProducto = new System.Windows.Forms.Label();
            this.lblTipoDeProducto = new System.Windows.Forms.Label();
            this.txtCodigoDeProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbTipoDeProductos = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvTiposDeProductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDeProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoDeProducto
            // 
            this.lblCodigoDeProducto.AutoSize = true;
            this.lblCodigoDeProducto.Location = new System.Drawing.Point(50, 57);
            this.lblCodigoDeProducto.Name = "lblCodigoDeProducto";
            this.lblCodigoDeProducto.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoDeProducto.TabIndex = 0;
            this.lblCodigoDeProducto.Text = "Código:";
            // 
            // lblDescripProducto
            // 
            this.lblDescripProducto.AutoSize = true;
            this.lblDescripProducto.Location = new System.Drawing.Point(50, 82);
            this.lblDescripProducto.Name = "lblDescripProducto";
            this.lblDescripProducto.Size = new System.Drawing.Size(66, 13);
            this.lblDescripProducto.TabIndex = 1;
            this.lblDescripProducto.Text = "Descripción:";
            // 
            // lblTipoDeProducto
            // 
            this.lblTipoDeProducto.AutoSize = true;
            this.lblTipoDeProducto.Location = new System.Drawing.Point(50, 110);
            this.lblTipoDeProducto.Name = "lblTipoDeProducto";
            this.lblTipoDeProducto.Size = new System.Drawing.Size(91, 13);
            this.lblTipoDeProducto.TabIndex = 2;
            this.lblTipoDeProducto.Text = "Tipo de producto:";
            // 
            // txtCodigoDeProducto
            // 
            this.txtCodigoDeProducto.Location = new System.Drawing.Point(165, 57);
            this.txtCodigoDeProducto.Name = "txtCodigoDeProducto";
            this.txtCodigoDeProducto.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDeProducto.TabIndex = 3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(165, 82);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // cmbTipoDeProductos
            // 
            this.cmbTipoDeProductos.FormattingEnabled = true;
            this.cmbTipoDeProductos.Location = new System.Drawing.Point(165, 110);
            this.cmbTipoDeProductos.Name = "cmbTipoDeProductos";
            this.cmbTipoDeProductos.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDeProductos.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(53, 200);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(165, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvTiposDeProductos
            // 
            this.dgvTiposDeProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiposDeProductos.Location = new System.Drawing.Point(306, 57);
            this.dgvTiposDeProductos.Name = "dgvTiposDeProductos";
            this.dgvTiposDeProductos.Size = new System.Drawing.Size(240, 150);
            this.dgvTiposDeProductos.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 273);
            this.Controls.Add(this.dgvTiposDeProductos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbTipoDeProductos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigoDeProducto);
            this.Controls.Add(this.lblTipoDeProducto);
            this.Controls.Add(this.lblDescripProducto);
            this.Controls.Add(this.lblCodigoDeProducto);
            this.Name = "Form1";
            this.Text = "Gestión de Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiposDeProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoDeProducto;
        private System.Windows.Forms.Label lblDescripProducto;
        private System.Windows.Forms.Label lblTipoDeProducto;
        private System.Windows.Forms.TextBox txtCodigoDeProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbTipoDeProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvTiposDeProductos;
    }
}

