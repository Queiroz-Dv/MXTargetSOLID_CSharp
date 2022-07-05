namespace MXTargetBank.SOLID.ISP
{
  public class CadastrarCliente : IPersistencia, IEmailMessage
  {
    public void ValidarDados()
    {
      Console.WriteLine("Validar dados");
    }

    public void Salvar()
    {
      Console.WriteLine("Salvar Dados");
    }

    public void EnviarEmail()
    {
      Console.WriteLine("Enviando email");
    }
  }
}