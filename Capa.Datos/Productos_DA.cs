using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa.Datos;
using Capa.Entidad;
using System.Data.SqlClient;

namespace Capa.Datos
{
  public  class Productos_DA
    {
        string cnSTR = "data source=.;initial catalog=DerMark;user id = admin;password = 123456789";
        public object insertar(Productos_E pro)
        {

            using (SqlConnection cn = new SqlConnection(cnSTR))
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "insertar_Productos";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

               
                cmd.Parameters.AddWithValue("@nombre_producto", pro.nombres_productosv);
                cmd.Parameters.AddWithValue("@descripcion", pro.descripcionv);
                cmd.Parameters.AddWithValue("@cantidad", pro.cantidadv);
                cmd.Parameters.AddWithValue("@precio_venta", pro.precio_ventasv);
                cmd.Parameters.AddWithValue("@costo", pro.costov);
                cmd.Parameters.AddWithValue("@unidad_de_medida", pro.unidad_de_medidav);
                cmd.Parameters.AddWithValue("@fecha_entrada", pro.fecha_entradav);


                return cmd.ExecuteScalar();

            }


        }

        public List<Productos_E> obt_producto()
        {
            List<Productos_E> producto = new List<Productos_E>();



            using (SqlConnection cn = new SqlConnection(cnSTR))
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = "consultar_almacen_producto";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Productos_E obj = new Productos_E();


                    obj.nombres_productosv = reader["nombre_producto"].ToString();
                    obj.cantidadv = Convert.ToInt32(reader["cantidad"].ToString());
                    obj.unidadMedidastrv = reader["unidad_de_medida"].ToString();
                    obj.costov = Convert.ToDecimal(reader["costo"].ToString());
                    obj.precio_ventasv = Convert.ToDecimal(reader["precio_venta"].ToString());
                    obj.descripcionv = reader["descripcion"].ToString();
                    obj.estadov = reader["estados"].ToString();
                    obj.fecha_entradav =Convert.ToDateTime( reader["entrada"].ToString());
                    obj.ganancia = reader["ganancia"].ToString();

                    producto.Add(obj);
                }



                return producto;

            }

        }
    }
}
