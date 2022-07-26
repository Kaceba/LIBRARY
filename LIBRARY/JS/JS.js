$(document).ready(function () {
    $('#btnInserisci').click(function () {
        //collego l'oggetto alla pagina
        var url = this.href;
        var popUp = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');
        //dichiariamo tutte le caratteristiche dell' oggetto
        popUp.dialog({

            modal: true, //blocca le modifiche a tutto ciò che sta sotto all' ogg.
            title: 'Inserimento Dati',  //titolo dell'oggetto
            dialogClass: 'dialog',
            resizable: false,  //blocca il ridimensionamento
            height: 340,
            overlay: { opacity: 1, background: 'black' },  //parametri relativi all' overlay (bordo/sfondo scuro intorno)
            open: function (type, data) { $(this).parent().appendTo('form'); } //dati relativi all' apertura
        });
        //ogni oggetto deve restituire qualcosa
        return false;
    });
});

$(document).ready(function () {
    $('#btnModifica').click(function () {
        //collego l'oggetto alla pagina
        var url = this.href;
        var popUp = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');
        //dichiariamo tutte le caratteristiche dell' oggetto
        popUp.dialog({

            modal: true, //blocca le modifiche a tutto ciò che sta sotto all' ogg.
            title: 'Modifica Dati',  //titolo dell'oggetto
            dialogClass: 'dialog',
            resizable: false,  //blocca il ridimensionamento
            height: 340,
            overlay: { opacity: 1, background: 'black' },  //parametri relativi all' overlay (bordo/sfondo scuro intorno)
            open: function (type, data) { $(this).parent().appendTo('form'); } //dati relativi all' apertura
        });
        //ogni oggetto deve restituire qualcosa
        return false;
    });
});

$(document).ready(function () {
    $('#btnElimina').click(function () {
        //collego l'oggetto alla pagina
        var url = this.href;
        var popUp = $('<iframe src="' + url + '" frameborder="0"></iframe>').appendTo('body');
        //dichiariamo tutte le caratteristiche dell' oggetto
        popUp.dialog({

            modal: true, //blocca le modifiche a tutto ciò che sta sotto all' ogg.
            title: 'Eliminazione Dati',  //titolo dell'oggetto
            dialogClass: 'dialog',
            resizable: false,  //blocca il ridimensionamento
            height: 340,
            overlay: { opacity: 1, background: 'black' },  //parametri relativi all' overlay (bordo/sfondo scuro intorno)
            open: function (type, data) { $(this).parent().appendTo('form'); } //dati relativi all' apertura
        });
        //ogni oggetto deve restituire qualcosa
        return false;
    });
});