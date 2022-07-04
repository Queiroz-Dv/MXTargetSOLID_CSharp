class ContaCorrente : Conta
{
  public double Limite { get; set; }

  public double DescontoJuros(double valorDesconto) => Saldo - valorDesconto;
}