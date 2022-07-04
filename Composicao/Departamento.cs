class Departamento : IDisposable
{
  private Escola escola;
  internal Departamento(Escola escola, string nome)
  {
    this.escola = escola;
    Nome = nome;
  }
public string? Nome { get; set; }
public List<Professor> Professores { get; set; }

  public void Dispose()
  {
      // Destroi departamento
  }
}