let allCards = document.querySelectorAll(".bike-card");

allCards.forEach(function(card) {
	card.addEventListener("click", function() {
		card.classList.toggle("bike-card--open");
	});
});

let weeksInput = document.getElementById('weeks');
let totalPriceElement = document.getElementById('total-price');
let weeksDisplay = document.getElementById('weeks-display');

if (weeksInput && totalPriceElement) {
    let pricePerWeek = 3500;
    
    function updateTotal() {
        let weeks = parseInt(weeksInput.value) || 1;
        let total = pricePerWeek * weeks;
        
        totalPriceElement.textContent = total + ' ₽';
        weeksDisplay.textContent = weeks + ' нед.';
    }
    
    weeksInput.addEventListener('input', updateTotal);
    weeksInput.addEventListener('change', updateTotal);
}