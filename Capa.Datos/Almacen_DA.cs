using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
   public class Almacen_DA
    {
        string cnSTR = @"data source=DESKTOP-ALH0A74\SQLEXPRESS01;initial catalog=DerMark;Integrated Security=true";


        public object insertar(Almacen_E alm)
        {

            using (SqlConnection cn = new SqlConnection(cnSTR))
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "Insertar_Almacen";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@categoria", alm.categoria);
                cmd.Parameters.AddWithValue("@unidad_de_medida", alm.unidad_de_medida);
                cmd.Parameters.AddWithValue("@nombre_producto", alm.nombre_producto);
                cmd.Parameters.AddWithValue("@cantidad", alm.cantidad);
                cmd.Parameters.AddWithValue("@costo", alm.costo);
                cmd.Parameters.AddWithValue("@precio_venta", alm.precio_venta);
                cmd.Parameters.AddWithValue("@entrada_producto", alm.entrada_del_producto);
                cmd.Parameters.AddWithValue("@descripcion", alm.descripcion);
                cmd.Parameters.AddWithValue("@reposicion", alm.reposicion);




                return cmd.ExecuteScalar();

            }


        }






    }
}
