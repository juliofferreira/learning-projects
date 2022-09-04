const menuButton = document.querySelector(".header__menu");
const menu = document.querySelector(".menu-side");

menuButton.addEventListener('click', () => {
    menu.classList.toggle('menu-side--active')
})