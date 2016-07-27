function startTimer(duration, display, progress) {
    var timer = duration, minutes, seconds;
    setInterval(function () {
        minutes = parseInt(timer / 60, 10);
        seconds = parseInt(timer % 60, 10);

        minutes = minutes < 10 ? "0" + minutes : minutes;
        seconds = seconds < 10 ? "0" + seconds : seconds;

        display.text(minutes + ":" + seconds);
        $(progress).css({ 'width': (timer / duration * 100).toString() + '%' });
        if (--timer < 0) {
            timer = duration;
        }
    }, 1000);
}

function SetCountDown(Minutos,obj,progress) {
    var fiveMinutes = 60 * 5,
    display = $(obj);
    progress = $(progress);
    startTimer(fiveMinutes, display, progress);
}
