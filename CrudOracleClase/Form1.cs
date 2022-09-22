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
    public partial class Form1 : Form
    {
        //instanciar la clase
        Conexion conex = new Conexion();
        public Form1()
        {
            InitializeComponent();
            conex.conexion();
            DataTable dt = new DataTable();
            try
            {
                dt = conex.MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar{ex}");
            }
            DGV.DataSource = dt;
            conex.CerrarConexion();
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

        private void btnConectar_Click(object sender, EventArgs e)
        {
            conex.conexion2();
            conex.CerrarConexion();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            conex.conexion2();
            DataTable dt = new DataTable();
            try
            {
                dt = conex.MostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar{ex}");
            }
            DGV.DataSource = dt;
            conex.CerrarConexion();
        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            conex.conexion();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAdd f2 = new FrmAdd();
            f2.Show();
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FrmDel f3 = new FrmDel();
            f3.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FrmCh f4 = new FrmCh();
            f4.Show();
            this.Hide();
        }
    }
}
