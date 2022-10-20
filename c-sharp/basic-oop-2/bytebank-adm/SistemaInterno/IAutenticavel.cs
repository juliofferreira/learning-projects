using System;
using bytebank_adm.Funcionarios;

namespace bytebank_adm.SistemaInterno
{
    public interface IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha);
    }
}

