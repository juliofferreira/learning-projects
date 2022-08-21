public class TestaGetESet {
	public static void main(String[] args) {
		Conta conta = new Conta(1337, 14226);
		
		conta.setNumero(1337);
		System.out.println(conta.getNumero());
		
		Cliente paulo = new Cliente();
		paulo.setNome("paulo silveira");
		conta.setTitular(paulo);
		
		conta.getTitular().setProfissao("programador");
	
		Cliente titularDaConta = conta.getTitular();
		titularDaConta.setProfissao("programador");
		
		System.out.println(conta.getTitular().getNome());
		System.out.println(paulo.getNome());
		System.out.println(titularDaConta.getNome());
	}
}