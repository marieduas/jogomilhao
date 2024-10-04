using jogomilhao;

public class Gerenciador
{
    Label labelPontuacao;
    Label labelNivel;
    List<Questao> ListaTodasQuestoes = new List<Questao>();
    List<Questao> ListaTodasQuestoesRespondidas = new List<Questao>();
    Questao QuestaoCorrente;
    public Gerenciador(Label LabelPerg, Button btResposta01, Button btResposta02, Button btResposta03, Button btResposta04, Button btResposta05, Label labelPontuacao, Label labelNivel)
    {
        CriarPerguntas(LabelPerg, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        this.labelPontuacao = labelPontuacao;
        this.labelNivel = labelNivel;
    }
    public Questao GetQuestaoCorrente()
    {
        return QuestaoCorrente;
    }
    void CriarPerguntas(Label labelPergunta, Button btResposta01, Button btResposta02, Button btResposta03, Button btResposta04, Button btResposta05)
    {
        var Questao01 = new Questao();
        Questao01.Nivel = 1;
        Questao01.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao01.pergunta = "Quem descobriu o Brasil?";
        Questao01.resposta1 = "Neymar";
        Questao01.resposta2 = "Pedro Álvares Cabral";
        Questao01.resposta3 = "Napoleão Bonaparte";
        Questao01.resposta4 = "Jair Bolsonaro";
        Questao01.resposta5 = "Thiago Macedo";
        Questao01.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao01);

        var Questao02 = new Questao();
        Questao02.Nivel = 1;
        Questao02.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao02.pergunta = "Qual é a montanha mais alta do mundo?";
        Questao02.resposta1 = "Monte Kilimanjaro";
        Questao02.resposta2 = "Aconcágua";
        Questao02.resposta3 = "Monte Everest";
        Questao02.resposta4 = "K2";
        Questao02.resposta5 = "Monte McKinley";
        Questao02.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao02);

