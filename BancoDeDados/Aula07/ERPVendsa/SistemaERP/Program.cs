using SistemaERP.Classes.Contexto;
using SistemaERP.Classes.Contextos;
using SistemaERP.Classes.Contextos;
using SistemaERP.Telas;

namespace SistemaERP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SQLitePCL.Batteries.Init();
            ContextoUsuario contexto = new ContextoUsuario();
            contexto.Database.EnsureCreated();

            ContextoPessoa pessoa = new ContextoPessoa();
            pessoa.Database.EnsureCreated();

            ContextoUltimoUsuario usuario = new ContextoUltimoUsuario();
            usuario.Database.EnsureCreated();

            if (TextarConexaoBanco())
            {
                MessageBox.Show("Conexão bem sucedida!");
                Application.Run(new RegistroDeConta());
            }
            else
            {
                MessageBox.Show("Falha ao conectar ao banco de dados");
            }

        }
        private static bool TextarConexaoBanco()
        {
            try
            {
                // ContextoUsuario contexto = new ContextoUsuario();
                ContextoPessoa contexto = new ContextoPessoa();
                return contexto.Database.CanConnect();
            }
            catch (Exception e)
            {

                MessageBox.Show($"Erro: {e.Message}");
                return false;
            }
        }



    }
}
