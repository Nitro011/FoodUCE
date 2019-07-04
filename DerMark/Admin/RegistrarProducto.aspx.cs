using Capa.BL;
using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DerMark.Admin
{
    public partial class RegistrarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static object insertar(string nombreProducto, string cantidad, string unidad_de_medida, string descripcion,string costo,string precio_ventas,string fentradav)
        {

            DateTime fEntrada = Convert.ToDateTime(fentradav);
            int unidad_de_medidav = Convert.ToInt32(unidad_de_medida);
            int cantidadC = Convert.ToInt32(cantidad);
            decimal precioC = Convert.ToDecimal(costo);
            decimal precioV = Convert.ToDecimal(precio_ventas);

            Producto_BL bc = new Producto_BL();


            Productos_E pro = new Productos_E();

            pro.nombres_productosv = nombreProducto;
            pro.descripcionv = descripcion;
            pro.cantidadv = cantidadC;
            pro.precio_ventasv = precioV;
            pro.costov = precioC;
            pro.unidad_de_medidav = unidad_de_medidav;
            pro.fecha_entradav = fEntrada;



            return bc.Insertar(pro);


        }




        //[WebMethod]
        //public static object ObtenerCategoria()
        //{

        //    Tipo_Producto_BL p = new Tipo_Producto_BL();


        //    return p.Obtener_tipoProducto();


        //}

        [WebMethod]
        public static object llenarUnidadDeMedida()
        {
            LlenarDropDown_BL ll = new LlenarDropDown_BL();

            return ll.ObtenerUnidadDeMedida();



        }
    }
}