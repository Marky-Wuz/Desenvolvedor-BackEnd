using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaERP.Dados
{
    internal static class TelaLogin
    {
        //campos
        static Login login { get; set; }
        static string Fechar { get; set; }

        //Métodos
        public static void AbrirTela()
        {
            Login login = new Login();
            login.Show();
        }
    }
}
