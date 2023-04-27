
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
    if (quantity == '0' && btn.innerHTML == "ADD TO CART") {
        alert("Please select a number");
    } else {
        if (btn.innerHTML != "ADDED TO CART") {
            var data = {
                image: image,
                name: name,
                quantity: quantity,
                price: price
            };
            $.ajax({
                url: "/AddToCart",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                data: JSON.stringify(data),
                processData: false,
                success: function (result) {
                    console.log(result);
                },
                error: function (xhr, status, error) {
                    console.log(xhr.responseText);
                }
            });
            btn.classList.remove("btn-primary");
            btn.classList.add("btn-danger");
            btn.style.color = "white";
            btn.innerHTML = "ADDED TO CART";
            console.log(image);
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