class ContaPoupanca : Conta
{
  public DateTime DataAniversario { get; set; }
  public double CreditoJuros(double valorJuros) => Saldo + valorJuros;
}