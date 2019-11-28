var remSeconds =@timeRemaining;
var secondsCounter = remSeconds % 60;

function formatNumber(number) {
    if (number < 10)
        return '0' + number;
    else return '' + number;
}

function startTick() {

    document.getElementById('secRemaining').innerText = formatNumber(parseInt(secondsCounter));
    document.getElementById('minRemaining').innerText = formatNumber(parseInt(remSeconds / 60));


    var _tick = setInterval(function () {

        if (remSeconds > 0) {



            remSeconds = remSeconds - 1;
            secondsCounter = secondsCounter - 1;
            document.getElementById('secRemaining').innerText = formatNumber(parseInt(secondsCounter));
            document.getElementById('minRemaining').innerText = formatNumber(parseInt(remSeconds / 60));

            if (secondsCounter == 0)
                secondsCounter = 60;
        }
        else {
            //alert('Youooo');
            clearInterval(_tick);
            document.getElementById("myform").submit();

        }

    }, 1000);

}
startTick();
