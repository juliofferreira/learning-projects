var new0 = document.querySelector('#new0');
var new1 = document.querySelector('#new1');
var new2 = document.querySelector('#new2');
new0.style.display = 'block';

var noticias = document.querySelectorAll('.listaDeArtigos-item');
var btns = document.querySelectorAll('.listaDeArtigos-slider-item');

// Criando indicador de slide atual
var indicadorSlideAtual = document.createElement('span');
indicadorSlideAtual.classList.add('escondeVisualmente');
indicadorSlideAtual.id = 'escondeVisualmente';
indicadorSlideAtual.textContent = '(Slide atual)';

// Percorre todos os botoes controladores
btns.forEach(function (btn) {
	btn.addEventListener('click', function () {
		noticias.forEach(function (noticia) {
			noticia.style.display = 'none';
			if (
				btn.getAttribute('data-sliderItem') ===
				noticia.getAttribute('data-noticia')
			) {
				noticia.style.display = 'block';
			}
		});
		const spanEscondido = document.querySelector(
			'.listaDeArtigos-slider-item .escondeVisualmente'
		);
		if (spanEscondido) spanEscondido.remove();
		this.append(indicadorSlideAtual);

		// Remove classe 'ativo' dos outros botoes
		btns.forEach(function (btnRemoveClass) {
			btnRemoveClass.classList.remove('listaDeArtigos-slider-item--ativo');
		});

		this.classList.add('listaDeArtigos-slider-item--ativo');
	});
});
