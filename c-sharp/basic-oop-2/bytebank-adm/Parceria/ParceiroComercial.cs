using System;
using bytebank_adm.SistemaInterno;

namespace bytebank_adm.Parceria
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}

