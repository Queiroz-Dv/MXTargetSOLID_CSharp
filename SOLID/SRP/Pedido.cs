using MXTargetBank.SOLID.SRP;

class Pedido
{
  private readonly ILogger _infoLogger;
  private readonly EnviarEmail _enviarEmail;

  public Pedido()
  {
    _enviarEmail = new EnviarEmail();
    _infoLogger = new RegistraLog();
  }

  public Pedido(long quantidade, DateTime data, EnviarEmail enviarEmail, RegistraLog logger)
  {
    Quantidade = quantidade;
    Data = data;
    _enviarEmail = enviarEmail;
    _infoLogger = logger;
  }

  public long Quantidade { get; private set; }
  public DateTime Data { get; private set; }

  public void IncluirPedido()
  {
    try
    {
      _infoLogger.Info("Incluindo pedido");
      var from = _enviarEmail.EmailFrom = "emailfrom@xyz.com";
      var to = _enviarEmail.EmailTo = "emailfrom@xyz.com";
      var subject = _enviarEmail.EmailSubject = "SRP";
      var body = _enviarEmail.EmailBody = "Um";
      EnviarEmail.Enviar(from, to, body, subject);
    }
    catch (Exception ex)
    {
      _infoLogger.Info("Erro ao enviar o email do seu pedido: " + ex.Message);
    }
  }

  public void DeletaPedido()
  {
    try
    {
      //Código que deleta o pedido
      _infoLogger.Info("Pedido deletado em " + DateTime.Now);
    }
    catch (Exception ex)
    {
      _infoLogger.Info("Erro ao deletar pedido" + ex.Message);
    }
  }
}