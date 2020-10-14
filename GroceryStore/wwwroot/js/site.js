// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
var quantity = document.getElementById('quantity');
var unitPrice = document.getElementById('unit-price').textContent;
var currentQuantity = document.getElementById('quantity').value;

// Executes if #total-value element is on current page
quantity.addEventListener('change', (event) => {
    var intUnitPrice = parseFloat(unitPrice);
        
    var price = (intUnitPrice * quantity.value).toFixed(2);
    var myPrice = price.toString();
    document.getElementById('total-price').innerHTML = myPrice;
});

/////////////////////////////////////////////////////////////////
