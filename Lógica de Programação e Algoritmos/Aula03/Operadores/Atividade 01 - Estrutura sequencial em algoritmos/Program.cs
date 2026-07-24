
        int a = 1;
        int b = 2;
        int c = 3;
        Console.WriteLine("Digite o primeiro valor:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o terceiro valor:");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine(a == c ? "Verdadeiro, O Valor é igual." : "Errado, O Valor não é igual.");

        Console.WriteLine(a != b ? "Verdadeiro, O Valor é Diferente." : "Errado, O Valor não é Diferente.");

        Console.WriteLine(b > a ? "Verdadeiro, O Valor é Maior." : "Errado, O Valor não é Maior.");

        Console.WriteLine(b <= c ? "Verdadeiro, O Valor é Menor." : "Errado, O Valor não é Menor.");
