namespace MXTargetBank.SOLID.SRP
{
  public class RegistraLog : ILogger
  {
    public void Info(string info)
    {
      Console.WriteLine(info);
    }
  }
}