let listaPromo = [
    {
        img: "img/promo-monitor.png",
        titulo: "Monitor 19”",
        descricao: "Some quick example text to build on the card title and make up the bulk of the card's content."
    },
    {
        img: "img/promo-monitor.png",
        titulo: "Monitor 19”",
        descricao: "Some quick example text to build on the card title and make up the bulk of the card's content."
    },
    {
        img: "img/promo-monitor.png",
        titulo: "Monitor 19”",
        descricao: "Some quick example text to build on the card title and make up the bulk of the card's content."
    },
    {   
        img: "img/promo-teclado.png",
        titulo: "Teclado mecânico",
        descricao: "Some quick example text to build on the card title and make up the bulk of the card's content."
    },
    {   
        img: "img/promo-teclado.png",
        titulo: "Teclado mecânico",
        descricao: "Some quick example text to build on the card title and make up the bulk of the card's content."
    },
    {      
        img: "img/promo-teclado.png",
        titulo: "Teclado mecânico",
        descricao: "Some quick example text to build on the card title and make up the bulk of the card's content."
    },
]
    function renderizaPromo(){
        let espaco = document.getElementById("espaco-promo")

        let template = "";

        for(let index = 0; index < listaPromo.length; index++){
            const promo = listaPromo[index];

            template += `<div class="card">
            <img src="${promo.img}" class="card-img-top" alt="Monitor 19”">
            <div class="card-body">
            <h5 style="font-weight: bold;">${promo.titulo}</h5>
            <p class="card-text">${promo.descricao}.</p>
            <a href="#" class="btn btn-primary">Adicionar ao carrinho</a>
            </div>
            </div>`
        }

        espaco.innerHTML = template;




    }
