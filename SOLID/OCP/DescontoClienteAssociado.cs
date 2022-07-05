namespace MXTargetBank.SOLID.OCP
{
  public class DescontoClienteAssociado : Pedido
  {
    public override double DescontoPedido(double valorFinal) => valorFinal - 10;
  }
}