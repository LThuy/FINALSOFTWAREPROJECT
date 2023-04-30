
$("[type='number']").keypress(function (evt) {
    evt.preventDefault();
});

function addToCart(event) {
    var btn = event;
    var $card = $(btn).closest('.card');
    var image = $card.find('.card-img-top').attr('src');
    console.log(image);
    var name = $(btn).siblings('#phone_name').text();
    var price = $(btn).siblings('.card-text').find('#phone_price').text();
    var quantity = $(btn).siblings('.Quantity-product').find('#quantity').val();
    var memory = $(btn).siblings('.card-text').siblings('#r1').find('#mem').find('#phone_memory').text();
    var camera = $(btn).siblings('.card-text').siblings('#r2').find('#cam').find('#phone_camera').text();
    var pin = $(btn).siblings('.card-text').siblings('#r3').find('#pin').find('#phone_pin').text();
    if (quantity == '0') {
        alert("Please select a number");
    } else {
      
         window.location.href = "/Cart?image=" + image + "&name=" + name + "&price=" + price + "&quantity=" + quantity;
    }
}

let totalPrice = 0;
const rows = document.querySelectorAll('table tbody tr');
rows.forEach(row => {
    const priceCell = row.querySelector('td:nth-child(4)');
    const price = parseFloat(priceCell.innerText.replace('$', ''));
    const quantityInput = row.querySelector('input[type="number"]');
    const quantity = parseInt(quantityInput.value);
    totalPrice += price * quantity;
});
const totalPriceCell = document.querySelector('table tfoot td:last-child');
totalPriceCell.innerText = '$' + totalPrice.toFixed(2);
