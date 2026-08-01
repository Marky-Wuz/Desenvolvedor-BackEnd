//declaração de variaveis
double senhacustom;
const int senha = 0;

//Entrada de dados
Console.WriteLine("Crie a senha: ");
senhacustom = double.Parse(Console.ReadLine());
Console.Write("Digite a senha: ");
int n = int.Parse(Console.ReadLine());


  if (senhacustom != senha)
{
    Console.WriteLine("Senha Invalida, Coloque novamente; ");
    n = int.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine("Senha Correta, Acesso Permitido.");
}
  