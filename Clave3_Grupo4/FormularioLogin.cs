using System;
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
    public partial class FormularioLogin : Form
    {
        private ConexionDB mConexion;
        public FormularioLogin()
        {
            InitializeComponent();
            mConexion = new ConexionDB();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            
            //Verifica que la conexión esté correstamente conectada, si no da error de conexión
            try
            {                
                if (mConexion.getConnection() != null)
                {                    
                    MessageBox.Show("Conexion Exitosa!!");

                    this.Hide();

                    //Abrir el formulario de guardar
                    FormularioGuardar formularioGuardar = new FormularioGuardar();

                    // Mostrar el formulario
                    formularioGuardar.Show();                    
                }                             
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Hubo un error en su conexion, por favor verificar...: " + ex);
            }            
        }
    }
}
