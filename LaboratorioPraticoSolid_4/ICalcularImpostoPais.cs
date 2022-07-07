namespace MXTargetBank.LaboratorioPraticoSolid_4
{
  public interface ICalcularImpostoPais
    {
        decimal TotalRenda { get; set; }
        decimal TotalReducao { get; set; }
        decimal CalcularValorImposto();
    }
}