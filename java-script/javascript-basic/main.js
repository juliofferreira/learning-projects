const playSound = (selectorAudio) => {
	const element = document.querySelector(selectorAudio).play();

	if (element && element.localName === 'audio') {
		element.play();
	} else {
		console.log('Elemento não encontrado ou seletor inválido.');
	}
};

const buttonList = document.querySelectorAll('.tecla');

buttonList.forEach((button) => {
	const buttonClass = button.classList[1];
	const idAudio = `#som_${buttonClass}`;

	button.onclick = () => {
		playSound(idAudio);
	};

	button.onkeydown = (event) => {
		if (event.code === 'Enter' || event.code === 'Space') {
			button.classList.add('ativa');
		}
	};

	button.onkeyup = (event) => {
		if (event.code === 'Enter' || event.code === 'Space') {
			button.classList.remove('ativa');
		}
	};
});
