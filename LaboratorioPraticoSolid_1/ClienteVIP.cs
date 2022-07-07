using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MXTargetBank.LaboratorioSolid
{
  public class ClienteVIP : ICalculaDescontoStatusConta
  {
    public decimal AplicarDescontoStatusConta(decimal preco)
    {
      return preco - (Constantes.DESCONTO_CLIENTE_VIP * preco);;
    }
  }
}