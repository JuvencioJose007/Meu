/*ATEN��O, VOC� N�O ENTENDERA NADA DO QUE EST� AQUI, POIS AT� EU QUE CRIEI N�O SEI O PQ DE FUNCIONAR :C*/
var temperatura_atual = 0, nova_temperatura = 0; // cria as variaveis que faram as "anima��es" com os numeros da temperatura

//* parametros => de forma bem simplificade �: tudo oq tem dentro dos '()' ao se declarar uma funcao
// ex: function MinhaFuncao(numero) o parametro no caso � o 'numero', em 'MinhaFuncaio'
//voce pasara um 'numero' que ser� responsavel por fazer algo no codgio


function atualiza_numeros(antes, agora) {// declara uma fun��o com o nome de 'atualiza_numeros' COM parametros* com a temperatura que est� 
    temperatura_atual = antes;           // marcando agora na p�gina representada pelo parametro(variavel) 'antes',
    nova_temperatura = agora;            // e a nova temperatura representado pelo 'agora'
    atualiza_termometro();
	// executa a fun��o responsavel por fazer a anima��o da temperatura
}// fim fun��o que chama outras fun��es para atualizar a temperatura

function atualiza_termometro() { // declara uma fun��o com o nome de 'atualiza_termometro' SEM parametros
    if (temperatura_atual != nova_temperatura) { // if para saber quando a temperatura que est� marcada no site, ser� igual a nova temperatura registrada

        setTimeout(atualiza_termometro, 100); // setTimeuot � uma fun��o que da um delay na execu��o do codigo, nele � preciso passar dois parametros, 1� => a fun��o que voce quer q tenha delay, e o tempo de delay em MS
        atualiza_fundo_termometro(temperatura_atual); // executa a fun��p para alterar a cor da div do fundo do termometro
        alerta(temperatura_atual); // executa a fun��o que gera o alerta com som
       
        infos_temperatura(temperatura_atual); // executa a fun��o que mostra na tela os textos sobre a temperatura    

    } 
    //document = html, getElementById = pegar o elemento HTML que possua o id, "txt_temperatura" -> nome da ID, innerHTML -> escrever no html, temperatura_atual + "�c" -> escreve a temperatura em atualiza��o
    document.getElementById("txt_temperatura").innerHTML = temperatura_atual + "�c"; //Aqui estamos escrevendo dentro do html onde est� marcando a temperatura (dash.html)
    
    if (temperatura_atual < nova_temperatura) { // se a temperatura_atual for menor que a nova_temperatura
        temperatura_atual++; // a temperatura_atual � incrementa de 1 em 1, mesma coisa de temperatura_atual = temperatura_atual + 1; so que com '++' � simplificado isso

    }//fim if
    else if (temperatura_atual > nova_temperatura) { // se a temperatura_atual for maior que a nova_temperatura
        temperatura_atual--;// a temperatura_atual � subtraida de 1 em 1 ate chegar na nova temperatura
    }// fim else if
    
}// fim fun��o para fazer anima��o de numeros

function atualiza_fundo_termometro(grau) {// fun��o COM parametro para atualizar o fundo da div de temperatura 
    if (grau <= 3) { // se grau for menor q 11

        // * as classes s�o usadas para que o css consiga aplicar os efeitos

        //busca o elemento que tem "area_termometro"

        document.getElementById("area_termometro").className = "gelado";
        document.getElementById("ult_att").innerHTML = "Gelado";
        document.getElementById("ponteiro").className = "pontGelado";
        document.getElementById("circ").className = "termometro bg_gelado";
        // adiciona uma CLASSE* nesse ID referenciado
    }
    else if (grau <= 10) { // etc
        document.getElementById("area_termometro").className = "frio";
        document.getElementById("ult_att").innerHTML = "Frio"; // adiciona uma nova classe
        document.getElementById("ponteiro").className = "pontFrio";
        document.getElementById("circ").className = "termometro bg_frio";
    } else if (grau <= 18) {
        document.getElementById("area_termometro").className = "fresco";
        document.getElementById("ult_att").innerHTML = "Fresco";
        document.getElementById("ponteiro").className = "pontFresci";
        document.getElementById("circ").className = "termometro bg_fresco";
    } else if (grau <= 24) {
        document.getElementById("area_termometro").className = "ameno";
        document.getElementById("ult_att").innerHTML = "Ameno";
        document.getElementById("ponteiro").className = "pontAmeno";
        document.getElementById("circ").className = "termometro bg_ameno";
    } else if (grau <= 30) {
        document.getElementById("area_termometro").className = "calor_moderado"; 
        document.getElementById("ult_att").innerHTML = "Calor Moderado";
        document.getElementById("ponteiro").className = "pontCalorModerado";
        document.getElementById("circ").className = "termometro bg_moderado";
    } else if (grau <= 40) {
        document.getElementById("area_termometro").className = "calor_forte";
        document.getElementById("ult_att").innerHTML = "Calor Forte";
        document.getElementById("ponteiro").className = "pontCalorForte";
        document.getElementById("circ").className = "termometro bg_forte";
    } else if (grau > 40) {
        document.getElementById("area_termometro").className = "escaldante";
        document.getElementById("ult_att").innerHTML = "Escaldante";
        document.getElementById("ponteiro").className = "pontEscaldante"
        document.getElementById("circ").className = "termometro bg_escaldante";
    }

}

