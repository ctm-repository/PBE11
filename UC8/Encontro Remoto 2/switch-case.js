//switch-case

//exemplo de codificação de um jantar usando if/else
const alimentoSelecionado = 'buchada'

if (alimentoSelecionado === 'churrasco'){
    console.log('vamos jantar ' + alimentoSelecionado)
} else if(alimentoSelecionado === 'macarrão'){
    console.log('vamos jantar ' + alimentoSelecionado)
}else{
    console.log('o item não consta no cardápio')
}


//exemplo de codificação de um jantar usando switch-case
switch (alimentoSelecionado) {
    case 'feijoada':
        console.log('vamos jantar ' + alimentoSelecionado)
        break;
    case 'churrasco':
        console.log('vamos jantar ' + alimentoSelecionado)
        break;
    default:
        console.log('o item não consta no cardápio')
        break;
}