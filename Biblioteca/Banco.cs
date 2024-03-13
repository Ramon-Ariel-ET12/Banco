namespace Biblioteca;

public class Banco
{
    public List<Cliente> clientes { get; set; }
    //Como cada cliente solo tiene una cuenta, debe poder devolver el CBU de la misma.
    //Tanto el cliente como la cuenta tienen que poder devolver el saldo. En el caso del cliente este se calcula como el dinero que posee en efectivo más el saldo de su cuenta.
    public Banco () 
    =>  clientes = new List<Cliente>();

    //Tanto el cliente como la cuenta pueden debitar (restar a saldo) y acreditar (sumar a su saldo) un monto determinado.
    //Tanto del cliente como de la cuenta, importa también si se le puede debitar un determinado monto.
    //Cuando un cliente acredite un monto, el 80% lo almacena en efectivo y el 20% restante lo almacena en su cuenta.
    //Cuando un cliente debite un monto, el 80% lo debita de su efectivo y el 20% restante de su cuenta.
    #region 'debitar y acreditar'
    public void Acreditar(int monto, int cbu)
    {
        foreach (var i in clientes )
        {
            if (i.Cuenta.CBU == cbu && monto >= i.Efectivo)
            {
            i.Cuenta.Saldo = monto + i.Cuenta.Saldo;
            i.Efectivo = monto - i.Efectivo;
            }
        }
    }

    public void Debitar(int monto, int cbu)
    {
        foreach (var i in clientes )
        {
            if (i.Cuenta.CBU == cbu && monto >= i.Efectivo)
            {
            i.Efectivo = monto + i.Efectivo;
            i.Cuenta.Saldo = monto - i.Cuenta.Saldo;
            }
        }
    }
    #endregion

}
