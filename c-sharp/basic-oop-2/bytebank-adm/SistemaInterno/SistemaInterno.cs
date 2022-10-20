using System;
using bytebank_adm.Funcionarios;
using bytebank_adm.Parceria;

namespace bytebank_adm.SistemaInterno
{
    public class SistemaInterno
    {
        public SistemaInterno()
        {
        }

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao nosso sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }
        }
    }
}

