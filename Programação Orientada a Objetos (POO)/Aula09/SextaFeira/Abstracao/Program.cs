using Abstracao.Classes.Entidades;
using Abstracao.Enumeracoes;

List<Forma> formas = new();

Console.Write("Quantas formas geometricas quer digitar? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Dados da forma # " + (i+1));
    Console.Write("Retangulo ou Circulo? (R/C) ");
    char escolha = char.Parse(Console.ReadLine().ToUpper());
    Console.Write("Qual é a cor do objeto? " +
        " -- 1 - Vermelho, 2 - Azul, 3 - Amarelo");
    int cor = int.Parse(Console.ReadLine());
    if (escolha.Equals('R'))
    {
        Console.Write("Digite a Largura do Retangulo: ");
        double larguraR = double.Parse(Console.ReadLine());
        Console.Write("Digite a Altura do seu Retangulo: ");
        double alturaR = double.Parse(Console.ReadLine());
        formas.Add(new Retangulo((Cor)cor, larguraR, alturaR));
    }
    else if (escolha.Equals('C'))
    {
        Console.Write("Digite o raio do Circulo: ");
        double raio = double.Parse(Console.ReadLine());
        formas.Add(new Circulo((Cor)cor, raio));
    }
    else
    {
        Console.WriteLine("Objeto não encontrado");
    }
}

Console.WriteLine("Lista de formas digitadas e suas area:");
foreach (var figurinhas in formas)
{
    Console.Write($"{figurinhas.ToString()} - Area da figura: ");
    figurinhas.Area();
    Console.WriteLine($"A sua Cor escolhida: ");
    figurinhas.Cor();
}