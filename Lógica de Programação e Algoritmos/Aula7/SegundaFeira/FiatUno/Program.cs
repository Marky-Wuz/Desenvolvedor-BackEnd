// Declaração de variaveis
int carro = 0;
int turista = 0;
string movimento;
int Turistas = 0, Veiculos = 0, code;


code = 0;
Turistas = 0;
Veiculos = 0;
carro = turista;
while (true)
{
    try
    {
        while (true)
        {
            // Entrada de dados
            Console.Write("Veiculo está entrando ou voltando? ou digite sair para encerrar o expediente. ");
            movimento = Console.ReadLine()!;
            if (movimento == "Sair")
            {
                break;
            }
            Console.Write("Quantos turistas tem dentro do veiculo? ");
            turista = int.Parse(Console.ReadLine()!);




            if (movimento == "entrando")
            {
                carro++;
                Turistas += turista;
            }
            else if (movimento == "voltando")
            {
                carro--;
                Turistas -= turista;
            }

            Console.WriteLine($"Veiculos no parque: {carro}");
            Console.WriteLine($"Quantos turistas no veiculo: {turista}");

        }
        break;
    }
    catch (Exception erro)
    {

        Console.WriteLine($"Um Erro foi identificado = {erro}");
    }
}