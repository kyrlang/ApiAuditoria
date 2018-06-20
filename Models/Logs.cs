using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAuditoria.Models
{
    public class Logs
    {
        public string Operacao { get; set; }
        public string Mensagem { get; set; }
        public long DataHora { get; set; }
    }
}
