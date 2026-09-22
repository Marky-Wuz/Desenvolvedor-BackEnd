using SistemaERP.Classes.Contextos;

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

            ContextoUsuario contexto = new ContextoUsuario();

            if (TextarConexaoBanco())
            {
                MessageBox.Show("Conexão sucedida!");
                Application.Run(new Login());
                contexto.Database.EnsureCreated();
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
                ContextoUsuario contexto = new ContextoUsuario();
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
