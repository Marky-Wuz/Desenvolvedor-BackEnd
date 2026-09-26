using System.ComponentModel;

namespace SistemaERP.Classes.Enumerações
{
    internal enum StatusUsuario
    {
        [Description("Aguardando aprovação...")]
        Aguardando,
        [Description("Usuario aprovado!")]
        Aprovado,
        [Description("Usuario Reprovado")]
        Reprovado
    }
}
