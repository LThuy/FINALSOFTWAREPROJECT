
$("[type='number']").keypress(function (evt) {
    evt.preventDefault();
});

function addToCart(event) {
    var btn = event;
    var name = $(btn).siblings('#phone_name').text();
    var price = $(btn).siblings('.card-text').find('#phone_price').text();
    var memory = $(btn).siblings('.card-text').find('.r1').find('.col-sm-6').find('#phone_memory').text();
    var camera = $(btn).siblings('.card-text').find('.r2').find('.col-sm-6').find('#phone_camera').text();
    var pin = $(btn).siblings('.card-text').find('.r3').find('.col-sm-6').find('#phone_pin').text();
    var quantity = $(btn).siblings('.Quantity-product').find('#quantity').val();
    if (quantity == '0') {
        alert("Please select a number");
    } else {
        if (btn.innerHTML != "ADDED TO CART") {
            btn.classList.remove("btn-primary");
            btn.classList.add("btn-danger");
            btn.style.color = "white";
            btn.innerHTML = "ADDED TO CART";

            console.log(name);
            console.log(price);
            console.log(memory);
            console.log(camera);
            console.log(pin);
            console.log(quantity);
            // Add animation effect to cart icon
            $('#cart-area i').addClass('animated shake');
            // Update cart counter
            var count = parseInt($('#cart-counter').text());
            $('#cart-counter').text(count + 1);
            // Remove animation effect after a delay
            setTimeout(function () {
                $('#cart-area i').addClass('animated shake');
            }, 100);
        } else {
            btn.classList.remove("btn-danger");
            btn.classList.add("btn-primary");
            btn.style.color = "white";
            btn.innerHTML = "ADD TO CART";
            // Add animation effect to cart icon
            $('#cart-area i').addClass('animated shake');
            // Update cart counter
            var count = parseInt($('#cart-counter').text());
            $('#cart-counter').text(count - 1);
            // Remove animation effect after a delay
            setTimeout(function () {
                $('#cart-area i').addClass('animated shake');
            }, 100);
        }
    }
}