using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Crud_Estudiantes
{
    class Conexion
    {
        public static SqlConnection Conectar(){
            SqlConnection cn = new SqlConnection("SERVER=LAPTOP-9AENMDDC;DATABASE=ALUMNOS;integrated security=true");
            cn.Open();
            return cn;
        }
    }
}
