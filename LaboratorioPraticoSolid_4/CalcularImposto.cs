namespace MXTargetBank.LaboratorioPraticoSolid_4
{
  public class CalcularImposto
  {
    public decimal Calcular(ICalcularImpostoPais icalc)
    {
      return icalc.CalcularValorImposto();
    }
  }
}