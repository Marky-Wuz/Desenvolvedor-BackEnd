async Task Principal()
{
    Console.WriteLine("Pedido Anotado!");
    await Task.WhenAll(PrepararHamburguer(), PrepararBatata(), PrepararMilkShake());
    Console.WriteLine("Pedido Entregue!");
}
async Task PrepararHamburguer()
{
    Console.WriteLine("Preparando Hamburguer...");
    await Task.Delay(3000);
    Console.WriteLine("Hamburguer está pronto!");
}

async Task PrepararBatata()
{
    Console.WriteLine("Preparando Batata Frita...");
    await Task.Delay(2500);
    Console.WriteLine("Batata Frita  está pronto!");
}
async Task PrepararMilkShake()
{
    Console.WriteLine("Preparando Milk Shake...");
    await Task.Delay(4000);
    Console.WriteLine("Milk Shake está pronto!");
}

await Principal();