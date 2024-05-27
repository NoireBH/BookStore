
function bookDescription() {

}

function decreaseAmount() {


    $('#minus-btn').on('click', function (e) {
        e.preventDefault();
        e.stopPropagation();

        var amount = document.getElementById("book-amount");

        if (Number(amount.value) > 1) {
            amount.value = Number(amount.value) - 1;
        }

    });

    

}

function increaseAmount() {

    $('#plus-btn').on('click', function (e) {
        e.preventDefault();
        e.stopPropagation();

        var amount = document.getElementById("book-amount");

        if (Number(amount.value) < 100) {
            amount.value = Number(amount.value) + 1;
        }

    });

    
}