using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//paso 1- Agregar las librerias necesarias
using System.Data;
using MySql.Data.MySqlClient;


namespace SISTEMA_PYMES_03
{
    //paso 2- indicar si tomará herencia de alguna superclase (:<nombre_de_clase>)
    class ClsProveedor : ClsPersona
    {
        //paso 3- Declarar las variables privadas que interactuarán con las          
        private int co; // Interatuará con la propiedad codigo
        private string rf; //.... rfc
        private string no; //.... nombre
        private string di; //.... direccion
        private string te; //.... telefono
        private string em; //.... email

        //paso 4- Implementar las propiedades de clase
        public override int codigo { get { return this.co; } set { this.co = value; } }
        public override string rfc { get { return this.rf; } set { this.rf = value; } }
        public override string nombre { get { return this.no; } set { this.no = value; } }
        public override string direccion { get { return this.di; } set { this.di = value; } }
        public override string telefono { get { return this.te; } set { this.te = value; } }
        public override string email { get { return this.em; } set { this.em = value; } }

        // paso 5- implementar los metodos de la clase
        public override bool Guardar()
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = miclase.conexion;
            cn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = cn;
            comando.CommandText = "Insert into PROVEEDORES values (@co,@rf,@no,@di,@te,@em)";
            comando.Parameters.AddWithValue("@co", this.co);
            comando.Parameters.AddWithValue("@rf", this.rf);
            comando.Parameters.AddWithValue("@no", this.no);
            comando.Parameters.AddWithValue("@di", this.di);
            comando.Parameters.AddWithValue("@te", this.te);
            comando.Parameters.AddWithValue("@em", this.em);
            int resultado;
            resultado = comando.ExecuteNonQuery();
            if (resultado > 0) return true; else return false;
        } // fin del metodo Guardar()


        public override bool Eliminar(int reg)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = miclase.conexion;
            cn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = cn;
            comando.CommandText = "Delete from PROVEEDORES where codigo=@co";
            comando.Parameters.AddWithValue("@co", reg);
            int resultado;
            resultado = comando.ExecuteNonQuery();
            if (resultado > 0) return true; else return false;
        } // fin del metodo Eliminar()


        public override bool Modificar()
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = miclase.conexion;
            cn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = cn;
            comando.CommandText = "Update PROVEEDORES set rfc=@rf,nombre=@no,direccion=@di,telefono=@te,email=@em where codigo=@co";
            comando.Parameters.AddWithValue("@co", this.co);
            comando.Parameters.AddWithValue("@rf", this.rf);
            comando.Parameters.AddWithValue("@no", this.no);
            comando.Parameters.AddWithValue("@di", this.di);
            comando.Parameters.AddWithValue("@te", this.te);
            comando.Parameters.AddWithValue("@em", this.em);
            int resultado;
            resultado = comando.ExecuteNonQuery();
            if (resultado > 0) return true; else return false;
        }


        public override DataTable Listado()
        {
            DataTable dt = new DataTable();
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            using (cn)
            {
                MySqlCommand cmd = new MySqlCommand("Select * from Proveedores", cn);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(dt);
                return dt;
            }
        }

        public override DataTable Consultar(int reg)
        {
            DataTable dt = new DataTable();
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            using (cn)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Proveedores WHERE codigo = @co", cn);
                cmd.Parameters.AddWithValue("@co", reg);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(dt); 
            }
            return dt;
        }

    }
}
