var myMessages = ['info'];


function hideAllMessages() {
    var messagesHeights = new Array(); // this array will store height for each

    for (var i = 0; i < myMessages.length; i++) {
        messagesHeights[i] = $('.' + myMessages[i]).outerHeight(); // fill array
        $('.' + myMessages[i]).css('top', -messagesHeights[i]); //move element outside viewport
    }
}

function showMessage(type) {
    $('.trigger').click(function () {

        hideAllMessages();

        var name = $(this).attr('name');
        var idt = $(this).attr('id');

        $.post('http://localhost:64295/Home/AddProductToCartFromSearch?productId=' + idt, function (data) {
           


        });
        
        
        $('.' + type).animate({ top: "0" }, 500);
        return false;
    });
}



$(document).ready(function () {



    // Initially, hide them all
    hideAllMessages();

    // Show message
    for (var i = 0; i < myMessages.length; i++) {

        showMessage(myMessages[i]);


    }

    $("div.message").click(function () {
        $(this).animate({ top: "-100" }, 500);

        //setTimeout(function () { hideAllMessages() }, 4000);



    });



});