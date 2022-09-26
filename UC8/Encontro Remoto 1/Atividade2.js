//1 - Se a peça possuir um peso superior a 100gramas, pode cadastrar.
//2 - Dada a capacidade de cada caixa, caso a lista de peças seja superior a 3, imprima uma mensagem informando não ter capacidade suficiente.
//3 - Caso a peça tenha um nome com quantidade inferior a 3 caracteres, informe uma mensagem de erro.

//resolucao

//1) peso da peca
let peso = 490

if (peso < 100)
{
    console.log('náo pode cadastrar, a peça dever ter no mínimo 100g')
}else {
    console.log('peça pode ser cadastrada')
}

//2) tamanho da lista
let listaDePecas = ['filtro de ar', 'retrovisor', 'virabrequim']

if (listaDePecas.length < 3)
{
    console.log('é possível cadastrar mais peças')
}else {
    console.log('não existe espaço na lista')
}

//3) caracteres do nome da peca
let nomePeca = 'virabrequim'

if (nomePeca.length > 3)
{
    console.log('nome da peça está adequado para o cadastro')
} else if (nomePeca.length == 0){
    console.log('o nome não pode ser vazio')
}else {
    console.log('o nome deve ter mais de 3 caracteres, digite um nome adequado')
}