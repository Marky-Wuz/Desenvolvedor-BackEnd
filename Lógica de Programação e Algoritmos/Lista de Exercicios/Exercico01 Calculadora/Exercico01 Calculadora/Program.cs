//Declaração de variaveis
double M;
double V;
double N;
char turno;
char horario;

Console.Title = "Atividade 01: Calculadora";
try
{
    //Entrada de dados
    Console.WriteLine("Turno da Escolaridade");
    Console.Write($"Digite N para Noturno, Digite V para Vespertino e Digite M para Matutino: ");
    turno = char.Parse(Console.ReadLine());



    //processamento de dados
    if (turno == 'M')
    {
        Console.WriteLine("Bom dia!");
    }
    else if (turno == 'V')
    {
        Console.WriteLine("Boa tarde!");
    }
    else if (turno == 'N')
    {
        Console.WriteLine("Boa noite!");
    }
    else
    {
        Console.WriteLine("Valor invalido");
    }
}
catch
{
    Console.WriteLine("Valor invalido, informe um valor valido.");
}

