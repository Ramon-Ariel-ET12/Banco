namespace Banco;
public interface IEstado
{
    void Acreditar(Cliente cliente, double monto);
    void Debitar(Cliente cliente, double monto);
    bool PuedeUsarme(Cliente cliente);
}