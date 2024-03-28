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

        Assert.Equal(2000, neurus.Cuenta.Saldo);
       
        neurus.Debitar(5000);
        Assert.Equal(34000, neurus.Efectivo);
        Assert.Equal(1000, neurus.Cuenta.Saldo);
    }

//Crear a Gold Silver con $100.000 y acreditarle $100.000. Verificar que su saldo sea $200.000 con $150.000 en efectivo y $50.000 en su cuenta. Debitarle luego $30.000 y verificar que su saldo es $170.000 con $135.000 en efectivo y $35.000 en su cuenta.
    [Fact]
    public void GoldSilver()
    {
        var goldsilver = new Cliente(3, "GoldSilver", "", 100000);

        goldsilver.Acreditar(100000);
        Assert.Equal(150000, goldsilver.Efectivo);
        Assert.Equal(50000, goldsilver.Cuenta.Saldo);
        
        goldsilver.Debitar(30000);
        Assert.Equal(135000, goldsilver.Efectivo);
        Assert.Equal(35000, goldsilver.Cuenta.Saldo);
    }
}

















