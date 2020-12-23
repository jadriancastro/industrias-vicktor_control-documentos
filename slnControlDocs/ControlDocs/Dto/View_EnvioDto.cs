using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDocs.Dto
{
    public class View_EnvioDto
    {
        public Nullable<int> NumDoc { get; set; }
        public string U_FacNum { get; set; }
        public Nullable<System.DateTime> FechaDoc { get; set; }
        public Nullable<System.DateTime> FechaVenci { get; set; }
        public string CodCliente { get; set; }
        public string NomCliente { get; set; }
        public string DirCliente { get; set; }
        public Nullable<decimal> TotalDoc { get; set; }
        public string Ref1 { get; set; }
        public Nullable<short> ExtraMonth { get; set; }
        public Nullable<short> ExtraDays { get; set; }
        public string U_Tipo_Venta { get; set; }
        public string U_TipoNC { get; set; }
        public string U_Cod_Sucursal { get; set; }
        public int LineNum { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> TotalSumSy { get; set; }
        public string DiasCredito { get; set; }
    }
}
