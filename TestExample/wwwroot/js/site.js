// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function confirmSubmit(isSubmitClicked) {
    var submitSpan = 'submitSpan';
    var confirmSubmitSpan = 'confirmSubmitSpan';

    if (isSubmitClicked) {
        $('#' + submitSpan).hide();
        $('#' + confirmSubmitSpan).show();
    } else {
        $('#' + submitSpan).show();
        $('#' + confirmSubmitSpan).hide();
    }
}