//condicionais

//condicional simples
let semaforo1 = 'amarelo'

if (semaforo1 == 'verde')
{
    console.log('carro autorizado a passar')
}

//condicional composta
let semaforo2 = 'vermelho'

if (semaforo2 == 'verde')
{
    console.log('Pode passar')
}else{
    console.log('observar se está amarelo ou vermelho')
}

//condicional encadeada
let semaforo3 = 'vermelho'

if (semaforo3 == 'verde')
{
    console.log('pode passar')
}else if (semaforo3 == 'vermelho')
{
    console.log('pare')
}else
{
    console.log('atenção')
}

// = atribuir valor
// == comparar valor
// === comparar valor e tipo de dado