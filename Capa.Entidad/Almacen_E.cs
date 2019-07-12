using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidad
{
   public class Almacen_E
    {
        public int id_Almacen { get; set; }

        public int categoria { get; set; }
        public int unidad_de_medida { get; set; }
        public string nombre_producto { get; set; }
        public int cantidad { get; set; }
        public decimal costo { get; set; }
        public decimal precio_venta { get; set; }
        public DateTime entrada_del_producto { get; set; }
        public decimal reposicion { get; set; }
        public string descripcion { get; set; }



    }
}
