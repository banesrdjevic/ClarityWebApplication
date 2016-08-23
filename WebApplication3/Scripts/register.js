$(document).ready(function () {
    $('#client-button').on('click', function (e) {
        $('#attendee-form-container').hide();
        $('#client-form-container').show();
    });

    $('#attendee-button').on('click', function (e) {
        $('#client-button').removeClass('active');
        $('#attendee-form-container').show();
        $('#client-form-container').hide();
    });

    $('#client-form').on('submit', function () {
        var zipValue = $('#zip').val();
        var phoneValue = $('#phone').val();
        var phoneRegex = /^[0-9\-\(\)]+$/;

        if (!phoneRegex.test(phoneValue)) {
            $('#phone').addClass("red-box");
            $('.phone-danger').show();
            console.log("HUH");
        }
        else {
            $('.phone-danger').hide();
            $('#phone').removeClass("red-box");
        }

        if (!$.isNumeric(zipValue)) {
            $('#zip').addClass("red-box");
            $('.zip-danger').show();
        }
        else {
            $('.zip-danger').hide();
            $('#zip').removeClass("red-box");
        }
        return $.isNumeric(zipValue) && phoneRegex.test(phoneValue);
    });
});