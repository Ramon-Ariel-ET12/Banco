namespace Banco;
public class Cliente
{
    public int Dni { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public double Efectivo { get; set; }
    public IEstado Estado { get; set; }
    public Cuenta Cuenta { get; set; }
    public Cliente (int dni, string nombre, string apellido, double efectivo) 
    {
        (Dni, Nombre, Apellido, Efectivo) = (dni, nombre, apellido, efectivo);
        Cuenta = new Cuenta(0);
        Estados.AsignarEstado(this);
    }  

    public void AcreditarEfectivo(double monto) => Efectivo += monto;
    public void DebitarEfectivo(double monto) => Efectivo -= monto;


#region 'debitar y acreditar'

    public void Acreditar(double monto)
    {
        Estado.Acreditar(this, monto);
        Estados.AsignarEstado(this);
    }

    public void Debitar(double monto)
    {
        Estado.Debitar(this, monto);
        Estados.AsignarEstado(this);
    }
#endregion
#region 'consultar'
    
    public int DevolverCBU()
        => Cuenta.CBU;

    public double DevolverSaldo()
        => Efectivo + Cuenta.Saldo;
#endregion
}