using System.Text;

namespace MXTargetBank.LaboratorioPraticoSolid
{
  public class ExportarDados : IExportacao
  {
    public string Exportar(List<Cliente> dados)
    {
      StringBuilder sb = new();
      foreach (var item in dados)
      {
        sb.AppendFormat($"{item.Nome}, {item.Pais}, {item.Email}");
        sb.AppendLine();
      }
      return sb.ToString();
    }
  }
}