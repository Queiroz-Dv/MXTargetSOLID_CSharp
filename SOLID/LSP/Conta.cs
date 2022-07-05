namespace MXTargetBank.SOLID.LSP
{
  public class Conta
  {
    public double Saldo { get; set; }
    public virtual void Saque(double valor)
    {
      Saldo -= valor;
    }
  }
}