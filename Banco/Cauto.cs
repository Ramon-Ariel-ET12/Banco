namespace Banco;
public class Cauto : IEstado
{
//Cauto: Cuando el cliente tiene entre $10.000 y $50.000 en efectivo, todo incremento y disminución de dinero tiene una proporción de 80% efectivo y 20% cuenta. 
    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.Cuenta.Saldo += monto * 0.8;
        cliente.Efectivo -= monto * 0.2;
    }

    public void Debitar(Cliente cliente, double monto)
    {
        cliente.Efectivo += monto * 0.8;
        cliente.Cuenta.Saldo -= monto * 0.2;
    }

    public bool PuedeUsarme(Cliente cliente) => cliente.Efectivo <= 50000 && cliente.Efectivo >= 10000 ;
}