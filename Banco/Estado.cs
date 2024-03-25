namespace Banco;
public static class Estados
{
    private static readonly List<IEstado> estados
        = [
            new Emergencia(),
            new Cauto(),
            new Ahorrista()
        ];

    public static void AsignarEstado(Cliente cliente)
        => cliente.Estado = estados.First(e => e.PuedeUsarme(cliente));
}