// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const cards = document.querySelectorAll(".practice-flashcard");

function flipCard() {
	this.classList.toggle("flip");
}
cards.forEach((card) => card.addEventListener("click", flipCard));

function removeCardWarning(divId) {
	var dialog = document.getElementById(divId);
	console.log(dialog);
	dialog.style.display = "block";

}

function closeCardWarning(divId) {
	var dialog = document.getElementById(divId);
	console.log(dialog);
	dialog.style.display = "none";
}