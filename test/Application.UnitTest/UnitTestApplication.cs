namespace Application.IntegrationTest;

public class IntegrationTestApplication
{
    [Theory]
    [InlineData(4, 4, 4, 50)]
    [InlineData(5, 5, 5, 100)]
    [InlineData(6, 6, 6, 150)]
    [InlineData(7, 7, 7, 200)]
    [InlineData(8, 8, 8, 250)]
    [InlineData(9, 9, 9, 300)]
    [InlineData(10, 10, 10, 350)]
    [InlineData(11, 11, 11, 400)]
    [InlineData(12, 12, 12, 450)]
    [InlineData(13, 13, 13, 500)]
    [InlineData(14, 14, 14, 550)]
    [InlineData(15, 15, 15, 600)]
    [InlineData(16, 16, 16, 650)]
    [InlineData(17, 17, 17, 700)]
    [InlineData(18, 18, 18, 750)]
    [InlineData(19, 19, 19, 800)]
    [InlineData(20, 20, 20, 850)]
    [InlineData(22, 22, 22, 900)]
    [InlineData(23, 23, 23, 950)]
    [InlineData(24, 24, 24, 1000)]
    public void TestVolumen(double BaseMenor, double BaseMayor, double altura, double Volumen)
    {
        // Arrange - Set up
        
        // Act - Perform
        double resultado = Application.Figura261E05.Volumen(area, altura);
        // Assert - Verify
        Assert.Equal(resultado, Volumen);

    }
}
