using ControlDocs.Dao;
using ControlDocs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDocs.Control
{
    public class EnvioControl
    {
        View_EnvioCrud ventasItemsCrud = new View_EnvioCrud();

        public List<View_EnvioDto> ObtenerListaEnvios()
        {
            return ventasItemsCrud.Obtener();
        }
    }
}
