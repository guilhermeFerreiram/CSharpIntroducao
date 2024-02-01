using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_MODELOS.ByteBank.Modelos.ADM.Utilitario
{
    internal class AutenticacaoUtil
    {
        public bool ValidarSenha(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira.Equals(senhaTentativa);
        }
    }
}
