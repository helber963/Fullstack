
let dataAtual = 4;
let dataEvento = 3;
let idade = 18;
let palestrante = "Helber";
let nomeEvento = "Aulão";

//cadastrando evento
if (nomeEvento.length < 1){
    console.log("inserir nome do evento")
} else {
    console.log("evento cadastrado com sucesso!")
}

//cadastrando e validando data do evento
if (dataAtual>dataEvento){
    console.log("Data inferior a data atual, favor inserir uma data válida!");
} else {
    console.log("Data do evento gravada com sucesso!");
}

//cadastrando e validando idade para evento
if (palestrante.length < 1) {
    console.log("Inserir nome do palestrante");
} else {
    console.log("Nome do palestrante salvo com sucesso");
}

//cadastrando e validando idade para evento
if (idade<18){
    console.log("Idade inapropriada para participar do evento");
} else {
    console.log("Idade acima de 18 anos!");
}

//cadastrando e validando número total de participantes
for (let totalParticipantes = 1; totalParticipantes<=100; totalParticipantes++){
    console.log("o total de parcipantes é " + totalParticipantes);
}