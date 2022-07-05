namespace MXTargetBank.SOLID.DIP
{
  public class RecuperarSenha
  {
    //Começa a depender da asbtração
    private readonly IDataBaseConnection _connectionBase;
    public RecuperarSenha(IDataBaseConnection connection) => _connectionBase = connection;
  }
}