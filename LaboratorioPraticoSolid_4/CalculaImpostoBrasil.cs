namespace MXTargetBank.LaboratorioPraticoSolid_4
{
  public class CalculaImpostoBrasil : ICalcularImpostoPais
  {
    public decimal TotalRenda { get; set; }
    public decimal TotalReducao { get; set; }

    public decimal CalcularValorImposto()
    {
      decimal valorBase = TotalRenda - TotalReducao;
      return valorBase * 20 / 100;
    }
  }
}