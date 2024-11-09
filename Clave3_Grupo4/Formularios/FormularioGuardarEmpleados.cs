﻿using Clave3_Grupo4.Clases;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave3_Grupo4
{
    public partial class FormularioGuardarEmpleados : Form
    {
        public FormularioGuardarEmpleados()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

            //Validando campos vacios
            if (string.IsNullOrWhiteSpace(txtNombres.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(cmbTipoUsuario.SelectedItem != null ? cmbTipoUsuario.SelectedItem.ToString() : string.Empty))
            {
                MessageBox.Show("Por favor complete todos los campos...!!");
                return;
            }

            //Creando nueva instancia 
            
            RegistroEmpleados nuevoEmpleado = new RegistroEmpleados(txtNombres.Text, txtApellidos.Text, cmbTipoUsuario.Text);

            //metodo para que guarde nuestro registro
            nuevoEmpleado.GuardarRegistro();

            //Limpiando campos, luego de haber guardado
            txtNombres.Clear();
            txtApellidos.Clear();
            cmbTipoUsuario.Text = "Seleccione";
        }

        private void CargarDatos(DataGridView dgv, string sqlString)
        {
            ConexionDB conexion = new ConexionDB();
            MySqlConnection connection = conexion.getConnection();
            MySqlCommand command = new MySqlCommand(sqlString, connection);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(command);
            DataTable dt = new DataTable();

            adaptador.Fill(dt);

            dgv.DataSource = dt;

        }

        private void FormularioGuardarEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos(dgvEmpleados,"select * from empleados");
        }
    }
}