namespace MXTargetBank.LaboratorioSolid
{
  public class GerenciadorDeDescontos
  {
    private readonly ICalculaDescontoStatusContaFactory descontoStatusConta;
    private readonly ICalculaDescontoFidelidade descontoFidelidade;

    public GerenciadorDeDescontos(ICalculaDescontoStatusContaFactory _descontoStatusConta, ICalculaDescontoFidelidade _descontoFidelidade)
    {
      descontoStatusConta = _descontoStatusConta;
      descontoFidelidade = _descontoFidelidade;
    }

    public decimal AplicarDesconto(decimal preco, EStatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
    {
      decimal precoDepoisDoDesconto;

      precoDepoisDoDesconto = descontoStatusConta.GetCalculoDescontoStatuConta(statusContaCliente).AplicarDescontoStatusConta(preco);

      precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);

      return precoDepoisDoDesconto;
    }
  }
}