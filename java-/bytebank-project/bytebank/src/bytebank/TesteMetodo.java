package bytebank;

public class TesteMetodo {
	public static void main(String[] args) {
		Conta conta = new Conta();
		conta.saldo = 100;
		conta.deposita(50);
		System.out.println(conta.saldo);
		
		boolean conseguiuRetirar = conta.saca(20);
		System.out.println(conta.saldo);
		System.out.println(conseguiuRetirar);
		
		Conta conta2 = new Conta();
		conta2.deposita(1000);
		
		boolean sucessoTransferencia = conta2.transfere(300, conta);
		
		if (sucessoTransferencia) {
			System.out.println("transferência com sucesso");
		} else {
			System.out.println("faltou dinheiro");
		}
		System.out.println(conta2.saldo);
		System.out.println(conta.saldo);
		
		conta.titular = "paulo silveira";
		System.out.println(conta.titular);
	}
}
