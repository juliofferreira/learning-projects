var botaoAdicionar = document.querySelector('#buscar-pacientes');

botaoAdicionar.addEventListener('click', () => {
	var xhr = new XMLHttpRequest();
	xhr.open('GET', 'http://api-pacientes.herokuapp.com/pacientes');
	xhr.addEventListener('load', () => {
		if (xhr.status === 200) {
			erroAjax.classList.add('invisivel');
			var resposta = xhr.responseText;
			var pacientes = JSON.parse(resposta);
			pacientes.forEach((paciente) => {
				adicionaPacienteNaTabela(paciente);
			});
		} else {
			erroAjax.classList.remove('invisivel');
		}
	});
	xhr.send();
});
