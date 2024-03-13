namespace Biblioteca
{
    public class Cliente
    {
        //De sus clientes nombre, apellido y saldo en efectivo.
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Saldo { get; set; }
        public List<Cuenta> cuentas { get; set; }
        public Cliente (int dni, string nombre, string apellido, int saldo) 
        =>  (Dni, Nombre, Apellido, Saldo, cuentas) = (dni, nombre, apellido, saldo, new List<Cuenta>());
    }
}