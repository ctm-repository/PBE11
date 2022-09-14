//Faca um programa que receba a idade de uma pessoa em anos e
//imprima essa idade em: Meses, Dias, horas, Minutos

//Algoritmo para calcular idade em meses, dias, horas e minutos

//idade em meses : multiplica a idade em anos por 12
//idade em dias : multiplica a idade em anos por 365
//idade em horas : idade em dias multiplicar por 24
//idade em minutos : idade em horas multiplicada por 60

//entrada
let idade = 20
console.log('Minha idade em anos é: ' + idade + ' anos')

//processamento
let idadeMeses = idade * 12
let idadeDias = idade * 365
let idadeHoras = idadeDias * 24
let idadeMinutos = idadeHoras * 60

//saida
console.log(idadeMeses)
console.log(idadeDias)
console.log(idadeHoras)
console.log(idadeMinutos)
