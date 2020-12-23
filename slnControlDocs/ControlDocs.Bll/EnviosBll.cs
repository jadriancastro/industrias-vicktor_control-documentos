using ControlDocs.Bll.Dao;
using ControlDocs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDocs.Bll
{
    public class EnviosBll
    {
        VentasItemCrud ventasItemsCrud = new VentasItemCrud();

        public List<VentasItemDto> ObtenerListaEnvios()
        {
            return ventasItemsCrud.Obtener();
        }
    }
}
