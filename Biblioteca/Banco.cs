namespace Biblioteca;

public class Banco
{
    public List<Cliente> clientes { get; set; }
    public Banco () =>  clientes = new List<Cliente>();
}
