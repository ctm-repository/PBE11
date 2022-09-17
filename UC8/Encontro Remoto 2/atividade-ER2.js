// Considere a quantidade de alunos presentes na sala, percorra do zero até o número total de alunos e retornar os seguintes resultados:

// se o número for zero, escreva 'zero' e o número correspondente.
// se o número for par, escreva 'par' e o número correspondente.
// se o número for ímpar, escreva 'ímpar' e o número correspondente.


let alunosPresentes = 15

for (let aluno = 0; aluno <= alunosPresentes; aluno++){

    if (aluno == 0){
        console.log('zero ' + aluno)
    }else if (aluno % 2 == 0){
        console.log('par ' + aluno)
    } else {
        console.log('impar ' + aluno)
    }
}

let listaDeAlunos = ['a', 'b', 'c', 'd', 'e']

for (let contador = 0; contador < listaDeAlunos.length; contador++){

    if (contador == 0){
        console.log('zero ' + contador)
    }else if (contador % 2 == 0){
        console.log('par ' + contador )
    }else{
        console.log('impar ' + contador)
    }
}