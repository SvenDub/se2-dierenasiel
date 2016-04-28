function OnReady() {
    reloadAnimals();

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
    $('#delete-dogs').click(function () {
        deleteAnimals('dog');
        reloadAnimals();
    });
    $('#delete-cats').click(function () {
        deleteAnimals('cat');
        reloadAnimals();
    });
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

    var animals = JSON.parse(localStorage.getItem('animals'));
    if (!Array.isArray(animals)) {
        animals = [];
    }
    animals.push(animal);
    localStorage.setItem('animals', JSON.stringify(animals));

    // Prevent submission when using localStorage
    event.preventDefault();
    $('#add-form')[0].reset();

    reloadAnimals();
}

function show(el) {
    el.removeClass('hidden');
}

function hide(el) {
    el.addClass('hidden');
}

function reloadAnimals() {
    var animals = JSON.parse(localStorage.getItem('animals'));

    var dogTable = $('#animal-honden-data');
    var catTable = $('#animal-katten-data');

    dogTable.empty();
    catTable.empty();

    if (animals != null && Array.isArray(animals)) {
        animals.forEach(function (animal) {

            var table;
            if (animal.species === 'dog') {
                table = dogTable;
            } else if (animal.species === 'cat') {
                table = catTable;
            }

            table.append('<tr>' +
                '<td>' + animal.name + '</td>' +
                '<td>' + (animal.age ? animal.age : '') + '</td>' +
                '<td>' + (animal.regnr ? animal.regnr : '') + '</td>' +
                '<td>' + (animal.reserved ? 'Ja' : 'Nee') + '</td>' +
                '</tr>')
        });
    }
}

function deleteAnimals(species) {
    var animals = JSON.parse(localStorage.getItem('animals'));
    if (!Array.isArray(animals)) {
        animals = [];
    }
    animals.removeIf(function (animal) {
        return animal.species === species;
    });
    localStorage.setItem('animals', JSON.stringify(animals));
}

$(document).ready(OnReady);

// Overrides
Array.prototype.removeIf = function (callback) {
    var i = this.length;
    while (i--) {
        if (callback(this[i], i)) {
            this.splice(i, 1);
        }
    }
};