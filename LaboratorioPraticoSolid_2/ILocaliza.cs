namespace MXTargetBank.LaboratorioPraticoSolid
{
  public interface ILocaliza
    {
        Cliente ProcuraPorPais(string pais);
        Cliente ProcuraPorNome(string nome);
    }
}