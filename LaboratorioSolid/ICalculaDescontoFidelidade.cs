namespace MXTargetBank.LaboratorioSolid
{
  public interface ICalculaDescontoFidelidade
  {
    decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos);
  }
}