namespace MXTargetBank.LaboratorioPraticoSolid_3
{
  public class Pedido
  {
    private readonly ILogger log;
    public Pedido(ILogger _log) // Aqui recebe a instância 
    {
      log = _log;
    }
    public virtual void AdicionarPedido()
    {
      try
      {
        log.Registrar($"Pedido incluido em: {DateTime.Now}");
      }
      catch (Exception ex)
      {
        log.Registrar($"{ex} - {DateTime.Now}");
      }
    }
  }
}