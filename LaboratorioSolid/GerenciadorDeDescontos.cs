namespace MXTargetBank.LaboratorioSolid
{
  public class GerenciadorDeDescontos
  {
    private readonly ICalculaDescontoFidelidade descontoFidelidade;

    public GerenciadorDeDescontos(ICalculaDescontoFidelidade _descontoFidelidade)
    {
      descontoFidelidade = _descontoFidelidade;
    }

    public decimal AplicarDesconto(decimal preco, EStatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
    {
      decimal precoDepoisDoDesconto;
      switch (statusContaCliente)
      {
        case EStatusContaCliente.NaoRegistrado:
          precoDepoisDoDesconto = preco;
          break;

        case EStatusContaCliente.ClienteComum:
          precoDepoisDoDesconto = preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco);
          precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
          break;

        case EStatusContaCliente.ClienteEspecial:
          precoDepoisDoDesconto = preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco);
          precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
          break;

        case EStatusContaCliente.ClienteVIP:
          precoDepoisDoDesconto = preco - (Constantes.DESCONTO_CLIENTE_VIP * preco);
          precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
          break;

        default:
          throw new NotImplementedException();
      }
      return precoDepoisDoDesconto;
    }
  }
}