
function bookDescription() {

    $('.book-details').on('click', function (e) {
        e.preventDefault();
        e.stopPropagation();

        var bookDetails = document.getElementsByClassName("book-details")[0];

        if (bookDetails.style.display == 'none') {
            bookDetails.style.display == 'display-block'
        }

    });

    $('.book-details-description').on('click', function (e) {
        e.preventDefault();
        e.stopPropagation();

        var bookDetails = document.getElementsByClassName("book-details-description")[0];

        if (bookDetails.style.display == 'none') {
            bookDetails.style.display == 'display-block'
        }

    });

    $('.book-details-authors').on('click', function (e) {
        e.preventDefault();
        e.stopPropagation();

        var bookDetails = document.getElementsByClassName("book-details-authors")[0];

        if (bookDetails.style.display == 'none') {
            bookDetails.style.display == 'display-block'
        }

    });

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