class Escola : IDisposable
{
  public string? Nome { get; set; }
  private readonly List<Departamento> departamentos = new();

  public void AddDepartamentos(string nome)
  {
    departamentos.Add(new Departamento(this, nome));
  }

  public void Dispose()
  {
    foreach (var departamento in departamentos)
    {
      departamento.Dispose();
    }
  }
}