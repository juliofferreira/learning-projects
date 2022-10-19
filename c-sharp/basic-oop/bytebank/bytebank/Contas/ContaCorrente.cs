using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebank.Titular;

namespace bytebank.Contas
{
	public class ContaCorrente
	{
        public static int TotalDeContasCriadas { get; private set; }
        private int numeroAgencia;
		public int NumeroAgencia
        {
			get { return numeroAgencia; }
			private set
			{
				if (value > 0)
				{
					this.numeroAgencia = value;
				}
			}
        }
		public string Conta { get; set; }
		private double saldo = 100;

		public Cliente Titular { get; set; }

		public void Depositar(double valor)
        {
			this.saldo += valor;
        }

		public bool Sacar(double valor)
        {
			if(valor <= this.saldo)
            {
				this.saldo -= valor;
				return true;
            } else
            {
				return false;
            }
        }

		public bool Transferir(double valor, ContaCorrente destino)
        {
			if (this.saldo < valor)
            {
				return false;
            } else
            {
				this.Sacar(valor);
				destino.Depositar(valor);
				return true;
            }
        }

		public void SetSaldo(double valor)
        {
			if(valor < 0)
            {
				return;
            }
            else
            {
				this.saldo = valor;
            }
        }

		public double GetSaldo()
        {
			return this.saldo;
        }

        public ContaCorrente(int numeroAgencia, string numeroConta)
        {
			this.NumeroAgencia = numeroAgencia;
			this.Conta = numeroConta;
			TotalDeContasCriadas++;
        }
	}
}

