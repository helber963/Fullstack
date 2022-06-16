    $(document).ready(function(){

        $("#carrosel img:eq(0)").addClass("banner-ativo").show()

        setInterval(slide, 1500)

        function slide(){
        if($(".banner-ativo").next().length){
            $(".banner-ativo").removeClass("banner-ativo").hide().next().addClass("banner-ativo").show()
        }else{
            $(".banner-ativo").removeClass().hide()
            $("#carrosel img:eq(0)").addClass("banner-ativo").show()
        }
        }
        
        $("#barras").click(function () {
            $("#menu").toggleClass("menu-ativo")
        //    if(("#menu").hasclass("menu-ativo")){
        //        $("#menu").removeClass("menu-ativo")
        //    } else {
        //        $("#menu").addClass("menu-ativo")
        //    }
        })
    })


    let listaNoticias = [
        {
            titulo: "Novo sistema integrator travou o meu pc",
            descricao: "Coordenador foi chamado para verificar e identificou que o monitor estava desligado."
        },
        {
            titulo: "Aumento no numeros de não-brancos",
            descricao: "Após ida do jovem Italo Cunha, vulgo 'my bro' sobe o números de não brancos na sala do N5."
        },
        {
            titulo: "Diminuição nos casos de assedio contra mulheres",
            descricao: "Após ida do papudo Istefano ao NOC, o número de assédio cai drasticamente no CRC."
        },
        {
            titulo: "Golpe da ONG",
            descricao: "Toda quinta feira, um jovem atropela ou espanca animal para receber pix solidários."
        },
        {
            titulo: "Número de talaricos sobe dentro da Você telecom",
            descricao: "Grande parte disse surgi do Coordenador de atendimentos."
        },
        {
            titulo: "Meu chefe me bate",
            descricao: "Segundo funcionário, seu chefe chega na sala apontando o dedo na cara."
        },
    ]

    function renderizarNoticias(){
        let espaco = document.getElementById("espaco-noticias")

        let template = "";

        for(let index =0; index < listaNoticias.length; index++){
            const noticia = listaNoticias[index];
            
            template += `<div class="cardnews"><img src="img/cardnews.png" alt="Foto de uma jogadora profissional"><h3>${noticia.titulo}</h3><p>${noticia.descricao}</p></div>`
            
        }
        espaco.innerHTML = template;




    }












    let menu = document.getElementById("menu")
                
    function mostrarMenu(){
        if(menu.style.display == "none"){
                menu.style.display = "flex"
        } else {
            menu.style.display = "none"
        }
    }

    function mostrarPopup(){
        window.alert("Eai parça")
    }

    let email = document.getElementById("campo-email")

    function enviarEmail(){
        let emailDigitado = email.value
        console.log(emailDigitado)
    } 
