namespace Application.UnitTest;

public class UnitTestApplication
{
    [Theory]
    [InlineData(5, 10, 6, 26)]
    [InlineData(3, 4, 2, 12)]
    [InlineData(4, 8, 6, 22)]
    [InlineData(10, 20, 10, 50)]
    [InlineData(6, 12, 8, 32)]
    [InlineData(2, 3, 1, 8)]
    [InlineData(7, 5, 5, 24)]
    [InlineData(15, 20, 10, 60)]
    [InlineData(1, 2, 1, 5)]
    [InlineData(2.5, 5, 3, 13)]
    [InlineData(50, 100, 50, 250)]
    [InlineData(10, 5, 15, 40)]
    [InlineData(8, 10, 6, 32)]
    [InlineData(12, 24, 12, 60)]
    [InlineData(5, 5, 5, 20)]
    [InlineData(9, 10, 2, 30)]
    [InlineData(3.5, 4, 2, 13)]
    [InlineData(20, 30, 20, 90)]
    [InlineData(4, 1, 1, 10)]
    [InlineData(11, 22, 11, 55)]
    public void TestPerimetro(double lado, double BaseMayor, double BaseMenor, double Perimetro)
    {
        // Arrange - Set up

        // Act - Perform
        double resultado = Application.Figura261E05.Perimetro(lado, BaseMenor, BaseMayor);
        // Assert - Verify
        Assert.Equal(resultado, Perimetro);

    }

[Theory]
    [InlineData(4, 10, 6, 32)]
    [InlineData(3, 4, 2, 9)]
    [InlineData(5, 8, 6, 35)]
    [InlineData(10, 20, 10, 150)]
    [InlineData(6, 12, 8, 60)]
    [InlineData(2, 3, 1, 4)]
    [InlineData(4, 5, 5, 20)]
    [InlineData(5, 8, 12, 50)]
    [InlineData(1, 2, 1, 1.5)]
    [InlineData(5, 5, 3, 20)]
    [InlineData(20, 100, 50, 1500)]
    [InlineData(10, 5, 15, 100)]
    [InlineData(6, 10, 6, 48)]
    [InlineData(12, 24, 12, 216)]
    [InlineData(5, 10, 16, 65)]
    [InlineData(5, 10, 2, 30)]
    [InlineData(4, 4, 2, 12)]
    [InlineData(10, 30, 20, 250)]
    [InlineData(2, 1, 1, 2)]
    [InlineData(11, 22, 11, 181.5)]
    public void TestArea(double altura, double BaseMenor, double BaseMayor, double Area)
    {
        // Arrange – Set up

        // Act – Perform
        double resultado = Application.Figura261E05.Area(( BaseMenor +  BaseMayor) / 2) * altura;

        // Assert – Verify
        Assert.Equal(Area, resultado);
    }
}