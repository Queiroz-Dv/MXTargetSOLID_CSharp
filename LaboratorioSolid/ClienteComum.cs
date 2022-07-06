namespace MXTargetBank.LaboratorioSolid
{
  public class ClienteComum : ICalculaDescontoStatusConta
  {
    public decimal AplicarDescontoStatusConta(decimal preco)
    {
     return preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco);
    }
  }
}