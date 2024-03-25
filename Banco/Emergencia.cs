namespace Banco;
public class Emergencia : IEstado
{
    //Emergencia: Cuando un cliente tiene menos de $10.000 (en efectivo) todo incremento de dinero lo almacena en su efectivo y cada débito, primero intenta usar el saldo de su cuenta y después su efectivo.
    public void Acreditar(Cliente cliente, double monto)
    {
        cliente.AcreditarEfectivo(monto);
        cliente.Cuenta.Acreditar(monto);
    }

    public void Debitar(Cliente cliente, double monto)
    {
        cliente.DebitarEfectivo(monto);
        cliente.Cuenta.Debitar(monto);
    }

    public bool PuedeUsarme(Cliente cliente) => cliente.Efectivo < 10000 ;
}