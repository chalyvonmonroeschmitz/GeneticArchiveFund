$(document).load(function ($) { });


$(document).ready(function ($) {

    $.getScript("/assets/js/xenon-custom.js", function () {
        console.log("xenon-custom script imported");
    });

    // custom validators
    $.validator.unobtrusive.adapters.addBool("MustBeChecked", "required");

    // UA checkbox 
    $('input[name=AcceptedUA]').change(function (event) {
        if ($(this).is(":checked")) {
            $('#submitbutton').removeClass("disabled");
        } else {
            $('#submitbutton').addClass("disabled");
        }
    });

});