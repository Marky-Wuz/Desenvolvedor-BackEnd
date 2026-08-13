//Declaração de variaveis

using app1;

double Largura;
double Altura;
double Base;
double Perimetro;
double Diagonal;
double Ar;

// entrada de dados
Console.Write("Digite o valor da Largura do Retangulo: ");
Largura = double.Parse(Console.ReadLine());
Console.Write("Digite o valor da Altura do Retangulo: ");
Altura = double.Parse(Console.ReadLine());





Retangulo objeto = new Retangulo(Largura, Altura);

objeto.ExibirDados();

