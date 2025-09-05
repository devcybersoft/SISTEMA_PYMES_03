using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Paso 1. Agregar las librerías necesarias
using System.Data;
using MySql.Data.MySqlClient;

namespace SISTEMA_PYMES_03
{
    //Paso 2. Indicar sí es superclase o tomará herencia o dejarla como esta sí
    class ClsArticulo
    {

        //Paso 3- Declarar las variables privadas que interactuarán con las          
        string co; //.... Codigo del articulo
        string de; //.... Descripción del articulo
        float pc; //..... Pcompra (Precio de compra)
        float pv; //..... Pventa (Precio de venta)
        float ex; //..... Existencia
        float mi; //..... Stock mínimo
        float ma; //..... Stock máximo
        int cp; //....... Código del proveedor


        //Paso 4. Implementar las propiedades
        public string codigo { get { return this.co; } set { this.co = value; } }
        public string descripcion { get { return this.de; } set { this.de = value; } }
        public float pcompra { get { return this.pc; } set { this.pc = value; } }
        public float pventa { get { return this.pv; } set { this.pv = value; } }
        public float existencia { get { return this.ex; } set { this.ex = value; } }
        public float mínimo { get { return this.mi; } set { this.mi = value; } }
        public float máximo { get { return this.ma; } set { this.ma = value; } }
        public int códigoproveedor { get { return this.cp; } set { this.cp = value; } }


        //Paso 5. Implementar los metodos
        
        public bool Guardar()
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = miclase.conexion;
            cn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = cn;
            comando.CommandText = "Insert into ARTICULOS values (@co,@de,@pc,@pv,@ex,@mi,@ma,@cp)";
            comando.Parameters.AddWithValue("@co", this.co);
            comando.Parameters.AddWithValue("@de", this.de);
            comando.Parameters.AddWithValue("@pc", this.pc);
            comando.Parameters.AddWithValue("@pv", this.pv);
            comando.Parameters.AddWithValue("@ex", this.ex);
            comando.Parameters.AddWithValue("@mi", this.mi);
            comando.Parameters.AddWithValue("@ma", this.ma);
            comando.Parameters.AddWithValue("@cp", this.cp);
            int resultado;
            resultado = comando.ExecuteNonQuery();
            if (resultado > 0) return true; else return false;
        } // Fin del metodo Guardar()

        public bool Eliminar (int reg)
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = miclase.conexion;
            cn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = cn;
            comando.CommandText = "Delete from ARTICULOS where codigo=@co";
            comando.Parameters.AddWithValue("@co", reg);
            int resultado;
            resultado = comando.ExecuteNonQuery();
            if (resultado > 0) return true; else return false;
        } // fin del metodo Eliminar()

        public bool Modificar()
        {
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = miclase.conexion;
            cn.Open();
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = cn;
            comando.CommandText = "Update ARTICULOS set descripcion=@de,pcompra=@pc,pventa=@pv,existencia=@ex,minimo=@mi,maximo=@ma,codproveedor=@cp where codigo=@co";
            comando.Parameters.AddWithValue("@co", this.co);
            comando.Parameters.AddWithValue("@de", this.de);
            comando.Parameters.AddWithValue("@pc", this.pc);
            comando.Parameters.AddWithValue("@pv", this.pv);
            comando.Parameters.AddWithValue("@ex", this.ex);
            comando.Parameters.AddWithValue("@mi", this.mi);
            comando.Parameters.AddWithValue("@ma", this.ma);
            comando.Parameters.AddWithValue("@cp", this.mi);


            int resultado;
            resultado = comando.ExecuteNonQuery();
            if (resultado > 0) return true; else return false;
        }

        public DataTable Listado()
        {
            DataTable dt = new DataTable();
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            using (cn)
            {
                MySqlCommand cmd = new MySqlCommand("Select * from Articulos", cn);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(dt);
                return dt;
            }
        }

        public DataTable Consultar(int reg)
        {
            DataTable dt = new DataTable();
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            using (cn)
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Articulos WHERE codigo = @co", cn);
                cmd.Parameters.AddWithValue("@co", reg);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(dt); 
            }
            return dt;
        }

      
    }
}
