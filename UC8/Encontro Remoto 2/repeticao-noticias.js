//array for e foreach

//array = lista
let noticias = [
    'Leão explica recusa ao Santos e lamenta momento do clube',//0
    'Preço da gasolina cai 6,3% nas bombas e etanol só é vantajoso em 4 estados',//1
    'Como será o caminho do Corinthians até a final contra o Flamengo'//2
]

console.log('Quantidade de notícias: ' + noticias.length) //retorna o tamanho da minha lista

for (let n = 0; n < noticias.length; n++){
    console.log(noticias[n])
}

//metodo para percorrer todos os itens da lista (foreach)
noticias.forEach(cadaItem => {
    console.log(cadaItem)
} )



