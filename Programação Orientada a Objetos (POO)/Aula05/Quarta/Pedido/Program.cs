using Pedido.Classes.Entidades;
using Pedido.Classes.Enumeracoes;

Funcionarios dev = new Funcionarios("Clodoaldo");
Funcionarios gerente = new Funcionarios("Elma");

Empresa SENAI = new Empresa("João Baptista Salles");
Empresa Suzano = new Empresa("Suzano");

Suzano.AdicionarFuncionario(gerente);
Suzano.AdicionarFuncionario(dev);
Console.WriteLine(Suzano);

Suzano = null;


Console.WriteLine(Suzano);
Console.WriteLine(dev);