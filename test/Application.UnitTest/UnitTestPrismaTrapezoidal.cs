namespace Application.UnitTest;

public class UnitTestPrismaTrapezoidal
{
    [Theory]
    [InlineData(32, 10, 320)]
    [InlineData(9, 2, 18)]
    [InlineData(35, 2, 70)]
    [InlineData(150, 2, 300)]
    [InlineData(60, 5, 300)]
    [InlineData(4, 10, 40)]
    [InlineData(20, 5, 100)]
    [InlineData(150, 1, 150)]
    [InlineData(1.5, 10, 15)]
    [InlineData(20, 2, 40)]
    [InlineData(1500, 1, 1500)]
    [InlineData(100, 2, 200)]
    [InlineData(48, 10, 480)]
    [InlineData(216, 2, 432)]
    [InlineData(20, 10, 200)]
    [InlineData(30, 2, 60)]
    [InlineData(12, 5, 60)]
    [InlineData(250, 2, 500)]
    [InlineData(2, 50, 100)]
    [InlineData(181.5, 2, 363)]
    public void TestVolumen(double Area, double alturaprisma, double Volumen)
    {
        // Arrange – Set up


        // Act – Perform
        double resultado = Application.Figura261E05.Volumen(Area, alturaprisma);
        
        // Assert – Verify
        Assert.Equal(resultado, Volumen);
    }
}