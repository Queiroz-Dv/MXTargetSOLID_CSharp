namespace MXTargetBank.LaboratorioPraticoSolid_4
{
  public class CalculaImpostoArgentina : ICalcularImpostoPais
  {
    public decimal TotalRenda { get; set; }
    public decimal TotalReducao { get; set; }

    public decimal CalcularValorImposto()
    {
      decimal valorBase = TotalRenda - TotalReducao;
      return valorBase * 40 / 100;
    }
  }
}