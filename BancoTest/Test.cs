namespace BancoTest;
using Banco;
public class Test
{
    private List<Cliente> clientes;
    public Test()
    {
        this.clientes = [];
    }

//Crear a Hijitus con $0 y acreditarle $3.000; verificar que tenga ahora $3.000 en efectivo; luego acreditarle $10.000 y verificar que tenga $13.000 en efectivo.
    [Fact]
    public void TestHijitus()
    {
        var hijitus = new Cliente(1, "Hijitus", "",0);

        hijitus.AcreditarEfectivo(3000);
        hijitus.AcreditarEfectivo(10000);

        Assert.Equal(13000, hijitus.Efectivo);
    }

//Crear a Neurus con $30.000 y acreditarle $10.000 verificando que luego tenga $38.000 en efectivo y que tenga $2.000 en su cuenta (además de que el saldo de la persona sea $40.000). Debitarle $5.000 y comprobar que su saldo es $35.000 de los cuales $34.000 son en efectivo y $1.000 en cuenta.
    [Fact]
    public void Neurus()
    {
        var neurus = new Cliente(2, "Neurus", "", 30000);

        neurus.Acreditar(10000);
        Assert.Equal(38000, neurus.Efectivo);
        neurus.Cuenta.Acreditar(38000);
        Assert.Equal(40000, neurus.Cuenta.Saldo);
    }

}

















