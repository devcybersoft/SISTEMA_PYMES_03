using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//paso 1: Agregar las librerías necesarias
using System.Data;
using MySql.Data.MySqlClient;


namespace SISTEMA_PYMES_03
{
    //paso 2: Indicar sí tomará herencia de alguna superclase (:<nombre_de_clase>)
    class ClsClientes : ClsPersona
    {
        //paso 3: Declarar las variables privadas que interactuarán con las 
        //propiedades y metódos de la clase

        private int co; //Interactuará con la propiedad código
        private string rf; //Interactuará con la propiedad rfc
        private string no; //Interactuará con la propiedad nombre
        private string di; //Interactuará con la propiedad dirección
        private string te; //Interactuará con la propiedad teléfono
        private string em; //Interactuará con la propiedad e-mail

        //paso 4: Implementar las propiedades de la clase
        public override int codigo { get { return this.co; } set { this.co = value; } }
        public override string rfc { get { return this.rf; } set { this.rf = value; } }
        public override string nombre { get { return this.no; } set { this.no = value; } }
        public override string direccion { get { return this.di; } set { this.di = value; } }
        public override string telefono { get { return this.te; } set { this.te = value; } }
        public override string email { get { return this.em; } set { this.em = value; } }

        //paso 5: Implementar los metodos de la clase

        public override bool Guardar()
        {
            MySqlConnection cn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();
            cn.ConnectionString = miclase.conexion;
            cn.Open();
            comando.Parameters.AddWithValue("@co", this.co);
            comando.Parameters.AddWithValue("@rf", this.rf);
            comando.Parameters.AddWithValue("@no", this.no);
            comando.Parameters.AddWithValue("@di", this.di);
            comando.Parameters.AddWithValue("@te", this.te);
            comando.Parameters.AddWithValue("@em", this.em);
            comando.CommandText = "Insert into clientes values (@co,@rf,@no,@di,@te,@em";
            int resultado;
            resultado = comando.ExecuteNonQuery();
            cn.Close(); cn.Dispose();
            if (resultado > 0) return true; else return false;

        }
        public override bool Eliminar(int reg)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = miclase.conexion;
            cn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "Delete from CLIENTES where codigo=@co";
            comando.Parameters.AddWithValue("@co", reg);
            int resultado;
            resultado = comando.ExecuteNonQuery();
            cn.Close(); cn.Dispose();
            if (resultado > 0) return true; else return false;
        }
        //Fin del metodo Eliminar

        public override bool Modificar()
        {
            MySqlConnection cn = new MySqlConnection();
            MySqlCommand comando = new MySqlCommand();
            cn.ConnectionString = miclase.conexion;
            comando.Connection = cn;
            comando.CommandText = "Update CLIENTES set rf=@rf,no=no,dI=@di,te=@te,em=@em where co=@co";

            comando.Parameters.AddWithValue("@co", this.co);
            comando.Parameters.AddWithValue("@rf", this.rf);
            comando.Parameters.AddWithValue("@no", this.no);
            comando.Parameters.AddWithValue("@di", this.di);
            comando.Parameters.AddWithValue("@te", this.te);
            comando.Parameters.AddWithValue("@em", this.em);

            int resultado;
            resultado = comando.ExecuteNonQuery();
            cn.Close(); cn.Dispose();

            if (resultado > 0) return true; else return false;


        }
        public override DataTable Listado()
        {
            DataTable dt = new DataTable();
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            using (cn) 
            {
                MySqlCommand cmd = new MySqlCommand("Select * from Clientes", cn);
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
                MySqlCommand cmd = new MySqlCommand("Select * from Clientes Where codigo="+reg, cn);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(dt);
                return dt;
            }

        }
    }
}