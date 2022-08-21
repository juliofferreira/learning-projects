
public class TestaContaSemCliente {
	public static void main(String[] args) {
		Conta conta2 = new Conta();
		System.out.println(conta2.getSaldo());
		
		conta2.titular = new Cliente();
		
		conta2.titular.nome = "Marcela";
		System.out.println(conta2.titular.nome);
	}
}
