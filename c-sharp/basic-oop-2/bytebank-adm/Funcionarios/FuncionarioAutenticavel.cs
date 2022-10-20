using System;
using bytebank_adm.SistemaInterno;

namespace bytebank_adm.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get ; set ; }

        public override void AumentarSalario()
        {
            throw new NotImplementedException();
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}

