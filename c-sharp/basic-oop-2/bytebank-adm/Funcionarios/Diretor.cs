using System;
using bytebank_adm.SistemaInterno;

namespace bytebank_adm.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf):base(cpf, 5000)
        {
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }


        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}

