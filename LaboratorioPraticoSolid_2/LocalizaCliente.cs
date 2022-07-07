using System.Text;

namespace MXTargetBank.LaboratorioPraticoSolid
{
  public class LocalizaCliente : ILocaliza
  {
    public Cliente ProcuraPorPais(string pais)
    {
      var resultado = Cliente.GetClientes().Find(n => n.Pais == pais);
      return resultado;
    }

    public Cliente ProcuraPorNome(string nome)
    {
      var resultado = Cliente.GetClientes().Find(n => n.Nome == nome);
      return resultado;
    }
  }
}