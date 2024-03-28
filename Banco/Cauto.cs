namespace Banco;
public class Cauto : IEstado
{
    //Cauto: Cuando el cliente tiene entre $10.000 y $50.000 en efectivo, todo incremento y disminución de dinero tiene una proporción de 80% efectivo y 20% cuenta. 
    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.Cuenta.AcreditarSueldo(monto * .2);
        cliente.AcreditarEfectivo(monto * .8);
    }

    public void Debitar(Cliente cliente, double monto)
    {
        if (cliente.Efectivo < monto * .8 && cliente.Cuenta.Saldo < monto * .2)
        {
            throw new InvalidOperationException("El monto ingresado es mayor al saldo o el efectivo que posees (CAUTO) :v");
        }
        cliente.DebitarEfectivo(monto * .8);
        cliente.Cuenta.DebitarSueldo(monto * .2);
    }

    public bool PuedeUsarme(Cliente cliente) => cliente.Efectivo <= 50000 && cliente.Efectivo >= 10000;
}