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