# Convers-es-de-Dados

Conversão de Dados em Programação de Jogos

CONVERSÃO CAST

Cast é a operação de converter um valor de um tipo para outro (ex. boll -> int). Em jogos, isso aparece o tempo inteiro: pegar componentes, converter posições, trabalhar com fisíca, UI, etc.

TIPOS DE CONVERSÕES

1. Conversão implícita (automática)
   
Acontece quando não há risco de perda de dados - o compilador faz sozinho

        int vida = 100;

        float vidaFloat = vida; // int -> float, sem perigo

2. Conversão explícita (cast tradicional)

É quando você diz para o compilador "eu sei que essa conversão pode perder informação ou dar erro, mais quero fazer assim mesmo".

        float velocidade = 5.7f
        int velocidadeInt = (int)velocidade; - vira 5, trunca o decimal

        double dano = 23.99;
        int danoInt = (int)dano; - trunca casa decimais, vira 23

Aqui podemos ver dois exemplos, de velocidade e de dano. Nos dois exemplos a casa decimal (floaty e double) são truncadas, ou simplesmente desconsideradas. São considerados casos tradicionais da conversão por Cast.

🎯 FATO INTERESSANTE

Conversões por Cast só funcionam com varíaveis de tipos númericos, se tentarmos converter uma string para uma int, poderá dar erro de sintaxe. Para esse tipos de conversão, teremos que usar um conversor diferente, irei explica-lo abaixo.

CONVERSÃO POR CLASSE Convert

Diferente do Cast tradicional (int), o Convert.ToInt32() é um método da classe System.Convert que faz a conversão de forma mais "inteligente" (por assim dizer), e segura em alguns aspectos. Porém, com um comportamento importante que costuma confundir: este método arredonda em vez de truncar.

        float velocidade = 5.7f
        int a = (int)velocidade;  // trunca para 5
        int b = Convert.ToInt32(velocidade);   // arredonda para 6 

        double dano = 23.49;
        int c = (int)dano;    // 23 - trunca
        int d = Convert.ToInt32(dano)    // 23 - arredonda para baixo

CONERTENDO STRING

        string inputJogador = "150"
        int vidaMazima = Convert.ToInt32(inputJogador); - 150

Neste exemplo com string, deve ter cuidado com casos de querer converter um texto para um número inteir, pois pode dar mensagem de sintaxe inválida, correndo o risco do jogo quebrar. Quando se quer converter letras para variaveis númericas, não é recomendado usar o Convert.ToInt32(), nem por Cast - (int).


EXEMPLOS REAIS (string para int)

Vamos imaginar que tem um cofre a sua frente, e esta pedindo uma senha númerica, logo você solicita uma senha:

        string codigoDigitado = "1847"; -- vem de botôes que o jogador clicou, já validados como dígitos

Porém o sistema do jogo não está conseguindo ler a senha digitada como digitos numéricos, logo, para avançar no jogo, precisará converter. E é neste caso que entra o System.Convert:

        // utilizando o exemplo acima
        int codigoJogador = Convert.ToInt32(codigoDigitado);

        if (codigoJogador == codigoCorreto)
        {
                AbrirCofre();
        }

Neste exemplo funciona muito bem, porque o jogador não pode digitar "livremente", ele clica em botôes numéricos (0-9) na tela, então a string só pode conter digitos numéricos, nunca letras, impedindo que o sistema do jogo quebre e impeça o jogador de avançar na sua jornada.

O QUE SIGNIFICA Convert.ToInt32()?
- 'Convert' vêm de System.Convert - que possibilita a conversão de varíaveis;
- 'ToInt' em português 'para Int', está "apontando", por assim dizer, que uma varíavel será convertida para outra, o 'Int', não é exclusivo, pode-se usar ToString, ToBool, ToFloat.
- '32' é o número de bits que essa conversão consegue representar - isso define o limite máximo e mínimo da conversão.


🎯 FATO INTERESSANTE

Sempere que for converter bool, que é uma linguagem de condição, tem uma regra que deve ser levada em considereção:

        bool = true; 
        // quando converter um bool representando true, o valor representado será 1, pois a condição será verdadeira.
        bool = false;
        // quando converter um bool representando false, o valor apresentado será 0, pois a condição será falsa.
