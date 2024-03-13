using System.Xml;

namespace Biblioteca
{
    public class Cuenta
    {
        // Se sabe que cada cliente tiene una cuenta y de la cuenta interesa su CBU (número de identificación entero único por cuenta) saldo.
        public int CBU { get; set; }
        public int Saldo { get; set; }
        public Cuenta (int cbu, int saldo) 
        =>  (CBU, Saldo) = (cbu, saldo);
    }
}