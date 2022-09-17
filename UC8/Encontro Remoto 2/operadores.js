//principais operadores

//atribuição
let x = 10

//aritméticos
// soma +
console.log(5 + 8)

// concatenação +
console.log(5 + 'Renan')

// subtração - 
console.log(13 - 8)
 multiplicação *
console.log(5 * 5)

//divisão /
console.log(10 / 5)

// modular % : resto da divisão inteira
console.log(5 % 2)

//relacionais ou comparação

// == igual a
// >= maior ou igual a
// <= menor ou igual a
// > maior que
// < menor que
// != diferente de

console.log(5 == 5)
console.log(5 >= 5)
console.log(5 <= 5)
console.log(5 > 5)
console.log(5 != 5)

// lógicos
// && e
// || ou
// ! não

//Tabela verdade
//&& : Só é verdade o retorno se ambas comparações forem verdade
console.log(5 == 5 && 8 == 8)
console.log(5 == 5 && 8 == 9)

// comparação entre número e texto om operador === "estritamente igual, valor e tipo de dado"
console.log(5 === '5' && 8 == 8)

// || : Só é falso o retorno se ambas comparações forem falsas
console.log(2 == 2 || 3 == 3)
console.log(2 == 1 || 3 == 3)
console.log(1 == 2 || 2 == 3)

// operador de negação ou "não verdade"
console.log( ! (2 == 2 || 3 == 3))

exercicios

//1) 5 + 2 > 5
console.log(5 + 2 > 5)

//2) 5 + 2 <= 7 == true
console.log(5 + 2 <= 7 == true)

//3) true && true && true || true && false                      
console.log(true && true && true || true && false)

//4) 5 + 2 != 7 / 2 + 3.5 == true && false
console.log(5 + 2 != (7 / 2) + 3.5) == true && false
