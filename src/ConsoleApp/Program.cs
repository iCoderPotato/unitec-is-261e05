double lado = 5;
double BaseMenor = 10;
double BaseMayor = 20;
double altura = 3.6;
double Perimetro = Application.Figura261E05.Perimetro(lado, BaseMenor, BaseMayor);
double Area = Application.Figura261E05.Area(altura, BaseMenor, BaseMayor);
double Volumen = Application.Figura261E05.Volumen(Area, altura);

Console.WriteLine($"El perimetro de la base de un Trapecio de {lado}cm por lado, {BaseMenor}cm base menor y {BaseMayor}cm base mayor es: {Perimetro}cm");
Console.WriteLine($"El area de un Trapecio de {altura}cm de altura, {BaseMenor}cm base menor y {BaseMayor}cm base mayor es: {Area}cm²");
Console.WriteLine($"El volumen de un Trapecio con area de base {Area}cm² y {altura}cm de altura es: {Volumen}cm³");
