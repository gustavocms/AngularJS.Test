var uri = '/api/RandomNumber';

$(document).ready(function () {
    // Send an AJAX request
    $.getJSON(uri)
        .done(function (data) {
            // On success, 'data' contains an integer.
            $('#randomNumber').text(data);

            // make the number disappear after specific time
            setTimeout(function () {
                $('#randomNumber').text("The number was hidden after " + data + " seconds.");
            }, data * 1000);
        });
});