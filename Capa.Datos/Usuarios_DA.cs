using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Entidad;
using System.Data.SqlClient;
using System.Data;

namespace Capa.Datos
{
   public class Usuarios_DA
    {
    
        public Object loguearse( Usuarios_E ue)
        {
            string cnSTR = @"data source=DESKTOP-ALH0A74\SQLEXPRESS01;initial catalog=DerMark;Integrated Security=true";


            using (SqlConnection cn = new SqlConnection(cnSTR))
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "LoginUsuarios";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@correo_electronico", ue.correo_electronico);
               
                cmd.Parameters.AddWithValue("@contraseña", ue.contraseña);
                

                return cmd.ExecuteScalar();

            }



        }


    }
}
