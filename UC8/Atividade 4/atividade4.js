//instalar o readline-sync : npm install readline-sync
//importar o módulo instalado : const rs = require('readline-sync')
const rs = require('readline-sync')

//criamos uma lista vazia
let lista = []

//criamos uma variável e atribuímos o valor para ela de 's' de sim
let opcao = 's'

//laço de repetição
//enquanto a opcao for 's', ou seja, sim
while(opcao == 's')
{
    //variável nome vai guardar o que o usuário digitar no console
    let nome = rs.question('Digite o nome do participante: ')

    //variável idade vai guardar o que o usuário digitar no console
    let idade = rs.question('Digite a idade do participante: ')
    
    //condicional
    //SE idade que foi digitada for maior que 18
    if (idade > 18) {

        //SE o tamanho da lista for menor que 100
        if (lista.length < 100) {
            //então escreva no console: Cadastro permitido !
            console.log('Cadastro permitido')
            //e guarde esse nome dentro da lista
            lista.push(nome)             
        } else {            
            console.log('Cadastro não permitido, pois atingiu o limite máximo de 100 !')
        }
    } else {
        console.log('Cadastro não permitido pela idade')
    }
    //Após o término da verificação, digite s para continuar no laço ou n para sair do laço
    opcao = rs.question('Deseja cadastrar outro participante?(s ou n )')
}

//após o encerramento do laço acima...
//inicia-se um outro laço para mostrar no console os itens da lista
i = 1
while (i < lista.length) {
    console.log(lista)
    i++
}

//outra maneira é usar o forach para ler os itens da lista
lista.forEach(element => {
    console.log(element)
});