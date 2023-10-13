using ExercicioClasseRetangulo;

Console.WriteLine("Entre a largura e altura do retângulo:");
Retangulo retangulo = new Retangulo();

retangulo.Largura = double.Parse(Console.ReadLine());
retangulo.Altura = double.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Area = {retangulo.Area()}");
Console.WriteLine($"Perimetro = {retangulo.Perimetro()}");
Console.WriteLine($"Diagonal = {retangulo.Diagonal()}");