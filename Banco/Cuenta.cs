namespace Banco;
public class Cuenta
{
    // Se sabe que cada cliente tiene una cuenta y de la cuenta interesa su CBU (número de identificación entero único por cuenta) saldo.
    private static int _contador = 0;
    public int CBU { get; set; }
    public double Saldo = 0;
    public Cuenta(double saldo)
    {
        CBU = ++_contador;
        Saldo = saldo;
    }
    public void Acreditar(double monto) => Saldo += monto;
    public void Debitar(double monto) => Saldo -= monto;
}