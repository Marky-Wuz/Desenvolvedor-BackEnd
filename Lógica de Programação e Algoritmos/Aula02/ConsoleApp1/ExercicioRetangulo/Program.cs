//Declaração das variavies
double Base;
double Altura;
double Area;
double Perimetro;
double Diagonal;

// Entrada de dados
Console.Write("Digite o valor da base do retângulo: ");
Base = double.Parse(Console.ReadLine());
Console.Write("Digite o valor da altura do retângulo: ");
Altura = double.Parse(Console.ReadLine());

// Processamento de dados
Area = Base * Altura;
Perimetro = Base + Altura + Base + Altura;
Diagonal = Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));

// Saída de dados
Console.WriteLine($"--Dados do Retânulo--\n" +
                  $"Área: {Area.ToString("f4")}\n" +
                  $"Perímetro: {Perimetro:f4}\n" +
                  $"Diagonal: {Diagonal:n}\n");