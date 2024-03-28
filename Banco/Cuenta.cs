namespace Banco;
public class Cuenta
{
    // Se sabe que cada cliente tiene una cuenta y de la cuenta interesa su CBU (número de identificación entero único por cuenta) saldo.
    private static int _contador = 0;
    public int CBU { get; set; }
    public double Saldo { get; set; }
    public Cuenta(double saldo) 
        => (CBU, Saldo) = (++_contador, saldo);
    
    public void AcreditarSueldo(double monto) => Saldo += monto;
    public void DebitarSueldo(double monto) => Saldo -= monto;
}