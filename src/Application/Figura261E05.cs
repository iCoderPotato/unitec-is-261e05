namespace Application;

public class Figura261E05
{
    public static double Perimetro(double lado, double BaseMenor, double BaseMayor)
    {
        return (2 * lado) + BaseMenor + BaseMayor;
    }
    public static double Area(double altura, double BaseMenor, double BaseMayor)
    {
        return ((BaseMenor + BaseMayor) / 2) * altura;
    }
    public static double Volumen(double Area, double altura)
    {
        return Area * altura;
    }
}