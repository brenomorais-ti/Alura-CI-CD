using Services;

namespace Imc.Tests;

public class ImcServiceTests
{
    [Fact]
    public void Deve_Calcular_IMC_Corretamente()
    {
        var service = new ImcService();

        double peso = 70;
        double altura = 1.75;

        var imc = service.Calcular(peso, altura);

        Assert.Equal(22.86, imc);
    }

    [Fact]
    public void Deve_Lancar_Erro_Para_Valores_Invalidos()
    {
        var service = new ImcService();

        Assert.Throws<ArgumentException>(() => service.Calcular(0, 1.75));
        Assert.Throws<ArgumentException>(() => service.Calcular(70, 0));
    }
}