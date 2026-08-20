using Contrato.Classes.Entidades;

empresas SENAI = new empresas("Roberto Mange", "Clodoaldo");
funcionarios abc = new funcionarios("Roberto mange");
SENAI.RegistrarContrato(10, 50);

Console.WriteLine(SENAI);

SENAI = null;

Console.WriteLine(SENAI);
Console.WriteLine();