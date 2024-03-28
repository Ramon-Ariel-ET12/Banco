namespace Banco;
public class Emergencia : IEstado
{
    //Emergencia: Cuando un cliente tiene menos de $10.000 (en efectivo) todo incremento de dinero lo almacena en su efectivo y cada débito, primero intenta usar el saldo de su cuenta y después su efectivo.
    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.AcreditarEfectivo(monto);
        cliente.Cuenta.AcreditarSueldo(monto);
    }

    public void Debitar(Cliente cliente, double monto)
    {
        if (cliente.Efectivo < monto && cliente.Cuenta.Saldo < monto)
        {
            throw new InvalidOperationException("El monto ingresado es mayor al saldo o el efectivo que posees (EMERGENCIA) :v");
        }
        cliente.DebitarEfectivo(monto);
        cliente.Cuenta.DebitarSueldo(monto);
    }

    public bool PuedeUsarme(Cliente cliente) => cliente.Efectivo < 10000 ;
}