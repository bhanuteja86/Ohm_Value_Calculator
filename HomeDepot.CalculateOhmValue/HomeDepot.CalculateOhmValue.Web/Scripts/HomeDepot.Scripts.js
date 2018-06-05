$(document).ready(function () {

    $(".ajax-form").each(function () {

        $(this).validate({
            rules: {
                BandAColor: "required",
                BandBColor: "required",
                BandCColor: "required",
                BandDColor: "required"
            },
            messages: {
                BandAColor: "Please select first band color",
                BandBColor: "Please select second band color",
                BandCColor: "Please select third band color",
                BandDColor: "Please select multiplier value",
            }
        });
    });

    $('.ajax-form').submit(function (e) {
        HomeDepotUtilities.formAjaxSubmit(e);
    });

    $('.ui-accordion-header').on('click', function (event) {

        $('#tool_output_container').empty();
        $('#errors').empty(); });
});