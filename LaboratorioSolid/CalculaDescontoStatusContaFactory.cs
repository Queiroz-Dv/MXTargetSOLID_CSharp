namespace MXTargetBank.LaboratorioSolid
{
  public class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
  {
    public ICalculaDescontoStatusConta GetCalculoDescontoStatuConta(EStatusContaCliente statusContaCliente)
    {
      ICalculaDescontoStatusConta calcular = statusContaCliente switch
      {
        EStatusContaCliente.NaoRegistrado => new ClienteNaoRegistrado(),
        EStatusContaCliente.ClienteComum => new ClienteComum(),
        EStatusContaCliente.ClienteEspecial => new ClienteEspecial(),
        EStatusContaCliente.ClienteVIP => new ClienteVIP(),
        _ => throw new NotImplementedException(),
      };
      return calcular;
    }
  }
}