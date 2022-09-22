using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CrudOracleClase
{

    public partial class FrmAdd : Form
    {
        //instanciar la clase
        Conexion conex = new Conexion();

        public FrmAdd()
        {
            InitializeComponent();

        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            try
            {
                conex.conexion();
                string sql = "insert into usuarios(nom_user,pass_user) values ('" + txtAddUser.Text + "' , '" + txtAddPass.Text + "')";
                OracleCommand command = new OracleCommand(sql, conex.RegresaConexion());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                MessageBox.Show("Persona agregada correctamente");
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar: {ex}");

            }
            conex.CerrarConexion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
Gracias por visitarnos
Creado por Nicolás Mahecha Pérez
Modelamiento de Bases de Datos 2022
");
            System.Windows.Forms.Application.Exit();
        }
    }
}
