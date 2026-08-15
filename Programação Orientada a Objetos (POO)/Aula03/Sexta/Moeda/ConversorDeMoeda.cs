namespace Moeda
{
    public static class ConversorDeMoeda
    {

        public const double IOF = 0.06;

        public static double Comprar(double cotação, double compra)
        {
           
            double pagamento = (cotação * compra * (1 + IOF));
            return pagamento;
        }
    }
}