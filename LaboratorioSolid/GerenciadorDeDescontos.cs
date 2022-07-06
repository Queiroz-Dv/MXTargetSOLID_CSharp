namespace MXTargetBank.LaboratorioSolid
{
  //Código com nomenclatura errada
  public class GerenciadorDeDescontos
  {
    public static decimal AplicarDesconto(decimal preco, EStatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
    {
      decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE) ?
        (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100 :
        (decimal)tempoDeContaEmAnos / 100;


      decimal precoDepoisDoDesconto;
      switch (statusContaCliente)
      {
        case EStatusContaCliente.NaoRegistrado:
          precoDepoisDoDesconto = preco;
          break;

        case EStatusContaCliente.ClienteComum:
          precoDepoisDoDesconto = preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco);
          precoDepoisDoDesconto -= descontoPorFidelidade * precoDepoisDoDesconto;
          break;

        case EStatusContaCliente.ClienteEspecial:
          precoDepoisDoDesconto = preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco);
          precoDepoisDoDesconto -= descontoPorFidelidade * precoDepoisDoDesconto;
          break;

        case EStatusContaCliente.ClienteVIP:
          precoDepoisDoDesconto = preco - (Constantes.DESCONTO_CLIENTE_VIP * preco);
          precoDepoisDoDesconto -= descontoPorFidelidade * precoDepoisDoDesconto;
          break;

        default:
          throw new NotImplementedException();
      }
      return precoDepoisDoDesconto;
    }
  }
}