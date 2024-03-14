namespace Biblioteca;
public class Cliente : Interface
{
    //De sus clientes nombre, apellido y saldo en efectivo.
    public int Dni { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public double Efectivo { get; set; }
    public Cuenta Cuenta { get; set; }
    public Cliente (int dni, string nombre, string apellido, double efectivo, Cuenta cuenta) 
    =>  (Dni, Nombre, Apellido, Efectivo, Cuenta) = (dni, nombre, apellido, efectivo, cuenta);


#region 'debitar y acreditar'
    public void Acreditar(double monto, int cbu)
    {
        double restante = monto * 0.2;
        monto = monto * 0.8;
        if (monto >= Efectivo)
        {
            Cuenta.Saldo = monto + Cuenta.Saldo;
            Efectivo = restante - Efectivo;
        }
        else
        {
            throw new InvalidOperationException("El monto ingresado es menor al efectivo que posees :v");
        }
    }

    public void Debitar(double monto, int cbu)
    {
        double restante = monto * 0.2;
        monto = monto * 0.8;
        if (monto >= Cuenta.Saldo)
        {
            Efectivo = monto + Efectivo;
            Cuenta.Saldo = restante - Cuenta.Saldo;
        }
        else
        {
        throw new InvalidOperationException("El monto ingresado es menor al saldo que posees :v");
        }
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
#region 'nose'

    //Emergencia: Cuando un cliente tiene menos de $10.000 (en efectivo) todo incremento de dinero lo almacena en su efectivo y cada débito, primero intenta usar el saldo de su cuenta y después su efectivo.
    public void Emergencia(double incremento)
    {
        if (Efectivo < 10000)
        {
            Efectivo += incremento;
            Cuenta.Saldo += incremento;
        }
    }
//Cauto: Cuando el cliente tiene entre $10.000 y $50.000 en efectivo, todo incremento y disminución de dinero tiene una proporción de 80% efectivo y 20% cuenta. 

    public void Cauto(double incremento)
    {
        if (Efectivo >= 10000 && Efectivo <= 50000)
        {
            Efectivo += incremento * 0.8;
            Cuenta.Saldo -= incremento * 0.2;
        }
    }
//Ahorrista: Cuando el cliente posee más de $50.000 en efectivo, cada incremento de dinero va “50 y 50” entre su efectivo y su cuenta. Todos los gastos que hace el cliente, se desprenden primero de su efectivo y luego de su cuenta en casa de ser necesario.

    public void Ahorrista(double incremento)
    {
        if (Efectivo > 50000)
        {
            Efectivo += incremento * 0.5;
            Cuenta.Saldo += incremento * 0.5;
        }
    }
#endregion
}