using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//paso 1.- agregar o poner en uso laslibrerias necesarias
using System.Data;
using MySql.Data.MySqlClient;

namespace SISTEMA_PYMES_03
{
    // paso 2.- indicar si ésta clase será SUPERCLASE (abstract)
    abstract class ClsPersona
    {
        //paso 3.- definir las propiedades que tendrá
        public abstract int codigo { get; set; } // get=lectura  set=asignacion
        public abstract string rfc { get; set; }
        public abstract string nombre { get; set; }
        public abstract string direccion { get; set; }
        public abstract string telefono { get; set; }
        public abstract string email { get; set; }

        //paso 4.- Definir los metodos que tendrá la clase
        public abstract bool Guardar(); // abstract=heredable,  bool=retornará falso o verdadero         
        public abstract bool Eliminar(int reg);
        public abstract bool Modificar();
        public abstract DataTable Listado();
        public abstract DataTable Consultar(int reg);
        
        //no mover
    }
}
