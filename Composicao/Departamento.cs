class Departamento : IDisposable
{
  private readonly Escola _escola;
  internal Departamento(Escola escola, string nome)
  {
    _escola = escola;
    Nome = nome;
  }
public string? Nome { get; set; }
public List<Professor>? Professores { get; set; }

  public void Dispose()
  {
      // Destroi departamento
  }
}