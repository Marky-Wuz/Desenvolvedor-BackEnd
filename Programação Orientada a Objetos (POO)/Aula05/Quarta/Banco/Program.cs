using Banco.Classes.Entidades;

ContaPessoaFisica clodoaldo;
clodoaldo = new ContaPessoaFisica(1000, 123456, "Clodoaldo");

ContaPessoaJuridica SENAI;
SENAI = new ContaPessoaJuridica(5000, 5555, "klaf", 1000);

SENAI.Saque(1000);
SENAI.Deposito(52);
clodoaldo.Saque(50);
clodoaldo.Deposito(6000);
SENAI.Limite(1000);