namespace Banco;
public class Cliente
{
    public int Dni { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public double Efectivo { get; set; }
    public IEstado Estado { get; set; }
    public Cuenta Cuenta { get; set; }
    public Cliente (int dni, string nombre, string apellido, double efectivo, Cuenta cuenta) 
    =>  (Dni, Nombre, Apellido, Efectivo, Cuenta) = (dni, nombre, apellido, efectivo, cuenta);


#region 'debitar y acreditar'

    public void Acreditar(double monto)
    {
        if (monto < Efectivo)
        {
            throw new InvalidOperationException("El monto ingresado es menor al efectivo que posees :v");
        }

        Estado.Acreditar(this, monto);
        Estados.AsignarEstado(this);
    }

    public void Debitar(double monto)
    {
        if (monto < Cuenta.Saldo)
        {
        throw new InvalidOperationException("El monto ingresado es menor al saldo que posees :v");
        }

        Estado.Debitar(this, monto);
        Estados.AsignarEstado(this);
    }
#endregion
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