    function ExibirTime(btn,TimeSlug) {
        $("." + TimeSlug).css({ 'display': ($("." + TimeSlug).css('display') == '-webkit-inline-box' ? 'none' : '-webkit-inline-box') });
        if ($(btn).children('span').hasClass('glyphicon-chevron-down')) {
            $(btn).children('span').removeClass('glyphicon-chevron-down');
            $(btn).children('span').addClass('glyphicon-chevron-up');
        }
        else {
            $(btn).children('span').removeClass('glyphicon-chevron-up');
            $(btn).children('span').addClass('glyphicon-chevron-down');
        }
    }

function ExcluirTime(TimeSlug) {
    var x = $.cookie('Cartola').replace('Times=', '').split(',');
    var iPosicao = x.indexOf('fc-ewerton87');
    x.splice(iPosicao, 1);
    $.cookie('Cartola') = 'Times=' + x.join(',');
}


function SombraMouseOut(slug){
    $("#" + slug).css({ 'box-shadow': '' });
}

function SombraMouseOver(slug) {
    $("#" + slug).css({ 'box-shadow': '2px 2px lightgrey' });
}
    

$(document).ready(function () {$("#AutoRefreshChk").prop("checked", ($.cookie("autorefresh")=="true"?true:false)).change();});

function getCookie() {
    var list = document.cookie.split(";");
    return list[0];

}

