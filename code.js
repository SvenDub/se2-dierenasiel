function OnReady() {
    
    var dog = localStorage.getItem('dog');
    
    if (dog !== null) {
        alert(dog);
    }

    var cat = localStorage.getItem('cat');

    if (cat !== null) {
        alert(cat);
    }
    
    var name = $('#add-name');
    var nameHint = $('#add-name-hint');
    var idHint = $('#add-id-hint');

    name.focus(function () {
        show(nameHint);
        hide(idHint);
    });
    name.blur(function () {
        hide(nameHint);
    });

    $('#add-form').submit(OnSubmit);
}

function OnSubmit(event) {
    var nameHint = $('#add-name-hint');
    var idHint = $('#add-id-hint');

    hide(nameHint);
    hide(idHint);

    var animal = {
        'species': $('input[name="add-type"]:checked').val(),
        'name': $('#add-name').val(),
        'age': $('#add-age').val(),
        'regnr': $('#add-id').val(),
        'reserved': $('#add-reserved').is(':checked')
    };

    if (!(animal.species === 'cat'
        || animal.species === 'dog')) {
        event.preventDefault();
        return;
    }

    if (animal.name.length === 0) {
        event.preventDefault();
        show(nameHint);
        return;
    }


    if (animal.age.length > 0 && animal.age < 0) {
        event.preventDefault();
        return;
    }

    if (animal.regnr.length > 0 && !animal.regnr.startsWith('0')) {
        event.preventDefault();
        show(idHint);
        return;
    }

    localStorage.setItem(animal.species, JSON.stringify(animal));
}

function show(el) {
    el.removeClass('hidden');
}

function hide(el) {
    el.addClass('hidden');
}

$(document).ready(OnReady);