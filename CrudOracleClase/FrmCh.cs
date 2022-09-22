using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudOracleClase
{
    public partial class FrmCh : Form
    {
        //instanciar la clase
        Conexion conex = new Conexion();
        public FrmCh()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
Gracias por visitarnos
Creado por Nicolás Mahecha Pérez
Modelamiento de Bases de Datos 2022
");
            Application.Exit();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conex.conexion();
                OracleCommand command = new OracleCommand("actualizar", conex.RegresaConexion());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtCHID.Text);
                command.Parameters.Add("nom", OracleType.VarChar).Value = txtCHUSER.Text;
                command.Parameters.Add("cont", OracleType.VarChar).Value = txtCHPASS.Text;
                command.ExecuteNonQuery();
                MessageBox.Show("Persona Modificada correctamente");
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar: {ex}");
            }
            conex.RegresaConexion();
        }
    }
}
