namespace Banco;
public class Ahorrista : IEstado
{
    public void Acreditar(Cliente cliente, double monto)
    {
        throw new NotImplementedException();
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