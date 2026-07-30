// declaração de variavel
double INSS, IR, FGTS, SalarioL, SalarioB, Valor, Quantidade;

try
{
    //Entrada de dados
    Console.Write("Qual é o seu valor da sua carga horaria: ");
    Valor = double.Parse(Console.ReadLine());
    Console.Write("Qual é a sua quantidade de hora: ");
    Quantidade = double.Parse(Console.ReadLine());
    SalarioB = Valor * Quantidade;

    
    if (SalarioB <= 900)
    {
        IR = 0;
    }
    else if (SalarioB > 900 & SalarioB <= 1500)
    {
        IR = 5;
    }
    else if (SalarioB > 1500 & SalarioB <= 2500)
    {
        IR = 10;
    }
    else 
    {
        IR = 20;
    }

    Impostos();

    SalarioL = SalarioB - (IR + INSS);
    Console.WriteLine($"Salario bruto: {Valor} * {Quantidade}: {SalarioB:c}");

    Console.WriteLine($"IR: {IR:c}");

    Console.WriteLine($"INSS: {INSS:c}");

    Console.WriteLine($"FGTS: {FGTS:c}");

    Console.WriteLine($"Descontos: {INSS + IR:c}");

    Console.WriteLine($"Salario Liquido: {SalarioL:c}");


}
catch
{
    Console.WriteLine("Valor invalidado");
}

void Impostos()
{
    IR = SalarioB * IR / 100;
    INSS = SalarioB * 0.1;
    FGTS = SalarioB * 0.11;
}