function alerta(grau) { // fun��o com parametro para gerar um alerta sonoro
    if (grau <= 10 || grau >= 30) { // faz a compara��o para saber se a temperatura est� em na faixa
       document.getElementById("alerta").play();// busca o tag <audio> no html que possua um id "alerta" -> <audio id="alerta"> e da um play nele
       document.getElementById("ar").className = "area armado";
    } else { // se nao estiver nesse periodo
        document.getElementById("alerta").pause(); // busca a tag <audio> que possua o id "alerta" e da um pause
        document.getElementById("ar").className = "area";
    }
}

function remove_infos() { // fun��o para remover os textos sobre as temperaturas -> presente em dash.html 
    var div = document.getElementById("textos");// declara uma variavel que guardara a DIV q possua o id "textos"
    var pt = document.getElementById("desc_temp");// declara uma variavel que guardara <DIV> q possua o id "desc_temp"
    var p = div.getElementsByTagName("p");// // declara uma variavel que guardara <p>. TagName = nome da temp (:p)

    try {//tente executar o c�digo
        pt.parentNode.removeChild(p[0]);//pega a div que guarda os <p>, e remove todos o <p> dentro, ele retorna um vetor de <p> e nos pegamos o primeiro, ai fica p[0]
    } catch (err) { } // se nao der nao fa�a nada
	
	
	
    
}//fim fu���o remove

function getSizeP() {// fun��o gambiarra que faz a mesma coisa da fun��o remove_info, so q ao inves de excluir, ele retorna a qnt de <p> que existe
    
    var div = document.getElementById("textos"); // acho q tu ja entendeu oq faz aqui
    var p = textos.getElementsByTagName("p");
    
    return p.length * 5;// retorna a quantidade de <p> existentes dentro da div#textos e multiplica por 5, pq? GAMBIARRA. o numero 5 foi o numero mais baixo q fez com q funcionasse D:
}//fim gamibarra


function getRandom(max) {// fun��o que nao existira mais tarde, ele retorna numeros aleatorios
    Math.floor(Math.random() * max)
}


function getViewConfiguracoes(){// fun��o para abrir a tela de configura��o, acho q voce ja entendeu como funciona isso, se voce viu os exemplos acima, mas vamos l�
    var div_fundo = document.getElementById("fundo_modal");// adiciona a uma variavel, a referencia que busca a div que possui o ID "fundo modal"
    div_fundo.className = "";// tira todas as classes da div que referenciamos acima
    div_fundo.className = "fundo_modal_on"; //adiciona uma classe para que o css aplique o efeito, no caso para mostrar a tela
}

function removerViewConfiguracoes(){// fun��o para remover a tela de configura��es
    var div_fundo = document.getElementById("fundo_modal");// msm coisa
    div_fundo.className = "";//remove as classe
    div_fundo.className = "fundo_modal_off"; //adiciona a classe para esconder a tela, classe adicionada para o css aplicar o efeito
}


function getViewAddArduino(){ // mesma coisa da getViewConfiguracoes
    var div_fundo = document.getElementById("fundo_addArduino");
    div_fundo.className = "";
    div_fundo.className = "fundo_addArduino_on";
}

function removerViewAddArduino(){// mesma coisa da removerViewConfiguracoes
    var div_fundo = document.getElementById("fundo_addArduino");
    div_fundo.className = "";
    div_fundo.className = "fundo_addArduino_off";     
}

