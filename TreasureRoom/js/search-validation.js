$(document).ready(function() {
    $('.search-btn').attr('disabled', true);

    $('#keyword-search').keyup(function() {
        if ($(this).val().length != 0) {
            $('.search-btn').attr('disabled', false);
        } else {
            $('.search-btn').attr('disabled', true);
        }
    })
});