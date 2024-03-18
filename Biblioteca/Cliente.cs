namespace Biblioteca;
public class Cliente
{
    //De sus clientes nombre, apellido y saldo en efectivo.
    public int Dni { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public double Efectivo { get; set; }
    public Cuenta Cuenta { get; set; }
    public Cliente (int dni, string nombre, string apellido, double efectivo, Cuenta cuenta) 
    =>  (Dni, Nombre, Apellido, Efectivo, Cuenta) = (dni, nombre, apellido, efectivo, cuenta);

    // Tanto el cliente como la cuenta pueden debitar (restar a saldo) y acreditar (sumar a su saldo) un monto determinado.
    // Tanto del cliente como de la cuenta, importa también si se le puede debitar un determinado monto.
    // Cuando un cliente acredite un monto, el 80% lo almacena en efectivo y el 20% restante lo almacena en su cuenta.
    // Cuando un cliente debite un monto, el 80% lo debita de su efectivo y el 20% restante de su cuenta.
    #region 'debitar y acreditar'
    public void Acreditar(double monto, int cbu)
    {
        if (monto >= Efectivo)
        {
            Cuenta.Saldo = Cuenta.Saldo + monto * 0.8;
            Efectivo = Efectivo - restante * 0.2;
        }
        else
        {
            throw new InvalidOperationException("El monto ingresado es menor al efectivo que posees :v");
        }
    }

    public void Debitar(double monto, int cbu)
    {
        if (monto >= Cuenta.Saldo)
        {
            Efectivo = Efectivo + monto * 0.8;
            Cuenta.Saldo = Cuenta.Saldo - monto * 0.2;
        }
        else
        {
        throw new InvalidOperationException("El monto ingresado es menor al saldo que posees :v");
        }
    }
    #endregion

    //Como cada cliente solo tiene una cuenta, debe poder devolver el CBU de la misma.
    //Tanto el cliente como la cuenta tienen que poder devolver el saldo. 
    //En el caso del cliente este se calcula como el dinero que posee en efectivo más el saldo de su cuenta.

    #region 'consultar'
    
    public int DevolverCBU(int dni)
    {
        int cbu;
        cbu = Cuenta.CBU;
        return cbu;
    }

    public double DevolverSaldo(int dni)
    {
        double efectivo = Efectivo;
        double saldo = Cuenta.Saldo;
        double total = efectivo + saldo;
        return total;
    }

    #endregion
}