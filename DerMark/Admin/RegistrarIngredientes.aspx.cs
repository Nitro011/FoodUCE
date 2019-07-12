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
    public partial class RegistrarIngredientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        [WebMethod]
        public static object insertar(string categoriaC,string unidad_de_medidaC,string nombre_ProductoC, string cantidadC,string costoC,string precio_ventaC,string entrada_del_productoC,string descripcionC,string reposicionC )
        {

            Almacen_BL bc = new Almacen_BL();


            Almacen_E alm = new Almacen_E();

            int categoriaV = Convert.ToInt32(categoriaC);
            int unidadDeMedidaV = Convert.ToInt32(unidad_de_medidaC);
            int cantidadV = Convert.ToInt32(cantidadC);
            decimal costoV = Convert.ToDecimal(costoC);
            decimal precio_ventaV = Convert.ToDecimal(precio_ventaC);
            DateTime entrada_productoV = Convert.ToDateTime(entrada_del_productoC);
            decimal reposicionV = Convert.ToDecimal(reposicionC);

            alm.cantidad = categoriaV;
            alm.unidad_de_medida = unidadDeMedidaV;
            alm.nombre_producto = nombre_ProductoC;
            alm.cantidad = cantidadV;
            alm.costo = costoV;
            alm.precio_venta = precio_ventaV;
            alm.entrada_del_producto = entrada_productoV;
            alm.reposicion = reposicionV;
            alm.descripcion = descripcionC;









            return bc.Insertar(alm);


        }

        [WebMethod]
        public static object llenarUnidadDeMedida()
        {
            LlenarDropDown_BL ll = new LlenarDropDown_BL();

            return ll.ObtenerUnidadDeMedida();

        }

        [WebMethod]
        public static object llenarCategoria()
        {
            LlenarDropDown_BL ll = new LlenarDropDown_BL();

            return ll.ObtenerCategoria();

        }




    }
}