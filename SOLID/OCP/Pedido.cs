using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MXTargetBank.SOLID.OCP
{
  public enum TipoCliente
  {
    Comum,
    Associado,
    Especial
  }

  public class Pedido
  {
    // ...algum código

    public virtual double DescontoPedido(double valor, TipoCliente tipoCliente)
    {
      double valorFinal;

      if (tipoCliente == TipoCliente.Especial)
      {
        valorFinal = valor - 50;
      }
      else if (tipoCliente == TipoCliente.Associado)
      {
        valorFinal = valor - 10;
      }
      else
      {
        valorFinal = valor;
      }
      return valorFinal;
    }
  }
}