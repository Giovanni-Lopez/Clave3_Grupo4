
namespace Clave3_Grupo4
{
    partial class FormularioProductos
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
            this.lbNombreProducto = new System.Windows.Forms.Label();
            this.lbTipoProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.lbCliente = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lbSaldo = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgvDatosProductos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNombreProducto
            // 
            this.lbNombreProducto.AutoSize = true;
            this.lbNombreProducto.Location = new System.Drawing.Point(16, 19);
            this.lbNombreProducto.Name = "lbNombreProducto";
            this.lbNombreProducto.Size = new System.Drawing.Size(44, 13);
            this.lbNombreProducto.TabIndex = 0;
            this.lbNombreProducto.Text = "Nombre";
            // 
            // lbTipoProducto
            // 
            this.lbTipoProducto.AutoSize = true;
            this.lbTipoProducto.Location = new System.Drawing.Point(16, 61);
            this.lbTipoProducto.Name = "lbTipoProducto";
            this.lbTipoProducto.Size = new System.Drawing.Size(28, 13);
            this.lbTipoProducto.TabIndex = 1;
            this.lbTipoProducto.Text = "Tipo";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(19, 36);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(121, 20);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Items.AddRange(new object[] {
            "Cuenta",
            "Tarjeta",
            "Prestamo"});
            this.cmbTipoProducto.Location = new System.Drawing.Point(19, 78);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoProducto.TabIndex = 3;
            this.cmbTipoProducto.Text = "Seleccione";
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.btnEliminar);
            this.gbProducto.Controls.Add(this.btnActulizar);
            this.gbProducto.Controls.Add(this.lbCliente);
            this.gbProducto.Controls.Add(this.cbxCliente);
            this.gbProducto.Controls.Add(this.txtSaldo);
            this.gbProducto.Controls.Add(this.lbSaldo);
            this.gbProducto.Controls.Add(this.btnRegresar);
            this.gbProducto.Controls.Add(this.btnSalir);
            this.gbProducto.Controls.Add(this.lbNombreProducto);
            this.gbProducto.Controls.Add(this.btnGuardar);
            this.gbProducto.Controls.Add(this.lbTipoProducto);
            this.gbProducto.Controls.Add(this.txtNombreProducto);
            this.gbProducto.Controls.Add(this.cmbTipoProducto);
            this.gbProducto.Location = new System.Drawing.Point(24, 12);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(345, 289);
            this.gbProducto.TabIndex = 4;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Datos";
            // 
            // btnActulizar
            // 
            this.btnActulizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnActulizar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActulizar.Location = new System.Drawing.Point(109, 211);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(86, 31);
            this.btnActulizar.TabIndex = 12;
            this.btnActulizar.Text = "Actulizar";
            this.btnActulizar.UseVisualStyleBackColor = false;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Location = new System.Drawing.Point(16, 150);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(39, 13);
            this.lbCliente.TabIndex = 11;
            this.lbCliente.Text = "Cliente";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(19, 166);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(121, 21);
            this.cbxCliente.TabIndex = 10;
            this.cbxCliente.Text = "Seleccione";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(19, 121);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(121, 20);
            this.txtSaldo.TabIndex = 9;
            // 
            // lbSaldo
            // 
            this.lbSaldo.AutoSize = true;
            this.lbSaldo.Location = new System.Drawing.Point(16, 105);
            this.lbSaldo.Name = "lbSaldo";
            this.lbSaldo.Size = new System.Drawing.Size(34, 13);
            this.lbSaldo.TabIndex = 8;
            this.lbSaldo.Text = "Saldo";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegresar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(100, 248);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 31);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSalir.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(181, 248);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 31);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(19, 211);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 31);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgvDatosProductos
            // 
            this.dgvDatosProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosProductos.Location = new System.Drawing.Point(24, 307);
            this.dgvDatosProductos.Name = "dgvDatosProductos";
            this.dgvDatosProductos.Size = new System.Drawing.Size(536, 113);
            this.dgvDatosProductos.TabIndex = 5;
            this.dgvDatosProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosProductos_CellClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(201, 211);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 31);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 432);
            this.Controls.Add(this.dgvDatosProductos);
            this.Controls.Add(this.gbProducto);
            this.Name = "FormularioProductos";
            this.Text = "Formulario productos";
            this.Load += new System.EventHandler(this.FormularioProductos_Load);
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNombreProducto;
        private System.Windows.Forms.Label lbTipoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lbSaldo;
        private System.Windows.Forms.DataGridView dgvDatosProductos;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}