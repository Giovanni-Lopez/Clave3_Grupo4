
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbProducto.SuspendLayout();
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
            this.lbTipoProducto.Location = new System.Drawing.Point(16, 74);
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
            this.cmbTipoProducto.Location = new System.Drawing.Point(19, 91);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoProducto.TabIndex = 3;
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.btnRegresar);
            this.gbProducto.Controls.Add(this.btnSalir);
            this.gbProducto.Controls.Add(this.lbNombreProducto);
            this.gbProducto.Controls.Add(this.btnGuardar);
            this.gbProducto.Controls.Add(this.lbTipoProducto);
            this.gbProducto.Controls.Add(this.txtNombreProducto);
            this.gbProducto.Controls.Add(this.cmbTipoProducto);
            this.gbProducto.Location = new System.Drawing.Point(24, 31);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(271, 156);
            this.gbProducto.TabIndex = 4;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Datos";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegresar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(181, 91);
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
            this.btnSalir.Location = new System.Drawing.Point(181, 60);
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
            this.btnGuardar.Location = new System.Drawing.Point(181, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 31);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormularioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 221);
            this.Controls.Add(this.gbProducto);
            this.Name = "FormularioProductos";
            this.Text = "Formulario productos";
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
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
    }
}