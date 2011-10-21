$(document).ready(function () {
    $('.cartAddLink').click(function () {

        var idt = $(this).attr('id');
        var name = $(this).attr('name');

        alert("Du la nyss till en " + name + " i din varukorg!");






        $.post('http://localhost:64295/Home/AddProductToCartFromSearch?productId=' + idt, function (data) {
            $('.result').html(data);

            // Create a new notification (5 second timeout)


            // Create a new sticky notification, save as foo



            //göra nåt fett härinne !!!!

        });

        //Göra ajax call till lägga metodL,M
        //Uppdatera siffran i varukorgen on success

        return false;
    });



});


