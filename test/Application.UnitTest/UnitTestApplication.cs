namespace Application.IntegrationTest;

public class IntegrationTestApplication
{
    [Theory]
    [InlineData(4, 4, 4, 50)]
    [InlineData(5, 5, 5, 100)]
    [InlineData(6, 6, 6, 150)]
    public void TestVolumen(double BaseMenor, double BaseMayor, double altura, double Volumen)
    {
        // Arrange - Set up
        
        // Act - Perform
        double resultado = Application.Figura261E05.Volumen(area, altura);
        // Assert - Verify
        Assert.Equal(resultado, Volumen);

    }
}
