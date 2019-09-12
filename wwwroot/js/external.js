window.global = {
    openModal: function(name){
        name = '#'+name;
        $(name).modal('show')
    },
    closeModal: function(name){
        name = '#'+name;
        $(name).modal('hide')
    }
}