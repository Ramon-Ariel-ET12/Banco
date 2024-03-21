namespace Banco;
public class Cauto : IEstado
{
    public void Acreditar(Cliente cliente, double monto)
    {
        
    }

    public void Debitar(Cliente cliente, double monto)
    {
        throw new NotImplementedException();
    }

    public bool PuedeUsarme(Cliente cliente)
    {
        throw new NotImplementedException();
    }
}