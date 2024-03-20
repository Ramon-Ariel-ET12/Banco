namespace Biblioteca;
public interface IEstrategia
{
    void Acreditar(Cliente cliente, double monto);
    void Debitar(Cliente cliente, double monto);
}