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
          precoDepoisDoDesconto = new ClienteNaoRegistrado().AplicarDescontoStatusConta(preco);
          precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
          break;

        case EStatusContaCliente.ClienteComum:
          precoDepoisDoDesconto = new ClienteComum().AplicarDescontoStatusConta(preco);
          precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
          break;

        case EStatusContaCliente.ClienteEspecial:
          precoDepoisDoDesconto = new ClienteEspecial().AplicarDescontoStatusConta(preco);
          precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
          break;

        case EStatusContaCliente.ClienteVIP:
          precoDepoisDoDesconto = new ClienteVIP().AplicarDescontoStatusConta(preco);
          precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
          break;

        default:
          throw new NotImplementedException();
      }
      return precoDepoisDoDesconto;
    }
  }
}