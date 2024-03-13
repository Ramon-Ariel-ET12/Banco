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


}