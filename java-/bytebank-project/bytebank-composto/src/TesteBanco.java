
public class TesteBanco {
	public static void main(String[] args) {
		Cliente paulo = new Cliente();
		paulo.nome = "Paulo Silveira";
		paulo.cpf = "222.222.222-22";
		paulo.profissao = "programador";
		
		Conta conta = new Conta();
		conta.deposita(100);
		
		conta.titular = paulo;
		System.out.println(conta.titular.nome);
		System.out.println(conta.titular);
		System.out.println(paulo);
	}
}
