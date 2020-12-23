using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDocs.Dto
{
    public class VentasItemDto
    {
        public Nullable<int> DocNum { get; set; }
        public string DocType { get; set; }
        public Nullable<System.DateTime> DocDate { get; set; }
        public string CardCode { get; set; }
        public string CardName { get; set; }
        public int LineNum { get; set; }
        public string ItemCode { get; set; }
        public string Dscription { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public string U_Cod_Sucursal { get; set; }
        public string WhsCode { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> TotalSumSy { get; set; }
        public string U_Cod_Marca { get; set; }
        public string u_talla { get; set; }
        public string U_Cod_Subfam { get; set; }
        public string U_Cod_Tipo { get; set; }
        public string U_Color { get; set; }
        public string U_Descripcion { get; set; }
        public string U_Estilo { get; set; }
        public string U_Limite { get; set; }
        public string U_Maximo { get; set; }
        public string U_Mayor { get; set; }
        public Nullable<decimal> minlevel { get; set; }
        public Nullable<decimal> MaxLevel { get; set; }
        public Nullable<int> slpcode { get; set; }
    }
}
