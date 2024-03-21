namespace Banco;
public class Ahorrista : IEstado
{
//Ahorrista: Cuando el cliente posee más de $50.000 en efectivo, cada incremento de dinero va “50 y 50” entre su efectivo y su cuenta. Todos los gastos que hace el cliente, se desprenden primero de su efectivo y luego de su cuenta en casa de ser necesario.

    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.Efectivo -= monto;
        cliente.Cuenta.Saldo += monto * 0.5;
    }

    public void Debitar(Cliente cliente, double monto)
    {
        cliente.Efectivo += monto * 0.5;
        cliente.Cuenta.Saldo -= monto;
    }

    public bool PuedeUsarme(Cliente cliente) => cliente.Efectivo > 50000 ;
}