function infos_temperatura(temperatura) {//fun��o que adiciona os textos sobre as temperaturas, COM parametro

    vetor_menor_dez = new Array(4); //declara um VETOR de 4 posi��es
    vetor_menor_dez[0] = "FRIO FRIO FRIO";// na posi��o 0 recebe esse texto
    vetor_menor_dez[1] = "TEMPERATURA INFERIOR A 10";// na posi��o 1 recebe esse texto
    vetor_menor_dez[2] = "FRIO FRIO FRIO";//etc
    vetor_menor_dez[3] = "TEMPERATURA INFERIOR A 10";// etc
   


    vetor_onze_vinte = new Array(4);// msm coisa
    vetor_onze_vinte[0] = "MENOS FRIO MENO FRIO";// etc
    vetor_onze_vinte[1] = "TEMPERATURA DE 11 A 20";// etc
    vetor_onze_vinte[2] = "MENOS FRIO MENO FRIO";
    vetor_onze_vinte[3] = "TEMPERATURA DE 11 A 20";

    vetor_vinte1_trinta = new Array(4);// etc
    vetor_vinte1_trinta[0] = "NEM FRIO NEM QUENTE";// etc
    vetor_vinte1_trinta[1] = "TEMPERATURA DE 21 A 30";
    vetor_vinte1_trinta[2] = "NEM FRIO NEM QUENTE";
    vetor_vinte1_trinta[3] = "TEMPERATURA DE 21 A 30";

    vetor_trinta1_quarenta = new Array(4);// etc
    vetor_trinta1_quarenta[0] = "TA ESQUENTANDO TA ESQUENTANDO";// etc
    vetor_trinta1_quarenta[1] = "TEMPERATURA DE 31 A 40";
    vetor_trinta1_quarenta[2] = "TA ESQUENTANDO TA ESQUENTANDO";
    vetor_trinta1_quarenta[3] = "TEMPERATURA DE 31 A 40";

    vetor_quarenta1 = new Array(4);// etc
    vetor_quarenta1[0] = "CHURASQUINHO TA R$ 2 CHURASQUINHO TA R$ 2";// etc
    vetor_quarenta1[1] = "TEMPERATURA SUPERIOR A 41";
    vetor_quarenta1[2] = "CHURASQUINHO TA R$ 2 CHURASQUINHO TA R$ 2";
    vetor_quarenta1[3] = "TEMPERATURA SUPERIOR A 41";

    if (temperatura <= 10) {//se a temperatura estiver menor igual que 10
        for (var i = 0; i < getSizeP(); i++){// cria um la�o de reti��o que ser� responsavel por apagar todos os textos existentes (aqui usa aquela gambiarra)
            remove_infos();//apaga todos os <p>, toda vez que entrar no la�o, ex -> getSizeP retorna 5, ent�o o la�o repetira 5 vezes, e a fun��o remove_infos() ser� executada 5 vezes, por isso eu utilizei o 'p[0]' pois se eu usasse por exemplo 1,2,3 daria erro 'NullException' pois esses numeros correspondente j� seriao excluidos, com a posi��o sempre no 0 � "impossivel" nao existir EU SEI FICOU MTO CONFUSO
        }//fim for
       
        for (var i = 0; i < vetor_menor_dez.length; i = i +1) {// cria um la�o para CRIAR os <p> com os textos dos VETORES que criamos acima
            var txt = document.getElementById("textos");//acho q tu j� entendeu oq faz aqui, se n�o entendeu sobe um pouco q la ta explicando
            txt.innerHTML += "<p id='desc_temp'>" + vetor_menor_dez[i] + "</p>";// aqui usamos novamento o innerHTML, nele criamos os <p> que recebem o conteudo dos vetores, -> [i] representa a posi��o dele, ao inves de usar o nomeDoVetor[0] usamos o i pois ele esta se alto incrementando de 1 em 1

        }// fim for
        
    } else if (temperatura <= 20) {// faz a mesma coisa, so q aqui � um else if :p
        for (var i = 0; i < getSizeP(); i++) {
            remove_infos();
        }
        for (var i = 0; i < vetor_onze_vinte.length; i++) {
            var txt = document.getElementById("textos");
            txt.innerHTML += "<p id='desc_temp'>" + vetor_onze_vinte[i] + "</p>";

        }
    } else if (temperatura <= 30) {
        for (var i = 0; i < getSizeP(); i++) {
            remove_infos();
        }
        for (var i = 0; i < vetor_vinte1_trinta.length; i++) {
            var txt = document.getElementById("textos");
            txt.innerHTML += "<p id='desc_temp'>" + vetor_vinte1_trinta[i] + "</p>";

        }
    } else if (temperatura <= 40) {
        for (var i = 0; i < getSizeP(); i++) {
            remove_infos();
        }
        for (var i = 0; i < vetor_trinta1_quarenta.length; i++) {
            var txt = document.getElementById("textos");
            txt.innerHTML += "<p id='desc_temp'>" + vetor_trinta1_quarenta[i] + "</p>";

        }
    }  else {
        for (var i = 0; i < getSizeP(); i++) {
            remove_infos();
        }
        for (var i = 0; i < vetor_quarenta1.length; i++) {
            var txt = document.getElementById("textos");
            txt.innerHTML += "<p id='desc_temp'>" + vetor_quarenta1[i] + "</p>";
        }
    }
    

}

