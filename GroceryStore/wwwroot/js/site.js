

/* Function that changes the total cost when the quantity of items is changed*/
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
