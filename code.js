function OnReady() {
    var name = $('#add-name');
    var hint = $('#add-name-hint');
    name.focus(function () {
        show(hint);
    });
    name.blur(function () {
        hide(hint);
    });
}

function show(el) {
    el.removeClass('hidden');
}

function hide(el) {
    el.addClass('hidden');
}

$(document).ready(OnReady);