        var Questao03 = new Questao();
        Questao03.Nivel = 1;
        Questao03.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao03.pergunta = " Quem é conhecido como o Pai da Psicanálise?";
        Questao03.resposta1 = "Sigmund Freud";
        Questao03.resposta2 = "Ivan Pavlov";
        Questao03.resposta3 = "Erik Erikson";
        Questao03.resposta4 = "Carl Jung";
        Questao03.resposta5 = "Alfred Adler";
        Questao03.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao03);

        var Questao04 = new Questao();
        Questao04.Nivel = 1;
        Questao04.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao04.pergunta = "Quem pintou a Mona Lisa?";
        Questao04.resposta1 = "Vincent van Gogh";
        Questao04.resposta2 = "Pablo Picasso";
        Questao04.resposta3 = "Leonardo da Vinci";
        Questao04.resposta4 = "Claude Monet";
        Questao04.resposta5 = "Salvador Dalí";
        Questao04.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao04);

        var Questao05 = new Questao();
        Questao05.Nivel = 1;
        Questao05.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao05.pergunta = "Qual é a fórmula química da água?";
        Questao05.resposta1 = "H2O";
        Questao05.resposta2 = "CO2";
        Questao05.resposta3 = "O2";
        Questao05.resposta4 = "H2O2";
        Questao05.resposta5 = "CH4";
        Questao05.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao05);

        var Questao06 = new Questao();
        Questao06.Nivel = 1;
        Questao06.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao06.pergunta = "Qual é o continente onde está localizado o Egito?";
        Questao06.resposta1 = "Ásia";
        Questao06.resposta2 = "América";
        Questao06.resposta3 = "África";
        Questao06.resposta4 = "Europa";
        Questao06.resposta5 = "Oceania";
        Questao06.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao06);

        var Questao07 = new Questao();
        Questao07.Nivel = 1;
        Questao07.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao07.pergunta = "Qual é a moeda do Japão?";
        Questao07.resposta1 = "Yuan";
        Questao07.resposta2 = "Won";
        Questao07.resposta3 = "Dólar";
        Questao07.resposta4 = "Iene";
        Questao07.resposta5 = "Rupia";
        Questao07.respostacorreta = 4;
        ListaTodasQuestoes.Add(Questao07);

        var Questao08 = new Questao();
        Questao08.Nivel = 1;
        Questao08.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao08.pergunta = "Quem é conhecido como o 'Rei do Pop'?";
        Questao08.resposta1 = "Elvis Presley";
        Questao08.resposta2 = "Michael Jackson";
        Questao08.resposta3 = "Prince";
        Questao08.resposta4 = "David Bowie";
        Questao08.resposta5 = "Freddie Mercury";
        Questao08.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao08);

        var Questao09 = new Questao();
        Questao09.Nivel = 1;
        Questao09.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao09.pergunta = "Qual é o órgão responsável por bombear o sangue no corpo humano?";
        Questao09.resposta1 = "Fígado";
        Questao09.resposta2 = "Coração";
        Questao09.resposta3 = "Pulmão";
        Questao09.resposta4 = "Rim";
        Questao09.resposta5 = "Estômago";
        Questao09.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao09);

        var Questao10 = new Questao();
        Questao10.Nivel = 1;
        Questao10.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao10.pergunta = "Qual é a língua oficial do Brasil?";
        Questao10.resposta1 = "Espanhol";
        Questao10.resposta2 = "Inglês";
        Questao10.resposta3 = "Francês";
        Questao10.resposta4 = "Português";
        Questao10.resposta5 = "Italiano";
        Questao10.respostacorreta = 4;
        ListaTodasQuestoes.Add(Questao10);

        var Questao11 = new Questao();
        Questao11.Nivel = 2;
        Questao11.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao11.pergunta = "Qual é o nome do famoso cientista que formulou a teoria da relatividade?";
        Questao11.resposta1 = "Isaac Newton";
        Questao11.resposta2 = "Albert Einstein";
        Questao11.resposta3 = "Galileu Galilei";
        Questao11.resposta4 = "Nikola Tesla";
        Questao11.resposta5 = "Stephen Hawking";
        Questao11.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao11);

        var Questao12 = new Questao();
        Questao12.Nivel = 2;
        Questao12.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao12.pergunta = "Qual é o maior oceano do mundo?";
        Questao12.resposta1 = "Oceano Atlântico";
        Questao12.resposta2 = "Oceano Índico";
        Questao12.resposta3 = "Oceano Pacífico";
        Questao12.resposta4 = "Oceano Ártico";
        Questao12.resposta5 = "Oceano Antártico";
        Questao12.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao12);

        var Questao13 = new Questao();
        Questao13.Nivel = 2;
        Questao13.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao13.pergunta = "Qual é a capital da Itália?";
        Questao13.resposta1 = "Roma";
        Questao13.resposta2 = "Milão";
        Questao13.resposta3 = "Nápoles";
        Questao13.resposta4 = "Florença";
        Questao13.resposta5 = "Veneza";
        Questao13.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao13);

        var Questao14 = new Questao();
        Questao14.Nivel = 2;
        Questao14.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao14.pergunta = "Qual é o planeta mais próximo do sol?";
        Questao14.resposta1 = "Terra";
        Questao14.resposta2 = "Marte";
        Questao14.resposta3 = "Mercúrio";
        Questao14.resposta4 = "Vênus";
        Questao14.resposta5 = "Júpiter";
        Questao14.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao14);

        var Questao15 = new Questao();
        Questao15.Nivel = 2;
        Questao15.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao15.pergunta = "Qual é o maior planeta do sistema solar?";
        Questao15.resposta1 = "Terra";
        Questao15.resposta2 = "Marte";
        Questao15.resposta3 = "Júpiter";
        Questao15.resposta4 = "Saturno";
        Questao15.resposta5 = "Vênus";
        Questao15.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao15);

        var Questao16 = new Questao();
        Questao16.Nivel = 2;
        Questao16.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao16.pergunta = "Qual é a capital da França?";
        Questao16.resposta1 = "Berlim";
        Questao16.resposta2 = "Madrid";
        Questao16.resposta3 = "Paris";
        Questao16.resposta4 = "Roma";
        Questao16.resposta5 = "Lisboa";
        Questao16.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao16);

        var Questao17 = new Questao();
        Questao17.Nivel = 2;
        Questao17.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao17.pergunta = "Quem escreveu 'Dom Casmurro'?";
        Questao17.resposta1 = "Machado de Assis";
        Questao17.resposta2 = "José de Alencar";
        Questao17.resposta3 = "Joaquim Manuel de Macedo";
        Questao17.resposta4 = "Clarice Lispector";
        Questao17.resposta5 = "Carlos Drummond de Andrade";
        Questao17.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao17);

        var Questao18 = new Questao();
        Questao18.Nivel = 2;
        Questao18.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao18.pergunta = "Qual é o elemento químico representado pela letra 'O'?";
        Questao18.resposta1 = "Ouro";
        Questao18.resposta2 = "Oxigênio";
        Questao18.resposta3 = "Ósmio";
        Questao18.resposta4 = "Oganessônio";
        Questao18.resposta5 = "Prata";
        Questao18.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao18);

        var Questao19 = new Questao();
        Questao19.Nivel = 2;
        Questao19.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao19.pergunta = "Qual é o maior deserto do mundo?";
        Questao19.resposta1 = "Deserto do Saara";
        Questao19.resposta2 = "Deserto da Antártida";
        Questao19.resposta3 = "Deserto de Gobi";
        Questao19.resposta4 = "Deserto da Arábia";
        Questao19.resposta5 = "Deserto de Kalahari";
        Questao19.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao19);

        var Questao20 = new Questao();
        Questao20.Nivel = 2;
        Questao20.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao20.pergunta = "Quem pintou 'A Última Ceia'?";
        Questao20.resposta1 = "Michelangelo";
        Questao20.resposta2 = "Leonardo da Vinci";
        Questao20.resposta3 = "Raphael";
        Questao20.resposta4 = "Van Gogh";
        Questao20.resposta5 = "Monet";
        Questao20.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao20);

        var Questao21 = new Questao();
        Questao21.Nivel = 3;
        Questao21.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao21.pergunta = "Qual é o maior planeta do sistema solar?";
        Questao21.resposta1 = "Terra";
        Questao21.resposta2 = "Marte";
        Questao21.resposta3 = "Júpiter";
        Questao21.resposta4 = "Saturno";
        Questao21.resposta5 = "Vênus";
        Questao21.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao21);

        var Questao22 = new Questao();
        Questao22.Nivel = 3;
        Questao22.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao22.pergunta = "Quem é o autor de 'O Alquimista'?";
        Questao22.resposta1 = "J.K. Rowling";
        Questao22.resposta2 = "Paulo Coelho";
        Questao22.resposta3 = "Gabriel García Márquez";
        Questao22.resposta4 = "Ernest Hemingway";
        Questao22.resposta5 = "F. Scott Fitzgerald";
        Questao22.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao22);

        var Questao23 = new Questao();
        Questao23.Nivel = 3;
        Questao23.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao23.pergunta = "Qual é a capital da Austrália?";
        Questao23.resposta1 = "Sydney";
        Questao23.resposta2 = "Melbourne";
        Questao23.resposta3 = "Canberra";
        Questao23.resposta4 = "Brisbane";
        Questao23.resposta5 = "Perth";
        Questao23.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao23);

        var Questao24 = new Questao();
        Questao24.Nivel = 3;
        Questao24.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao24.pergunta = "Qual é o maior oceano do mundo?";
        Questao24.resposta1 = "Oceano Atlântico";
        Questao24.resposta2 = "Oceano Índico";
        Questao24.resposta3 = "Oceano Pacífico";
        Questao24.resposta4 = "Oceano Ártico";
        Questao24.resposta5 = "Oceano Antártico";
        Questao24.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao24);

        var Questao25 = new Questao();
        Questao25.Nivel = 3;
        Questao25.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao25.pergunta = "Qual é o símbolo químico do ouro?";
        Questao25.resposta1 = "Au";
        Questao25.resposta2 = "Ag";
        Questao25.resposta3 = "Pb";
        Questao25.resposta4 = "Fe";
        Questao25.resposta5 = "Hg";
        Questao25.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao25);

        var Questao26 = new Questao();
        Questao26.Nivel = 3;
        Questao26.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao26.pergunta = "Qual é a língua oficial do Brasil?";
        Questao26.resposta1 = "Espanhol";
        Questao26.resposta2 = "Português";
        Questao26.resposta3 = "Inglês";
        Questao26.resposta4 = "Francês";
        Questao26.resposta5 = "Italiano";
        Questao26.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao26);

        var Questao27 = new Questao();
        Questao27.Nivel = 3;
        Questao27.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao27.pergunta = "Quem pintou a obra 'Guernica'?";
        Questao27.resposta1 = "Pablo Picasso";
        Questao27.resposta2 = "Vincent van Gogh";
        Questao27.resposta3 = "Salvador Dalí";
        Questao27.resposta4 = "Claude Monet";
        Questao27.resposta5 = "Henri Matisse";
        Questao27.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao27);

        var Questao28 = new Questao();
        Questao28.Nivel = 3;
        Questao28.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao28.pergunta = "Qual é a montanha mais alta do mundo?";
        Questao28.resposta1 = "K2";
        Questao28.resposta2 = "Kilimanjaro";
        Questao28.resposta3 = "Monte Everest";
        Questao28.resposta4 = "Makalu";
        Questao28.resposta5 = "Lhotse";
        Questao28.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao28);

        var Questao29 = new Questao();
        Questao29.Nivel = 3;
        Questao29.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao29.pergunta = "Qual é o famoso monumento em Paris?";
        Questao29.resposta1 = "Torre Eiffel";
        Questao29.resposta2 = "Coliseu";
        Questao29.resposta3 = "Big Ben";
        Questao29.resposta4 = "Estátua da Liberdade";
        Questao29.resposta5 = "Cristo Redentor";
        Questao29.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao29);

        var Questao30 = new Questao();
        Questao30.Nivel = 3;
        Questao30.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao30.pergunta = "Qual é o maior mamífero do mundo?";
        Questao30.resposta1 = "Elefante";
        Questao30.resposta2 = "Baleia Azul";
        Questao30.resposta3 = "Girafa";
        Questao30.resposta4 = "Hipopótamo";
        Questao30.resposta5 = "Orca";
        Questao30.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao30);

        var Questao31 = new Questao();
        Questao31.Nivel = 4;
        Questao31.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao31.pergunta = "Qual é a capital da França?";
        Questao31.resposta1 = "Berlim";
        Questao31.resposta2 = "Madrid";
        Questao31.resposta3 = "Paris";
        Questao31.resposta4 = "Lisboa";
        Questao31.resposta5 = "Roma";
        Questao31.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao31);

        var Questao32 = new Questao();
        Questao32.Nivel = 4;
        Questao32.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao32.pergunta = "Qual é o elemento químico representado pela letra O?";
        Questao32.resposta1 = "Ouro";
        Questao32.resposta2 = "Oxigênio";
        Questao32.resposta3 = "Osmônio";
        Questao32.resposta4 = "Ósmio";
        Questao32.resposta5 = "Oxônio";
        Questao32.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao32);

        var Questao33 = new Questao();
        Questao33.Nivel = 4;
        Questao33.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao33.pergunta = "Qual é a língua mais falada do mundo?";
        Questao33.resposta1 = "Inglês";
        Questao33.resposta2 = "Mandarim";
        Questao33.resposta3 = "Espanhol";
        Questao33.resposta4 = "Árabe";
        Questao33.resposta5 = "Francês";
        Questao33.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao33);

        var Questao34 = new Questao();
        Questao34.Nivel = 4;
        Questao34.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao34.pergunta = "Qual é o planeta mais próximo do sol?";
        Questao34.resposta1 = "Terra";
        Questao34.resposta2 = "Vênus";
        Questao34.resposta3 = "Mercúrio";
        Questao34.resposta4 = "Marte";
        Questao34.resposta5 = "Júpiter";
        Questao34.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao34);

        var Questao35 = new Questao();
        Questao35.Nivel = 4;
        Questao35.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao35.pergunta = "Qual é a moeda utilizada no Japão?";
        Questao35.resposta1 = "Dólar";
        Questao35.resposta2 = "Yuan";
        Questao35.resposta3 = "Iene";
        Questao35.resposta4 = "Won";
        Questao35.resposta5 = "Rupia";
        Questao35.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao35);

        var Questao36 = new Questao();
        Questao36.Nivel = 4;
        Questao36.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao36.pergunta = "Quem escreveu 'Dom Casmurro'?";
        Questao36.resposta1 = "José de Alencar";
        Questao36.resposta2 = "Machado de Assis";
        Questao36.resposta3 = "Joaquim Manuel de Macedo";
        Questao36.resposta4 = "Clarice Lispector";
        Questao36.resposta5 = "Graciliano Ramos";
        Questao36.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao36);

        var Questao37 = new Questao();
        Questao37.Nivel = 4;
        Questao37.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao37.pergunta = "Qual é a fórmula química da água?";
        Questao37.resposta1 = "H2O";
        Questao37.resposta2 = "O2";
        Questao37.resposta3 = "CO2";
        Questao37.resposta4 = "NaCl";
        Questao37.resposta5 = "C6H12O6";
        Questao37.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao37);

        var Questao38 = new Questao();
        Questao38.Nivel = 4;
        Questao38.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao38.pergunta = "Qual é o autor da obra 'O Pequeno Príncipe'?";
        Questao38.resposta1 = "Antoine de Saint-Exupéry";
        Questao38.resposta2 = "Jules Verne";
        Questao38.resposta3 = "Gabriel García Márquez";
        Questao38.resposta4 = "Lewis Carroll";
        Questao38.resposta5 = "Hans Christian Andersen";
        Questao38.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao38);

        var Questao39 = new Questao();
        Questao39.Nivel = 4;
        Questao39.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao39.pergunta = "Qual é o rio mais longo do mundo?";
        Questao39.resposta1 = "Nilo";
        Questao39.resposta2 = "Amazonas";
        Questao39.resposta3 = "Yangtze";
        Questao39.resposta4 = "Mississippi";
        Questao39.resposta5 = "Ganges";
        Questao39.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao39);

        var Questao40 = new Questao();
        Questao40.Nivel = 4;
        Questao40.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao40.pergunta = "Qual é o continente onde fica o Egito?";
        Questao40.resposta1 = "Ásia";
        Questao40.resposta2 = "América";
        Questao40.resposta3 = "África";
        Questao40.resposta4 = "Europa";
        Questao40.resposta5 = "Oceania";
        Questao40.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao40);

        var Questao41 = new Questao();
        Questao41.Nivel = 5;
        Questao41.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao41.pergunta = "Qual é o maior deserto do mundo?";
        Questao41.resposta1 = "Deserto do Saara";
        Questao41.resposta2 = "Deserto da Antártica";
        Questao41.resposta3 = "Deserto de Gobi";
        Questao41.resposta4 = "Deserto de Kalahari";
        Questao41.resposta5 = "Deserto de Atacama";
        Questao41.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao41);

        var Questao42 = new Questao();
        Questao42.Nivel = 5;
        Questao42.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao42.pergunta = "Quem foi o primeiro homem a pisar na Lua?";
        Questao42.resposta1 = "Buzz Aldrin";
        Questao42.resposta2 = "Neil Armstrong";
        Questao42.resposta3 = "Yuri Gagarin";
        Questao42.resposta4 = "John Glenn";
        Questao42.resposta5 = "Michael Collins";
        Questao42.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao42);

        var Questao43 = new Questao();
        Questao43.Nivel = 5;
        Questao43.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao43.pergunta = "Qual é a capital da Itália?";
        Questao43.resposta1 = "Veneza";
        Questao43.resposta2 = "Roma";
        Questao43.resposta3 = "Milão";
        Questao43.resposta4 = "Florença";
        Questao43.resposta5 = "Nápoles";
        Questao43.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao43);

        var Questao44 = new Questao();
        Questao44.Nivel = 5;
        Questao44.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao44.pergunta = "Qual é o maior oceano do mundo?";
        Questao44.resposta1 = "Oceano Atlântico";
        Questao44.resposta2 = "Oceano Índico";
        Questao44.resposta3 = "Oceano Pacífico";
        Questao44.resposta4 = "Oceano Ártico";
        Questao44.resposta5 = "Oceano Antártico";
        Questao44.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao44);

        var Questao45 = new Questao();
        Questao45.Nivel = 5;
        Questao45.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao45.pergunta = "Quem pintou a 'Monalisa'?";
        Questao45.resposta1 = "Pablo Picasso";
        Questao45.resposta2 = "Vincent van Gogh";
        Questao45.resposta3 = "Leonardo da Vinci";
        Questao45.resposta4 = "Michelangelo";
        Questao45.resposta5 = "Rembrandt";
        Questao45.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao45);

        var Questao46 = new Questao();
        Questao46.Nivel = 5;
        Questao46.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao46.pergunta = "Qual é a montanha mais alta do mundo?";
        Questao46.resposta1 = "K2";
        Questao46.resposta2 = "Kangchenjunga";
        Questao46.resposta3 = "Everest";
        Questao46.resposta4 = "Lhotse";
        Questao46.resposta5 = "Makalu";
        Questao46.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao46);

        var Questao47 = new Questao();
        Questao47.Nivel = 5;
        Questao47.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao47.pergunta = "Qual é a língua oficial do Brasil?";
        Questao47.resposta1 = "Espanhol";
        Questao47.resposta2 = "Inglês";
        Questao47.resposta3 = "Português";
        Questao47.resposta4 = "Francês";
        Questao47.resposta5 = "Italiano";
        Questao47.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao47);

        var Questao48 = new Questao();
        Questao48.Nivel = 5;
        Questao48.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao48.pergunta = "Qual é o maior país do mundo em área territorial?";
        Questao48.resposta1 = "Estados Unidos";
        Questao48.resposta2 = "China";
        Questao48.resposta3 = "Canadá";
        Questao48.resposta4 = "Rússia";
        Questao48.resposta5 = "Brasil";
        Questao48.respostacorreta = 4;
        ListaTodasQuestoes.Add(Questao48);

        var Questao49 = new Questao();
        Questao49.Nivel = 5;
        Questao49.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao49.pergunta = "Qual é o símbolo químico do ouro?";
        Questao49.resposta1 = "Au";
        Questao49.resposta2 = "Ag";
        Questao49.resposta3 = "Fe";
        Questao49.resposta4 = "Hg";
        Questao49.resposta5 = "Pb";
        Questao49.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao49);

        var Questao50 = new Questao();
        Questao50.Nivel = 5;
        Questao50.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao50.pergunta = "Quem é conhecido como o 'Pai da Psicanálise'?";
        Questao50.resposta1 = "Carl Jung";
        Questao50.resposta2 = "Sigmund Freud";
        Questao50.resposta3 = "B.F. Skinner";
        Questao50.resposta4 = "Albert Bandura";
        Questao50.resposta5 = "Erik Erikson";
        Questao50.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao50);

        var Questao51 = new Questao();
        Questao51.Nivel = 6;
        Questao51.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao51.pergunta = "Qual é o nome do famoso relógio localizado em Londres?";
        Questao51.resposta1 = "Big Ben";
        Questao51.resposta2 = "Torre Eiffel";
        Questao51.resposta3 = "Torre de Pisa";
        Questao51.resposta4 = "Cristo Redentor";
        Questao51.resposta5 = "Estátua da Liberdade";
        Questao51.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao51);

        var Questao52 = new Questao();
        Questao52.Nivel = 6;
        Questao52.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao52.pergunta = "Qual é a capital da Austrália?";
        Questao52.resposta1 = "Sydney";
        Questao52.resposta2 = "Melbourne";
        Questao52.resposta3 = "Canberra";
        Questao52.resposta4 = "Brisbane";
        Questao52.resposta5 = "Perth";
        Questao52.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao52);

        var Questao53 = new Questao();
        Questao53.Nivel = 6;
        Questao53.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao53.pergunta = "Qual é o nome do maior animal terrestre?";
        Questao53.resposta1 = "Elefante";
        Questao53.resposta2 = "Girafa";
        Questao53.resposta3 = "Rinoceronte";
        Questao53.resposta4 = "Hipopótamo";
        Questao53.resposta5 = "Tigre";
        Questao53.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao53);

        var Questao54 = new Questao();
        Questao54.Nivel = 6;
        Questao54.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao54.pergunta = "Quem foi o autor de '1984'?";
        Questao54.resposta1 = "Aldous Huxley";
        Questao54.resposta2 = "George Orwell";
        Questao54.resposta3 = "Ray Bradbury";
        Questao54.resposta4 = "Margaret Atwood";
        Questao54.resposta5 = "Isaac Asimov";
        Questao54.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao54);

        var Questao55 = new Questao();
        Questao55.Nivel = 6;
        Questao55.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao55.pergunta = "Qual é a capital da Islândia?";
        Questao55.resposta1 = "Oslo";
        Questao55.resposta2 = "Reykjavík";
        Questao55.resposta3 = "Copenhague";
        Questao55.resposta4 = "Estocolmo";
        Questao55.resposta5 = "Helsinque";
        Questao55.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao55);

        var Questao56 = new Questao();
        Questao56.Nivel = 6;
        Questao56.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao56.pergunta = "Qual é o maior planeta do Sistema Solar?";
        Questao56.resposta1 = "Saturno";
        Questao56.resposta2 = "Júpiter";
        Questao56.resposta3 = "Netuno";
        Questao56.resposta4 = "Urano";
        Questao56.resposta5 = "Marte";
        Questao56.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao56);

        var Questao57 = new Questao();
        Questao57.Nivel = 6;
        Questao57.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao57.pergunta = "Qual é a moeda oficial da União Europeia?";
        Questao57.resposta1 = "Dólar";
        Questao57.resposta2 = "Libra Esterlina";
        Questao57.resposta3 = "Franco Suíço";
        Questao57.resposta4 = "Euro";
        Questao57.resposta5 = "Coroa Sueca";
        Questao57.respostacorreta = 4;
        ListaTodasQuestoes.Add(Questao57);

        var Questao58 = new Questao();
        Questao58.Nivel = 6;
        Questao58.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao58.pergunta = "Qual é a fórmula química do gás carbônico?";
        Questao58.resposta1 = "CO";
        Questao58.resposta2 = "CO2";
        Questao58.resposta3 = "C2O";
        Questao58.resposta4 = "C3O2";
        Questao58.resposta5 = "C2H2";
        Questao58.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao58);

        var Questao59 = new Questao();
        Questao59.Nivel = 6;
        Questao59.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao59.pergunta = "Quem pintou o teto da Capela Sistina?";
        Questao59.resposta1 = "Raphael";
        Questao59.resposta2 = "Leonardo da Vinci";
        Questao59.resposta3 = "Michelangelo";
        Questao59.resposta4 = "Caravaggio";
        Questao59.resposta5 = "Donatello";
        Questao59.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao59);

        var Questao60 = new Questao();
        Questao60.Nivel = 6;
        Questao60.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao60.pergunta = "Qual é a unidade de medida da pressão?";
        Questao60.resposta1 = "Pascal";
        Questao60.resposta2 = "Joule";
        Questao60.resposta3 = "Newton";
        Questao60.resposta4 = "Volt";
        Questao60.resposta5 = "Ampère";
        Questao60.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao60);

        var Questao61 = new Questao();
        Questao61.Nivel = 7;
        Questao61.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao61.pergunta = "Qual é o nome da obra mais famosa de Shakespeare?";
        Questao61.resposta1 = "Hamlet";
        Questao61.resposta2 = "Othello";
        Questao61.resposta3 = "Romeu e Julieta";
        Questao61.resposta4 = "Macbeth";
        Questao61.resposta5 = "Sonetos";
        Questao61.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao61);

        var Questao62 = new Questao();
        Questao62.Nivel = 7;
        Questao62.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao62.pergunta = "Qual é a capital da Nova Zelândia?";
        Questao62.resposta1 = "Auckland";
        Questao62.resposta2 = "Wellington";
        Questao62.resposta3 = "Christchurch";
        Questao62.resposta4 = "Hamilton";
        Questao62.resposta5 = "Dunedin";
        Questao62.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao62);

        var Questao63 = new Questao();
        Questao63.Nivel = 7;
        Questao63.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao63.pergunta = "Qual é a principal religião do Japão?";
        Questao63.resposta1 = "Cristianismo";
        Questao63.resposta2 = "Islamismo";
        Questao63.resposta3 = "Xintoísmo";
        Questao63.resposta4 = "Budismo";
        Questao63.resposta5 = "Hinduísmo";
        Questao63.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao63);

        var Questao64 = new Questao();
        Questao64.Nivel = 7;
        Questao64.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao64.pergunta = "Qual é o nome do primeiro livro da Bíblia?";
        Questao64.resposta1 = "Êxodo";
        Questao64.resposta2 = "Levítico";
        Questao64.resposta3 = "Gênesis";
        Questao64.resposta4 = "Números";
        Questao64.resposta5 = "Deuteronômio";
        Questao64.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao64);

        var Questao65 = new Questao();
        Questao65.Nivel = 7;
        Questao65.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao65.pergunta = "Qual é a fórmula química do sal de cozinha?";
        Questao65.resposta1 = "NaCl";
        Questao65.resposta2 = "KCl";
        Questao65.resposta3 = "MgCl2";
        Questao65.resposta4 = "CaCl2";
        Questao65.resposta5 = "Na2SO4";
        Questao65.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao65);

        var Questao66 = new Questao();
        Questao66.Nivel = 7;
        Questao66.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao66.pergunta = "Qual é o planeta conhecido como 'Planeta Vermelho'?";
        Questao66.resposta1 = "Marte";
        Questao66.resposta2 = "Vênus";
        Questao66.resposta3 = "Júpiter";
        Questao66.resposta4 = "Mercúrio";
        Questao66.resposta5 = "Saturno";
        Questao66.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao66);

        var Questao67 = new Questao();
        Questao67.Nivel = 7;
        Questao67.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao67.pergunta = "Qual é a capital da Grécia?";
        Questao67.resposta1 = "Atenas";
        Questao67.resposta2 = "Tóquio";
        Questao67.resposta3 = "Roma";
        Questao67.resposta4 = "Lisboa";
        Questao67.resposta5 = "Berlim";
        Questao67.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao67);

        var Questao68 = new Questao();
        Questao68.Nivel = 7;
        Questao68.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao68.pergunta = "Qual é a capital do Canadá?";
        Questao68.resposta1 = "Toronto";
        Questao68.resposta2 = "Vancouver";
        Questao68.resposta3 = "Ottawa";
        Questao68.resposta4 = "Montreal";
        Questao68.resposta5 = "Calgary";
        Questao68.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao68);

        var Questao69 = new Questao();
        Questao69.Nivel = 7;
        Questao69.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao69.pergunta = "Qual é o símbolo químico do hidrogênio?";
        Questao69.resposta1 = "H";
        Questao69.resposta2 = "He";
        Questao69.resposta3 = "O";
        Questao69.resposta4 = "N";
        Questao69.resposta5 = "C";
        Questao69.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao69);

        var Questao70 = new Questao();
        Questao70.Nivel = 7;
        Questao70.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao70.pergunta = "Quem é conhecido como o 'Rei do Pop'?";
        Questao70.resposta1 = "Elvis Presley";
        Questao70.resposta2 = "Michael Jackson";
        Questao70.resposta3 = "Prince";
        Questao70.resposta4 = "Madonna";
        Questao70.resposta5 = "Freddie Mercury";
        Questao70.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao70);

        var Questao71 = new Questao();
        Questao71.Nivel = 8;
        Questao71.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao71.pergunta = "Qual é o nome do sistema que classifica os seres vivos?";
        Questao71.resposta1 = "Taxonomia";
        Questao71.resposta2 = "Anatomia";
        Questao71.resposta3 = "Evolução";
        Questao71.resposta4 = "Genética";
        Questao71.resposta5 = "Citoquímica";
        Questao71.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao71);

        var Questao72 = new Questao();
        Questao72.Nivel = 8;
        Questao72.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao72.pergunta = "Quem escreveu 'Dom Quixote'?";
        Questao72.resposta1 = "Gabriel García Márquez";
        Questao72.resposta2 = "Miguel de Cervantes";
        Questao72.resposta3 = "Jorge Luis Borges";
        Questao72.resposta4 = "William Shakespeare";
        Questao72.resposta5 = "Victor Hugo";
        Questao72.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao72);

        var Questao73 = new Questao();
        Questao73.Nivel = 8;
        Questao73.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao73.pergunta = "Qual é a principal função dos glóbulos vermelhos no sangue?";
        Questao73.resposta1 = "Defesa contra infecções";
        Questao73.resposta2 = "Transporte de oxigênio";
        Questao73.resposta3 = "Coagulação";
        Questao73.resposta4 = "Transporte de nutrientes";
        Questao73.resposta5 = "Produção de hormônios";
        Questao73.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao73);

        var Questao74 = new Questao();
        Questao74.Nivel = 8;
        Questao74.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao74.pergunta = "Qual é a maior floresta tropical do mundo?";
        Questao74.resposta1 = "Floresta Amazônica";
        Questao74.resposta2 = "Floresta do Congo";
        Questao74.resposta3 = "Floresta de Taiga";
        Questao74.resposta4 = "Floresta Boreal";
        Questao74.resposta5 = "Floresta Atlântica";
        Questao74.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao74);

        var Questao75 = new Questao();
        Questao75.Nivel = 8;
        Questao75.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao75.pergunta = "Qual é a capital da Rússia?";
        Questao75.resposta1 = "São Petersburgo";
        Questao75.resposta2 = "Moscovo";
        Questao75.resposta3 = "Kiev";
        Questao75.resposta4 = "Tóquio";
        Questao75.resposta5 = "Pequim";
        Questao75.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao75);

        var Questao76 = new Questao();
        Questao76.Nivel = 8;
        Questao76.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao76.pergunta = "Qual é o elemento químico com o símbolo 'Na'?";
        Questao76.resposta1 = "Nitrogênio";
        Questao76.resposta2 = "Sódio";
        Questao76.resposta3 = "Alumínio";
        Questao76.resposta4 = "Nátron";
        Questao76.resposta5 = "Cálcio";
        Questao76.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao76);

        var Questao77 = new Questao();
        Questao77.Nivel = 8;
        Questao77.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao77.pergunta = "Quem escreveu 'A Divina Comédia'?";
        Questao77.resposta1 = "Dante Alighieri";
        Questao77.resposta2 = "Homer";
        Questao77.resposta3 = "Virgílio";
        Questao77.resposta4 = "Boccaccio";
        Questao77.resposta5 = "Petrarca";
        Questao77.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao77);

        var Questao78 = new Questao();
        Questao78.Nivel = 8;
        Questao78.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao78.pergunta = "Qual é o nome do processo pelo qual as plantas produzem seu próprio alimento?";
        Questao78.resposta1 = "Fotossíntese";
        Questao78.resposta2 = "Respiração";
        Questao78.resposta3 = "Transpiração";
        Questao78.resposta4 = "Digestão";
        Questao78.resposta5 = "Fermentação";
        Questao78.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao78);

        var Questao79 = new Questao();
        Questao79.Nivel = 8;
        Questao79.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao79.pergunta = "Qual é o nome do famoso monumento que representa o Cristo Redentor?";
        Questao79.resposta1 = "Cristo da Aparecida";
        Questao79.resposta2 = "Cristo do Corcovado";
        Questao79.resposta3 = "Cristo de Lisboa";
        Questao79.resposta4 = "Cristo de Assunção";
        Questao79.resposta5 = "Cristo de Buenos Aires";
        Questao79.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao79);

        var Questao80 = new Questao();
        Questao80.Nivel = 8;
        Questao80.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao80.pergunta = "Qual é o maior oceano do mundo?";
        Questao80.resposta1 = "Oceano Atlântico";
        Questao80.resposta2 = "Oceano Índico";
        Questao80.resposta3 = "Oceano Pacífico";
        Questao80.resposta4 = "Oceano Ártico";
        Questao80.resposta5 = "Oceano Antártico";
        Questao80.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao80);

        var Questao81 = new Questao();
        Questao81.Nivel = 9;
        Questao81.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao81.pergunta = "Qual é o autor da teoria da relatividade?";
        Questao81.resposta1 = "Isaac Newton";
        Questao81.resposta2 = "Niels Bohr";
        Questao81.resposta3 = "Albert Einstein";
        Questao81.resposta4 = "Galileu Galilei";
        Questao81.resposta5 = "Stephen Hawking";
        Questao81.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao81);

        var Questao82 = new Questao();
        Questao82.Nivel = 9;
        Questao82.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao82.pergunta = "Qual é a capital da Austrália?";
        Questao82.resposta1 = "Sydney";
        Questao82.resposta2 = "Melbourne";
        Questao82.resposta3 = "Canberra";
        Questao82.resposta4 = "Brisbane";
        Questao82.resposta5 = "Perth";
        Questao82.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao82);

        var Questao83 = new Questao();
        Questao83.Nivel = 9;
        Questao83.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao83.pergunta = "Qual é a fórmula química da água?";
        Questao83.resposta1 = "H2O";
        Questao83.resposta2 = "CO2";
        Questao83.resposta3 = "O2";
        Questao83.resposta4 = "H2O2";
        Questao83.resposta5 = "C6H12O6";
        Questao83.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao83);

        var Questao84 = new Questao();
        Questao84.Nivel = 9;
        Questao84.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao84.pergunta = "Qual é a capital da Espanha?";
        Questao84.resposta1 = "Madri";
        Questao84.resposta2 = "Barcelona";
        Questao84.resposta3 = "Sevilha";
        Questao84.resposta4 = "Valência";
        Questao84.resposta5 = "Bilbau";
        Questao84.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao84);

        var Questao85 = new Questao();
        Questao85.Nivel = 9;
        Questao85.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao85.pergunta = "Quem escreveu 'Dom Casmurro'?";
        Questao85.resposta1 = "Machado de Assis";
        Questao85.resposta2 = "José de Alencar";
        Questao85.resposta3 = "Graciliano Ramos";
        Questao85.resposta4 = "Jorge Amado";
        Questao85.resposta5 = "Raquel de Queiroz";
        Questao85.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao85);

        var Questao86 = new Questao();
        Questao86.Nivel = 9;
        Questao86.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao86.pergunta = "Qual é a moeda oficial do Japão?";
        Questao86.resposta1 = "Yuan";
        Questao86.resposta2 = "Won";
        Questao86.resposta3 = "Dólar";
        Questao86.resposta4 = "Iene";
        Questao86.resposta5 = "Peso";
        Questao86.respostacorreta = 4;
        ListaTodasQuestoes.Add(Questao86);

        var Questao87 = new Questao();
        Questao87.Nivel = 9;
        Questao87.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao87.pergunta = "Qual é o planeta mais próximo do Sol?";
        Questao87.resposta1 = "Vênus";
        Questao87.resposta2 = "Terra";
        Questao87.resposta3 = "Mercúrio";
        Questao87.resposta4 = "Marte";
        Questao87.resposta5 = "Júpiter";
        Questao87.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao87);

        var Questao88 = new Questao();
        Questao88.Nivel = 9;
        Questao88.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao88.pergunta = "Qual é o maior animal terrestre?";
        Questao88.resposta1 = "Girafa";
        Questao88.resposta2 = "Elefante Africano";
        Questao88.resposta3 = "Rinoceronte";
        Questao88.resposta4 = "Hipopótamo";
        Questao88.resposta5 = "Urso Polar";
        Questao88.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao88);

        var Questao89 = new Questao();
        Questao89.Nivel = 9;
        Questao89.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao89.pergunta = "Qual é a principal fonte de energia da Terra?";
        Questao89.resposta1 = "Vento";
        Questao89.resposta2 = "Sol";
        Questao89.resposta3 = "Água";
        Questao89.resposta4 = "Carvão";
        Questao89.resposta5 = "Gás Natural";
        Questao89.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao89);

        var Questao90 = new Questao();
        Questao90.Nivel = 9;
        Questao90.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao90.pergunta = "Qual é o elemento químico com símbolo 'O'?";
        Questao90.resposta1 = "Ouro";
        Questao90.resposta2 = "Oxigênio";
        Questao90.resposta3 = "Ósmio";
        Questao90.resposta4 = "Oganessônio";
        Questao90.resposta5 = "Ondínio";
        Questao90.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao90);

        var Questao91 = new Questao();
        Questao91.Nivel = 10;
        Questao91.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao91.pergunta = "Qual país é conhecido como a Terra do Sol Nascente?";
        Questao91.resposta1 = "China";
        Questao91.resposta2 = "Coreia do Sul";
        Questao91.resposta3 = "Japão";
        Questao91.resposta4 = "Tailândia";
        Questao91.resposta5 = "Filipinas";
        Questao91.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao91);

        var Questao92 = new Questao();
        Questao92.Nivel = 10;
        Questao92.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao92.pergunta = "Qual é o maior órgão do corpo humano?";
        Questao92.resposta1 = "Coração";
        Questao92.resposta2 = "Fígado";
        Questao92.resposta3 = "Pele";
        Questao92.resposta4 = "Pulmão";
        Questao92.resposta5 = "Rim";
        Questao92.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao92);

        var Questao93 = new Questao();
        Questao93.Nivel = 10;
        Questao93.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao93.pergunta = "Qual é a capital da Itália?";
        Questao93.resposta1 = "Roma";
        Questao93.resposta2 = "Veneza";
        Questao93.resposta3 = "Milão";
        Questao93.resposta4 = "Nápoles";
        Questao93.resposta5 = "Florença";
        Questao93.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao93);

        var Questao94 = new Questao();
        Questao94.Nivel = 10;
        Questao94.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao94.pergunta = "Qual é a fórmula química do sal de cozinha?";
        Questao94.resposta1 = "NaCl";
        Questao94.resposta2 = "KCl";
        Questao94.resposta3 = "CaCO3";
        Questao94.resposta4 = "HCl";
        Questao94.resposta5 = "NH4Cl";
        Questao94.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao94);

        var Questao95 = new Questao();
        Questao95.Nivel = 10;
        Questao95.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao95.pergunta = "Qual é o animal símbolo da Austrália?";
        Questao95.resposta1 = "Canguru";
        Questao95.resposta2 = "Koala";
        Questao95.resposta3 = "Emu";
        Questao95.resposta4 = "Dingo";
        Questao95.resposta5 = "Wallaby";
        Questao95.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao95);

        var Questao96 = new Questao();
        Questao96.Nivel = 10;
        Questao96.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao96.pergunta = "Qual é a força que puxa os objetos em direção à Terra?";
        Questao96.resposta1 = "Magnetismo";
        Questao96.resposta2 = "Inércia";
        Questao96.resposta3 = "Gravidade";
        Questao96.resposta4 = "Fricção";
        Questao96.resposta5 = "Empuxo";
        Questao96.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao96);

        var Questao97 = new Questao();
        Questao97.Nivel = 10;
        Questao97.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao97.pergunta = "Qual é a unidade de medida da pressão?";
        Questao97.resposta1 = "Joule";
        Questao97.resposta2 = "Pascal";
        Questao97.resposta3 = "Newton";
        Questao97.resposta4 = "Watt";
        Questao97.resposta5 = "Ampere";
        Questao97.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao97);

        var Questao98 = new Questao();
        Questao98.Nivel = 10;
        Questao98.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao98.pergunta = "Qual é o principal gás que compõe a atmosfera terrestre?";
        Questao98.resposta1 = "Oxigênio";
        Questao98.resposta2 = "Nitrogênio";
        Questao98.resposta3 = "Dióxido de Carbono";
        Questao98.resposta4 = "Hélio";
        Questao98.resposta5 = "Argônio";
        Questao98.respostacorreta = 2;
        ListaTodasQuestoes.Add(Questao98);

        var Questao99 = new Questao();
        Questao99.Nivel = 10;
        Questao99.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao99.pergunta = "Qual é o processo pelo qual as plantas produzem seu alimento?";
        Questao99.resposta1 = "Respiração";
        Questao99.resposta2 = "Fermentação";
        Questao99.resposta3 = "Fotossíntese";
        Questao99.resposta4 = "Digestão";
        Questao99.resposta5 = "Transpiração";
        Questao99.respostacorreta = 3;
        ListaTodasQuestoes.Add(Questao99);

        var Questao100 = new Questao();
        Questao100.Nivel = 10;
        Questao100.ConfigurarEstruturaDesenho(labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
        Questao100.pergunta = "Qual é a capital da Alemanha?";
        Questao100.resposta1 = "Berlim";
        Questao100.resposta2 = "Munique";
        Questao100.resposta3 = "Hamburgo";
        Questao100.resposta4 = "Colônia";
        Questao100.resposta5 = "Frankfurt";
        Questao100.respostacorreta = 1;
        ListaTodasQuestoes.Add(Questao100);

        ProximaQuestao();
    }
    public void ProximaQuestao()
    {
        var ListaQuestoes = ListaTodasQuestoes.Where(d => d.Nivel == NivelAtual).ToList();
        var NumAlet = Random.Shared.Next(0, ListaQuestoes.Count - 1);
        var NovaQuestao = ListaQuestoes[NumAlet];
        while (ListaTodasQuestoesRespondidas.Contains(NovaQuestao))
        {
            NumAlet = Random.Shared.Next(0, ListaQuestoes.Count - 1);
            NovaQuestao = ListaQuestoes[NumAlet];
        }
        ListaTodasQuestoesRespondidas.Add(NovaQuestao);
        QuestaoCorrente = NovaQuestao;
        QuestaoCorrente.desenhar();
    }
    public int Pontuacao { get; private set; }
    int NivelAtual = 1;
    void Inicializar()
    {
        ListaTodasQuestoesRespondidas.Clear();
        Pontuacao = 0;
        NivelAtual = 1;
        ProximaQuestao();
    }
    public async void VerificaResposta(int RR)
    {
        if (QuestaoCorrente.VerificaResposta(RR))
        {
            await Task.Delay(1000);
            AdicionaPontuacao(NivelAtual);
            NivelAtual++;
            if (NivelAtual == 10)
                await App.Current.MainPage.DisplayAlert("VOCÊ ACERTOU TUDO!", "PARABÉNS!", "OK");
            ProximaQuestao();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("GAME OVER", "VOCÊ ERROU", "OK");
            Inicializar();
        }
        labelPontuacao.Text = "Pontuação: R$" + Pontuacao.ToString();
        labelNivel.Text = "Nível:" + NivelAtual.ToString();

    }
    void AdicionaPontuacao(int n)
    {
        if (n == 1)
            Pontuacao = 1000;
        else if (n == 2)
            Pontuacao = 2000;
        else if (n == 3)
            Pontuacao = 5000;
        else if (n == 4)
            Pontuacao = 10000;
        else if (n == 5)
            Pontuacao = 20000;
        else if (n == 6)
            Pontuacao = 50000;
        else if (n == 7)
            Pontuacao = 100000;
        else if (n == 8)
            Pontuacao = 200000;
        else if (n == 9)
            Pontuacao = 500000;
        else
            Pontuacao = 1000000;
    }
}