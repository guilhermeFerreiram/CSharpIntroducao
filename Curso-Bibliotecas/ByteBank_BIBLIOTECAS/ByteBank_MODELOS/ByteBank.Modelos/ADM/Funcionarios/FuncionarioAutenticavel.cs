using ByteBank.Modelos.ADM.SistemaInterno;
using ByteBank.Modelos.ADM.Funcionarios;
using ByteBank_MODELOS.ByteBank.Modelos.ADM.Utilitario;

namespace ByteBank.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }
        public AutenticacaoUtil Autenticador { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }
        public bool Autenticar(string senha)
        {
            return this.Autenticador.ValidarSenha(this.Senha, senha);
        }
    }
}