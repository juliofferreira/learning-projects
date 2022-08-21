using bytebank.Titular;
namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular {get; set;}

        private string _conta;
        public string Conta 
        { 
            get { return _conta; }
            set
            {
                if (value == null) { return; }
                _conta = value; 
            }
        }

        private int _numero_agencia;
        public int NumeroAgencia 
        {
            get { return _numero_agencia; }
            set 
            {
                if (value <= 0) { return; }
                _numero_agencia = value; 
            }
        }

        public string NomeAgencia { get; set; }
        private double saldo;
        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }
        public bool Sacar(double valor)
        {
            if(saldo < valor)
            {
                return false;
            }
            if(valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }
        public ContaCorrente(int numeroAgencia, string conta)
        {
            NumeroAgencia = numeroAgencia;
            Conta = conta;
            TotalDeContasCriadas++;
        }
        public static int TotalDeContasCriadas { get; set; }
    }
}