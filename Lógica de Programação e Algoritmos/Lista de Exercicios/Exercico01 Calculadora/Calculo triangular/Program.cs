// Declaração de variaveis
double lado1, lado2, lado3, trianguloEqui, trianguloIsos, triaguloEsca;
bool triangulo;
try
{

    // Entrada de dados
    Console.Write("Coloque o valor da 1 Coluna: ");
    lado1 = double.Parse(Console.ReadLine());
    Console.Write("Coloque o valor da 2 Coluna: ");
    lado2 = double.Parse(Console.ReadLine());
    Console.Write("Coloque o valor da 3 Coluna: ");
    lado3 = double.Parse(Console.ReadLine());

    //processamento de dados
    if ((lado1 + lado2) > lado3 & (lado1 + lado3) > lado2 & (lado2 + lado3) > lado1)
    {
        triangulo = true;
    }
    else
    {
        triangulo = false;
        Console.WriteLine("Esse valor não forma triangulo.");
    }
    if (triangulo == true)
    {
        if (lado1 == lado2 & lado2 == lado3 & lado1 == lado3)
        {
            Console.WriteLine("Triangulo Equilatero");
        }
        else if (lado2 == lado3 | lado1 == lado2 | lado3 == lado1)
        {
            Console.WriteLine("Triangulo Isosceles");
        }
        else
        {
            Console.WriteLine("Triangulo Escaleno");
        }
    }
}
catch
{
    Console.WriteLine("Digite um valor valido.");
}