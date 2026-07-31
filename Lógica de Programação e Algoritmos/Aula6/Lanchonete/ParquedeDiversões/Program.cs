try
{
//Declarações de variaveis
int AlturaMIN, AlturaMAX, Visitantes;
    int contagem = 0;
    int expulsos = 0;
Console.Write("Quantos visitantes? ");
Visitantes = int.Parse(Console.ReadLine());
Console.Write("Altura minima: ");
AlturaMIN = int.Parse(Console.ReadLine());
Console.Write("Altura Máxima: ");
AlturaMAX = int.Parse(Console.ReadLine());


// Entrada de dados
for (int i = 0; i < Visitantes; i++)
{
    Console.Write("Digite a altura do visitante: ");
    int Altura = int.Parse(Console.ReadLine());
    if (Altura < AlturaMIN | Altura > AlturaMAX)
    {
        Console.WriteLine("Visitante não poderá entrar");
            expulsos++;
    }
    else
    {
        Console.WriteLine("Visitante poderá entrar no parque.");
            contagem++;
    }
}
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Total de pessoas que podem andar na montanha-russa: {contagem}");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Total de pessoas que foram expulsas: {expulsos}");
}
catch
{
    Console.WriteLine("O numero/caracter colocado não está disponivel.");
}