
internal class Program
{
    private static void Main(string[] args)
    {
        int numero1;
        int numero2;
        int numero3;
        bool pergunta1;
        bool pergunta2;
        bool pergunta3;
        bool pergunta4;
        bool logica1;
        bool logica2;
        bool logica3;

        //Entrada de dados
        Console.WriteLine("Digite o primeiro valor: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        numero2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o terceiro valor: ");
        numero3 = int.Parse(Console.ReadLine());

        //Processamento de dados
        pergunta1 = numero1 == numero3;
        pergunta2 = numero1 != numero2;
        pergunta3 = numero2 > numero1;
        pergunta4 = numero2 <= numero3;

        logica1 = pergunta1 & pergunta3;
        logica2 = pergunta2 | pergunta4;
        logica3 = pergunta1;

        //Saída de dados
        Console.WriteLine("--Comparações--");
        Console.WriteLine($"O primeiro número é igual ao terceiro? R: {(pergunta1 ? "Verdadeiro" : "Falso")}");
        Console.WriteLine($"O primeiro número é diferente do terceiro? R: {(pergunta2 ? "Verdadeiro" : "Falso")}");
        Console.WriteLine($"O segundo número é maior que o primeiro? R: {(pergunta3 ? "Verdadeiro" : "Falso")}");
        Console.WriteLine($"O segundo número é menor ou igual ao terceiro? R: {(pergunta4 ? "Verdadeiro" : "Falso")}");
        Console.WriteLine("--Logicas--");
        Console.WriteLine($"Se a pergunta 1 e a pergunta 3 forem verdadeiras, então a resposta é: {(logica1 ? "Verdadeiro" : "Falso")}");
        Console.WriteLine($"Se a pergunta 2 ou a pergunta 4 forem verdadeiras, então a resposta é: {(logica2 ? "Verdadeiro" : "Falso")}");
        Console.WriteLine($"Se a negação da 1 pergunta for verdadeira, então a resposta é: {(logica3 ? "Verdadeiro" : "Falso")}");
    }
}