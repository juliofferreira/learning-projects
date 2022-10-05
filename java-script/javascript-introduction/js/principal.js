var titulo = document.querySelector('.titulo');
titulo.textContent = 'Aparecida Nutricionista';

var pacientes = document.querySelectorAll('.paciente');

for (var i = 0; i < pacientes.length; i++) {
	var paciente = pacientes[i];

	var tdPeso = paciente.querySelector('.info-peso');
	var peso = tdPeso.textContent;

	var tdAltura = paciente.querySelector('.info-altura');
	var altura = tdAltura.textContent;

	var tdImc = paciente.querySelector('.info-imc');

	var pesoValido = true;
	var alturaValida = true;

	if (peso <= 0 || peso >= 600) {
		pesoValido = false;
		tdPeso.textContent = 'Peso inválido!';
		paciente.classList.add('paciente-invalido');
	}

	if (altura <= 0 || altura >= 2.6) {
		pesoValido = false;
		tdAltura.textContent = 'Altura inválida!';
		paciente.classList.add('paciente-invalido');
	}

	if (pesoValido && alturaValida) {
		var imc = peso / (altura * altura);
		tdImc.textContent = imc.toFixed(2);
	} else {
		tdImc.textContent = 'Altura e/ou peso inválidos!';
	}
}
