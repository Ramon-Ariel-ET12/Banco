namespace Biblioteca;

public class Banco
{
    public List<Cliente> clientes { get; set; }
    public Banco () =>  clientes = new List<Cliente>();

    #region 'registrarCliente'
    public void RegistrarCliente(Cliente cliente)
    {
        foreach (var i in clientes)
        {
            if (i.Dni != cliente.Dni)
            {
                throw new InvalidOperationException("el DNI " + cliente.Dni + " ya está en uso");
            }
        }
        clientes.Add(cliente);
    }
    #endregion

}
