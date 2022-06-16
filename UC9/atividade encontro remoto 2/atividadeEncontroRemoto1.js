var listaDePecas = ["Amortecedor", "Motor", "Filtro de Ar"]; //array
//Peso adequado para cadastro
let peso = 200;

if (peso < 100) {
    console.log("A peça deve ter o peso minimo de 100g :(");
} else {
    console.log("A peça tem o peso adequado! :D");
}

//Quantidade de peças possivel para cadastro
if (listaDePecas.length < 10) {
    console.log("É possivel cadastrar mais peças :D");
}  else {
    console.log("Capacidade máxima de 10 peças atingidas! :(");
}

//Caractere minimo de 3
let peca = "filtro de ar";
if (peca.length < 3 ) {
    console.log("A peça deve possuir o minimo de 3 caracteres");
} else {
    console.log("A peça tem o minimo de caracteres!");
}