namespace MXTargetBank.LaboratorioPraticoSolid_3
{
  public class FileLogger : ILogger
  {
    public void Registrar(string mensagem)
    {
      File.WriteAllText(@"c:\PerfLogs\logg.txt", mensagem);
    }
  }
}