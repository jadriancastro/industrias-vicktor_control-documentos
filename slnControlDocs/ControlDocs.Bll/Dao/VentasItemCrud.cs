using ControlDocs.Dao;
using ControlDocs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDocs.Bll.Dao
{
    public class VentasItemCrud
    {
        public List<VentasItemDto> Obtener()
        {
            List<VentasItemDto> envios = new List<VentasItemDto>();

            using (Viktor2Entities contex = new Viktor2Entities())
            {
                List<VentasporItem> lista = (from x in contex.VentasporItem
                                             select x).ToList<VentasporItem>();

                foreach (VentasporItem v in lista)
                {
                    VentasItemDto envioDto = new VentasItemDto();

                    envioDto.DocNum = v.DocNum;
                    envioDto.DocType = v.DocType;
                    envioDto.DocDate = v.DocDate;
                    envioDto.CardCode = v.CardCode;
                    envioDto.CardName = v.CardName;
                    envioDto.LineNum = v.LineNum;
                    envioDto.ItemCode = v.ItemCode;
                    envioDto.Dscription = v.Dscription;
                    envioDto.Quantity = v.Quantity;
                    envioDto.U_Cod_Sucursal = v.U_Cod_Sucursal;
                    envioDto.WhsCode = v.WhsCode;
                    envioDto.Price = v.Price;
                    envioDto.TotalSumSy = v.TotalSumSy;
                    envioDto.U_Cod_Marca = v.U_Cod_Marca;
                    envioDto.u_talla = v.u_talla;
                    envioDto.U_Cod_Subfam = v.U_Cod_Subfam;
                    envioDto.U_Cod_Tipo = v.U_Cod_Tipo;
                    envioDto.U_Color = v.U_Color;
                    envioDto.U_Descripcion = v.U_Descripcion;
                    envioDto.U_Estilo = v.U_Estilo;
                    envioDto.U_Limite = v.U_Limite;
                    envioDto.U_Maximo = v.U_Maximo;
                    envioDto.U_Mayor = v.U_Mayor;
                    envioDto.minlevel = v.minlevel;
                    envioDto.MaxLevel = v.MaxLevel;
                    envioDto.slpcode = v.slpcode;

                    envios.Add(envioDto);
                }

            }

            return envios;
        }
    }
}
