// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var totalPrice = document.getElementById('total-price');
var quantity = document.getElementById('quantity');
var unitPrice = document.getElementById('unit-price');
var unitPrice;
var currentQuantity;

// Executes if #total-value element is on current page
if (totalPrice != null && totalPrice.length > 0) {
    quantity.addEventListener('change', (event) => {
        currentQuantity = parseInt(quantity.value);
        unitPrice = Number(unitPrice.textContent);

        // For debugging
        // console.log('currentQuantity: ' + currentQuantity);
        // console.log('price: ' + unitPrice);
        totalPrice = unitPrice * currentQuantity
        totalPrice.textContent(totalPrice.toFixed(2));
    });
} 