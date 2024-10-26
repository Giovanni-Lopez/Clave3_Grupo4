
namespace Clave3_Grupo4
{
    partial class FormularioGuardarClientes
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbPrestamos = new System.Windows.Forms.Label();
            this.lbTarjetas = new System.Windows.Forms.Label();
            this.lbTipoCuenta = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtDui = new System.Windows.Forms.TextBox();
            this.lbDui = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(16, 28);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(44, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(16, 68);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(44, 13);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProductos);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lbPrestamos);
            this.groupBox1.Controls.Add(this.lbTarjetas);
            this.groupBox1.Controls.Add(this.lbTipoCuenta);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.txtDui);
            this.groupBox1.Controls.Add(this.lbDui);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lbNombre);
            this.groupBox1.Controls.Add(this.lbApellido);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 284);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Préstamo personal",
            "Préstamo \tagropecuario",
            "Préstamo hipotecario"});
            this.comboBox3.Location = new System.Drawing.Point(83, 211);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Tarjeta de débito",
            "Tarjeta de crédito"});
            this.comboBox2.Location = new System.Drawing.Point(83, 172);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cuenta de ahorro",
            "Cuenta de corriente"});
            this.comboBox1.Location = new System.Drawing.Point(83, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // lbPrestamos
            // 
            this.lbPrestamos.AutoSize = true;
            this.lbPrestamos.Location = new System.Drawing.Point(16, 214);
            this.lbPrestamos.Name = "lbPrestamos";
            this.lbPrestamos.Size = new System.Drawing.Size(56, 13);
            this.lbPrestamos.TabIndex = 11;
            this.lbPrestamos.Text = "Prestamos";
            // 
            // lbTarjetas
            // 
            this.lbTarjetas.AutoSize = true;
            this.lbTarjetas.Location = new System.Drawing.Point(16, 175);
            this.lbTarjetas.Name = "lbTarjetas";
            this.lbTarjetas.Size = new System.Drawing.Size(45, 13);
            this.lbTarjetas.TabIndex = 10;
            this.lbTarjetas.Text = "Tarjetas";
            // 
            // lbTipoCuenta
            // 
            this.lbTipoCuenta.AutoSize = true;
            this.lbTipoCuenta.Location = new System.Drawing.Point(16, 143);
            this.lbTipoCuenta.Name = "lbTipoCuenta";
            this.lbTipoCuenta.Size = new System.Drawing.Size(64, 13);
            this.lbTipoCuenta.TabIndex = 9;
            this.lbTipoCuenta.Text = "Tipo cuenta";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Cyan;
            this.btnSalir.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(116, 248);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtDui
            // 
            this.txtDui.Location = new System.Drawing.Point(83, 103);
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(100, 20);
            this.txtDui.TabIndex = 7;
            // 
            // lbDui
            // 
            this.lbDui.AutoSize = true;
            this.lbDui.Location = new System.Drawing.Point(16, 103);
            this.lbDui.Name = "lbDui";
            this.lbDui.Size = new System.Drawing.Size(26, 13);
            this.lbDui.TabIndex = 6;
            this.lbDui.Text = "DUI";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Cyan;
            this.btnGuardar.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGuardar.Location = new System.Drawing.Point(38, 248);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(83, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Cyan;
            this.btnProductos.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProductos.Location = new System.Drawing.Point(197, 248);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(88, 30);
            this.btnProductos.TabIndex = 15;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // FormularioGuardarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 317);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormularioGuardarClientes";
            this.Text = "Formulario Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDui;
        private System.Windows.Forms.Label lbDui;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbPrestamos;
        private System.Windows.Forms.Label lbTarjetas;
        private System.Windows.Forms.Label lbTipoCuenta;
        private System.Windows.Forms.Button btnProductos;
    }
}