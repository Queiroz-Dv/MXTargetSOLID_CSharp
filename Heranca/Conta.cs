class Conta
{
  public int Numero { get; set; }
  public string? Titular { get; set; }
  public double Saldo { get; set; }

  public double Saque(double valorSaque) => Saldo - valorSaque;

  public double Deposito(double valorDeposito) => Saldo + valorDeposito;
}
