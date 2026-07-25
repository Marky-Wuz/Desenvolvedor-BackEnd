using System;

//declaração de variaveis
int totalsegundos, horas, minutos, segundos;

//Entrada de dados
Console.WriteLine("Digite a duração em segundos: ");
totalsegundos = int.Parse(Console.ReadLine());

TimeSpan duracao = TimeSpan.FromSeconds(totalsegundos);

//Processamento de dados
horas = (int)duracao.TotalHours;
minutos = (int)duracao.TotalMinutes;
segundos = (int)duracao.Seconds;

//Saída de dados
Console.WriteLine($"{horas},{minutos},{segundos}");
