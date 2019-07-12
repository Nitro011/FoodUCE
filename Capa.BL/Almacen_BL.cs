using Capa.Datos;
using Capa.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.BL
{
   public class Almacen_BL
    {
        private Almacen_DA db = new Almacen_DA();

        public object Insertar(Almacen_E alm)
        {
            return db.insertar(alm);
        }
    }
}
