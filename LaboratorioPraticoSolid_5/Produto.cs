namespace MXTargetBank.LaboratorioPraticoSolid_5
{
  public abstract class Produto
  {
    public string? Nome { get; set; }
    public decimal Preco { get; set; }

    protected IPromocao promocao;

    protected Produto(IPromocao _promocao)
    {
      promocao = _promocao;
    }

    public decimal DescontoPromocao()
    {
      return promocao.Desconto();
    }

    public decimal PrecoVenda()
    {
        return Preco - (Preco* DescontoPromocao());
    }
  }
}