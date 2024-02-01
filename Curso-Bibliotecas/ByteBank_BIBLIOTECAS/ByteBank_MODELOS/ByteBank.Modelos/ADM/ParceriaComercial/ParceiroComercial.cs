using ByteBank.Modelos.ADM.SistemaInterno;
using ByteBank_MODELOS.ByteBank.Modelos.ADM.Utilitario;

namespace ByteBank.Modelos.ADM.Utilitario
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public AutenticacaoUtil Autenticador { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Autenticador.ValidarSenha(this.Senha, senha);
        }
    }
}