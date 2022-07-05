namespace MXTargetBank.SOLID.ISP
{
  public class CadastrarProduto : IPersistencia
  {
     public void ValidarDados()
    {
      Console.WriteLine("Validar dados");
    }

    public void Salvar()
    {
      Console.WriteLine("Salvar Dados");
    }
  }
}