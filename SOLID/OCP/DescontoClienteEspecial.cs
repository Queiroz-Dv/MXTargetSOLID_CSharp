namespace MXTargetBank.SOLID.OCP
{
  public class DescontoClienteEspecial : Pedido
    {
        public override double DescontoPedido(double valorFinal) => valorFinal - 50;
    }
}