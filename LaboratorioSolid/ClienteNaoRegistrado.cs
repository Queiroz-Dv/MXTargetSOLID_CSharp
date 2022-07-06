namespace MXTargetBank.LaboratorioSolid
{
  public class ClienteNaoRegistrado : ICalculaDescontoStatusConta
  {
    public decimal AplicarDescontoStatusConta(decimal preco)
    {
      return preco;
    }
  }
}