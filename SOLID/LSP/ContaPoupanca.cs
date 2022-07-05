namespace MXTargetBank.SOLID.LSP
{
  public class ContaPoupanca : Conta
  {
    public override void Saque(double valor)
    {
      if (Saldo > valor)
        Saldo -= valor;
      
    }
  }
}