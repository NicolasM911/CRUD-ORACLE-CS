using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudOracleClase
{
    internal class Conexion
    {
        //codigo conexion
        private OracleConnection ObjCon;
        //variables
        private string servidor = "localhost", Usuario = "test1", Pass = "123";
        //crear metodo de conexion
        public void conexion()
        {
            try
            {
                ObjCon = new OracleConnection($"data source={servidor}; user id={Usuario} ; password={Pass}");
                ObjCon.Open();
                //MessageBox.Show($"Conexion Exitosa: {ObjCon.State}\nCreado por Nicolás Mahecha Pérez \nModelamiento de Bases de Datos 2022\nVersion: {ObjCon.ServerVersion} \n{ObjCon.Container}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar{ex}");
            }
        }

        public void conexion2()
        {
            try
            {
                ObjCon = new OracleConnection($"data source={servidor}; user id={Usuario} ; password={Pass}");
                ObjCon.Open();
                MessageBox.Show($"Conexion Exitosa: {ObjCon.State}\nCreado por Nicolás Mahecha Pérez \nModelamiento de Bases de Datos 2022\nVersion: {ObjCon.ServerVersion} \n{ObjCon.Container}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar{ex}");
            }
        }

        //metodo cerrar conexion
        public void CerrarConexion()
        {
            ObjCon.Close();
        }

        // funcion para regresar la conexion
        public OracleConnection RegresaConexion()
        {
            return ObjCon;
        }

        //metodo para mostrar los datos
        public DataTable MostrarDatos()
        {
            DataTable dt = new DataTable();
            string Query = "Select * from usuarios";
            OracleCommand command = new OracleCommand(Query, RegresaConexion());
            OracleDataAdapter Adap = new OracleDataAdapter();
            Adap.SelectCommand = command;
            //relleno tabla
            Adap.Fill(dt);
            return dt;
        }

    }
}
