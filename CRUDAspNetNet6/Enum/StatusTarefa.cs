using System.ComponentModel;

namespace CRUDAspNetNet6.Enum
{
    public enum StatusTarefa
    {
        [Description("a fazer")]
        Fazer = 0,

        [Description("em andamento")]
        EmAndamento = 1,

        [Description("concluido")]
        Concluido = 2,
    }
}
