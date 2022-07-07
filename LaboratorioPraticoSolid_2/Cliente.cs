namespace MXTargetBank.LaboratorioPraticoSolid
{
  public class Cliente
  {
    public string? Nome { get; set; }
    public string? Pais { get; set; }
    public string? Email { get; set; }

    public static List<Cliente> GetClientes()
    {
      List<Cliente> listaClientes = new()
      {
            new Cliente
            {
              Nome ="Pedro Sobral",
              Pais="Brasil",
              Email="pedro.sobral@email.com"
            },
            new Cliente
            {
              Nome ="Amanda Lima",
              Pais="Argentina",
              Email="amanda.lima@email.com"
            }
        };
      return listaClientes;
    }
  }
}