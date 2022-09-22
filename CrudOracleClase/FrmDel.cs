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
    public partial class FrmDel : Form
    {
        //instanciar la clase
        Conexion conex = new Conexion();
        public FrmDel()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conex.conexion();
                OracleCommand command = new OracleCommand("eliminar", conex.RegresaConexion());
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt32(txtDelUserID.Text);
                command.ExecuteNonQuery();
                MessageBox.Show($"ID Persona {txtDelUserID.Text} Eliminada correctamente");
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
