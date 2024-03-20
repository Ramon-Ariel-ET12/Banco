using Biblioteca;

namespace Banco;
public static class Estado
{
    private static List<IEstado> estados = new () {new Emergencia(), new Cauto(), new Ahorrista()} ;
    
    public static void AsignarEstado(Cliente cliente) => cliente.Estado = estados.First(e => e.PuedeUsarme(cliente));
}