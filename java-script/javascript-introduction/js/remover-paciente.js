var tabela = document.querySelector('table');

tabela.addEventListener('dblclick', (event) => {
	var parente = event.target.parentNode;
	parente.classList.add('fadeOut');
	setTimeout(() => parente.remove(), 500);
});
