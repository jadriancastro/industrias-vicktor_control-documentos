using ControlDocs.Datos.Modelo;
using ControlDocs.Dto;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDocs.Dao
{
    public class View_EnvioCrud
    {
        public List<View_EnvioDto> Obtener()
        {
            List<View_EnvioDto> listaEnvios = new List<View_EnvioDto>();

            using (Viktor2Entities contex = new Viktor2Entities())
            {
                List<View_DocEnvios> lista = (from x in contex.View_DocEnvios
                                              select x).ToList<View_DocEnvios>();

                foreach (View_DocEnvios v in lista)
                {
                    View_EnvioDto envioDto = new View_EnvioDto();

                    envioDto.NumDoc = v.NumDoc;
                    envioDto.U_FacNum = v.U_FacNum;
                    envioDto.FechaDoc = v.FechaDoc;
                    envioDto.FechaVenci = v.FechaVenci;
                    envioDto.CodCliente = v.CodCliente;
                    envioDto.NomCliente = v.NomCliente;
                    envioDto.DirCliente = v.DirCliente;
                    envioDto.TotalDoc = v.TotalDoc;
                    envioDto.Ref1 = v.Ref1;
                    envioDto.ExtraMonth = v.ExtraMonth;
                    envioDto.ExtraDays = v.ExtraDays;
                    envioDto.U_Tipo_Venta = v.U_Tipo_Venta;
                    envioDto.U_TipoNC = v.U_TipoNC;
                    envioDto.U_Cod_Sucursal = v.U_Cod_Sucursal;
                    envioDto.LineNum = v.LineNum;
                    envioDto.Quantity = v.Quantity;
                    envioDto.ItemCode = v.ItemCode;
                    envioDto.Dscription = v.Dscription;
                    envioDto.Price = v.Price;
                    envioDto.TotalSumSy = v.TotalSumSy;
                    envioDto.DiasCredito = v.DiasCredito;

                    listaEnvios.Add(envioDto);
                }

            }

            return listaEnvios;
        }
    }
}
