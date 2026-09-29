using System.ComponentModel;

namespace SistemaERP.Classes.Enumerações
{
    internal enum StatusUsuario
    {
        [Description("Aguardando aprovação...")]
        Aguardando = 0,
        [Description("Usuario aprovado!")]
        Aprovado = 1,
        [Description("Usuario Reprovado")]
        Reprovado = 2
    }
}
