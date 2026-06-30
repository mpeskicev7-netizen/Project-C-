let allCards = document.querySelectorAll(".bike-card");

allCards.forEach(function(card) {
	card.addEventListener("click", function() {
		card.classList.toggle("bike-card--open");
	});
});