namespace MXTargetBank.LaboratorioPraticoSolid_3
{
  internal class ConsoleLogger : ILogger
  {
    public void Registrar(string mensagem)
    {
      Console.WriteLine(mensagem);
    }
  }
}