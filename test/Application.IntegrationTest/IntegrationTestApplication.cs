using Xunit;

namespace Application.IntegrationTest;

public class IntegrationTestApplication
{
    [Theory]
    [InlineData(4, 10, 6, 10, 320)]
    [InlineData(3, 4, 2, 2, 18)]
    [InlineData(5, 8, 6, 2, 70)]
    [InlineData(10, 20, 10, 2, 300)]
    [InlineData(6, 12, 8, 5, 300)]
    [InlineData(2, 3, 1, 10, 40)]
    [InlineData(4, 5, 5, 5, 100)]
    [InlineData(10, 20, 10, 1, 150)]
    [InlineData(1, 2, 1, 10, 15)]
    [InlineData(5, 5, 3, 2, 40)]
    [InlineData(20, 100, 50, 1, 1500)]
    [InlineData(10, 5, 15, 2, 200)]
    [InlineData(6, 10, 6, 10, 480)]
    [InlineData(12, 24, 12, 2, 432)]
    [InlineData(4, 5, 5, 10, 200)]
    [InlineData(5, 10, 2, 2, 60)]
    [InlineData(4, 4, 2, 5, 60)]
    [InlineData(10, 30, 20, 2, 500)]
    [InlineData(2, 1, 1, 50, 100)]
    [InlineData(11, 22, 11, 2, 363)]
    public void TestVolumen(double altura, double BaseMenor, double BaseMayor,double alturaprisma, double Volumen)
    {
        // Arrange - Set up
        double area = Application.Figura261E05.Area(altura, BaseMenor, BaseMayor);
        // Act - Perform
        double resultado = Application.Figura261E05.Volumen(Area, alturaprisma);
        // Assert - Verify
        Assert.Equal(resultado, Volumen);

    }
}
