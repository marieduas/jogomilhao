namespace jogomilhao;

public class Gerenciador
{
    List<Questao> ListaQuestao = new List<Questao>();
    List<int> ListasQuestaoRespondidas = new List<int>();

    Questao QuestaoAtual;
    Label labelPontuacao;
    Label labelNivel;
    public Gerenciador(Label labelPontuacao,Label labelPergunta,Label labelnivel, Button buttonrep1, Button buttonrep2, Button buttonrep3, Button buttonrep4, Button buttonrep5)
    {
        this.labelPontuacao = labelPontuacao;
        this.labelNivel = labelNivel;
        CriarPergunta(labelPergunta, buttonrep1, buttonrep2, buttonrep3, buttonrep4, buttonrep5);
    }

    void CriarPergunta(Label per, Button buttonrep1, Button bot2, Button bot3, Button bot4, Button bot5)
    {
        //nivel 1
        var Q1 = new Questao();
        Q1.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q1.questaoi = "Quanto é 40+30?";
        Q1.resposta1 = "1";
        Q1.resposta2 = "16";
        Q1.resposta3 = "60";
        Q1.resposta5 = "70";
        Q1.RespostaC = 5;
        ListaQuestao.Add(Q1);
        ProximaQuestao();

        var Q2 = new Questao();
        Q1.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q1.questaoi = "Quanto é 2 + 2?";
        Q1.resposta1 = "3";
        Q1.resposta2 = "4";
        Q1.resposta3 = "5";
        Q1.resposta4 = "6";
        Q1.resposta5 = "7";
        Q1.RespostaC = 2;
        ListaQuestao.Add(Q1);

        var Q3 = new Questao();
        Q2.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q2.questaoi = "Qual a capital da França?";
        Q2.resposta1 = "Madrid";
        Q2.resposta2 = "Berlim";
        Q2.resposta3 = "Paris";
        Q2.resposta4 = "Lisboa";
        Q2.resposta5 = "Roma";
        Q2.RespostaC = 3;
        ListaQuestao.Add(Q2);

        var Q4 = new Questao();
        Q3.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q3.questaoi = "Qual é a cor do céu em um dia claro?";
        Q3.resposta1 = "Verde";
        Q3.resposta2 = "Azul";
        Q3.resposta3 = "Amarelo";
        Q3.resposta4 = "Vermelho";
        Q3.resposta5 = "Roxo";
        Q3.RespostaC = 2;
        ListaQuestao.Add(Q3);

        var Q5 = new Questao();
        Q4.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q4.questaoi = "Quantos dias tem uma semana?";
        Q4.resposta1 = "5";
        Q4.resposta2 = "6";
        Q4.resposta3 = "7";
        Q4.resposta4 = "8";
        Q4.resposta5 = "9";
        Q4.RespostaC = 3;
        ListaQuestao.Add(Q4);

        var Q6 = new Questao();
        Q5.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q5.questaoi = "Qual é o animal conhecido como 'rei da selva'?";
        Q5.resposta1 = "Leão";
        Q5.resposta2 = "Tigre";
        Q5.resposta3 = "Elefante";
        Q5.resposta4 = "Urso";
        Q5.resposta5 = "Lobo";
        Q5.RespostaC = 1;
        ListaQuestao.Add(Q5);

        var Q7 = new Questao();
        Q6.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q6.questaoi = "Qual é o primeiro mês do ano?";
        Q6.resposta1 = "Fevereiro";
        Q6.resposta2 = "Março";
        Q6.resposta3 = "Janeiro";
        Q6.resposta4 = "Abril";
        Q6.resposta5 = "Maio";
        Q6.RespostaC = 3;
        ListaQuestao.Add(Q6);

        var Q8 = new Questao();
        Q7.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q7.questaoi = "Qual é a moeda do Brasil?";
        Q7.resposta1 = "Dólar";
        Q7.resposta2 = "Euro";
        Q7.resposta3 = "Real";
        Q7.resposta4 = "Peso";
        Q7.resposta5 = "Libra";
        Q7.RespostaC = 3;
        ListaQuestao.Add(Q7);

        var Q9 = new Questao();
        Q8.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q8.questaoi = "Qual é o maior mamífero do mundo?";
        Q8.resposta1 = "Elefante";
        Q8.resposta2 = "Baleia Azul";
        Q8.resposta3 = "Girafa";
        Q8.resposta4 = "Orca";
        Q8.resposta5 = "Rinoceronte";
        Q8.RespostaC = 2;
        ListaQuestao.Add(Q8);

        var Q10 = new Questao();
        Q9.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q9.questaoi = "Quantas letras tem o alfabeto português?";
        Q9.resposta1 = "24";
        Q9.resposta2 = "26";
        Q9.resposta3 = "27";
        Q9.resposta4 = "28";
        Q9.resposta5 = "29";
        Q9.RespostaC = 2;
        ListaQuestao.Add(Q9);

        //nivel 2
        var Q11 = new Questao();
        Q11.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q11.questaoi = "Qual é a raiz quadrada de 16?";
        Q11.resposta1 = "2";
        Q11.resposta2 = "4";
        Q11.resposta3 = "8";
        Q11.resposta4 = "10";
        Q11.resposta5 = "6";
        Q11.RespostaC = 2;
        ListaQuestao.Add(Q11);

        var Q12 = new Questao();
        Q12.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q12.questaoi = "Quantos continentes existem no mundo?";
        Q12.resposta1 = "5";
        Q12.resposta2 = "6";
        Q12.resposta3 = "7";
        Q12.resposta4 = "8";
        Q12.resposta5 = "9";
        Q12.RespostaC = 3;
        ListaQuestao.Add(Q12);

        var Q13 = new Questao();
        Q13.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q13.questaoi = "Qual é a soma de 10 + 15?";
        Q13.resposta1 = "20";
        Q13.resposta2 = "25";
        Q13.resposta3 = "30";
        Q13.resposta4 = "15";
        Q13.resposta5 = "35";
        Q13.RespostaC = 2;
        ListaQuestao.Add(Q13);

        var Q14 = new Questao();
        Q14.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q14.questaoi = "Qual é a capital da Itália?";
        Q14.resposta1 = "Roma";
        Q14.resposta2 = "Milão";
        Q14.resposta3 = "Veneza";
        Q14.resposta4 = "Florença";
        Q14.resposta5 = "Nápoles";
        Q14.RespostaC = 1;
        ListaQuestao.Add(Q14);

        var Q15 = new Questao();
        Q15.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q15.questaoi = "Qual é o planeta mais próximo do sol?";
        Q15.resposta1 = "Vênus";
        Q15.resposta2 = "Terra";
        Q15.resposta3 = "Mercúrio";
        Q15.resposta4 = "Marte";
        Q15.resposta5 = "Júpiter";
        Q15.RespostaC = 3;
        ListaQuestao.Add(Q15);

        var Q16 = new Questao();
        Q16.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q16.questaoi = "Quem é o autor de 'Harry Potter'?";
        Q16.resposta1 = "J.R.R. Tolkien";
        Q16.resposta2 = "J.K. Rowling";
        Q16.resposta3 = "C.S. Lewis";
        Q16.resposta4 = "George R.R. Martin";
        Q16.resposta5 = "Agatha Christie";
        Q16.RespostaC = 2;
        ListaQuestao.Add(Q16);

        var Q17 = new Questao();
        Q17.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q17.questaoi = "Qual é a fórmula química do gás carbônico?";
        Q17.resposta1 = "O2";
        Q17.resposta2 = "H2O";
        Q17.resposta3 = "CO2";
        Q17.resposta4 = "NaCl";
        Q17.resposta5 = "CH4";
        Q17.RespostaC = 3;
        ListaQuestao.Add(Q17);

        var Q18 = new Questao();
        Q18.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q18.questaoi = "Qual é o nome do processo pelo qual as plantas fazem fotossíntese?";
        Q18.resposta1 = "Respiração";
        Q18.resposta2 = "Fermentação";
        Q18.resposta3 = "Transpiração";
        Q18.resposta4 = "Fotossíntese";
        Q18.resposta5 = "Digestão";
        Q18.RespostaC = 4;
        ListaQuestao.Add(Q18);

        var Q19 = new Questao();
        Q19.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q19.questaoi = "Quantos meses têm 30 dias?";
        Q19.resposta1 = "4";
        Q19.resposta2 = "5";
        Q19.resposta3 = "6";
        Q19.resposta4 = "7";
        Q19.resposta5 = "8";
        Q19.RespostaC = 1;
        ListaQuestao.Add(Q19);

        var Q20 = new Questao();
        Q20.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q20.questaoi = "Qual é o maior oceano do mundo?";
        Q20.resposta1 = "Atlântico";
        Q20.resposta2 = "Índico";
        Q20.resposta3 = "Ártico";
        Q20.resposta4 = "Pacífico";
        Q20.resposta5 = "Antártico";
        Q20.RespostaC = 4;
        ListaQuestao.Add(Q20);

        //nivel 3
        var Q21 = new Questao();
        Q21.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q21.questaoi = "Quem escreveu 'Dom Casmurro'?";
        Q21.resposta1 = "Machado de Assis";
        Q21.resposta2 = "José de Alencar";
        Q21.resposta3 = "Clarice Lispector";
        Q21.resposta4 = "Jorge Amado";
        Q21.resposta5 = "Graciliano Ramos";
        Q21.RespostaC = 1;
        ListaQuestao.Add(Q21);

        var Q22 = new Questao();
        Q21.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q21.questaoi = "Qual é a capital da Austrália?";
        Q21.resposta1 = "Sydney";
        Q21.resposta2 = "Canberra";
        Q21.resposta3 = "Melbourne";
        Q21.resposta4 = "Brisbane";
        Q21.resposta5 = "Perth";
        Q21.RespostaC = 2;
        ListaQuestao.Add(Q22);

        var Q23 = new Questao();
        Q22.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q22.questaoi = "Em que ano foi a Independência do Brasil?";
        Q22.resposta1 = "1822";
        Q22.resposta2 = "1888";
        Q22.resposta3 = "1500";
        Q22.resposta4 = "1930";
        Q22.resposta5 = "1964";
        Q22.RespostaC = 1;
        ListaQuestao.Add(Q23);

        var Q24 = new Questao();
        Q23.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q23.questaoi = "Qual é o maior deserto do mundo?";
        Q23.resposta1 = "Sahara";
        Q23.resposta2 = "Gobi";
        Q23.resposta3 = "Ártico";
        Q23.resposta4 = "Antártico";
        Q23.resposta5 = "Kalahari";
        Q23.RespostaC = 4;
        ListaQuestao.Add(Q24);

        var Q25 = new Questao();
        Q24.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q24.questaoi = "Quem foi o primeiro homem a pisar na Lua?";
        Q24.resposta1 = "Yuri Gagarin";
        Q24.resposta2 = "Buzz Aldrin";
        Q24.resposta3 = "Neil Armstrong";
        Q24.resposta4 = "Michael Collins";
        Q24.resposta5 = "John Glenn";
        Q24.RespostaC = 3;
        ListaQuestao.Add(Q25);

        var Q26 = new Questao();
        Q25.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q25.questaoi = "Qual é o maior país do mundo?";
        Q25.resposta1 = "Canadá";
        Q25.resposta2 = "China";
        Q25.resposta3 = "Estados Unidos";
        Q25.resposta4 = "Rússia";
        Q25.resposta5 = "Brasil";
        Q25.RespostaC = 4;
        ListaQuestao.Add(Q26);

        var Q27 = new Questao();
        Q26.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q26.questaoi = "Qual é o símbolo químico do ferro?";
        Q26.resposta1 = "Fe";
        Q26.resposta2 = "F";
        Q26.resposta3 = "Ir";
        Q26.resposta4 = "Fr";
        Q26.resposta5 = "Au";
        Q26.RespostaC = 1;
        ListaQuestao.Add(Q27);

        var Q28 = new Questao();
        Q27.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q27.questaoi = "Quem é conhecido como o 'pai da psicanálise'?";
        Q27.resposta1 = "Carl Jung";
        Q27.resposta2 = "Sigmund Freud";
        Q27.resposta3 = "Alfred Adler";
        Q27.resposta4 = "Ivan Pavlov";
        Q27.resposta5 = "Jean Piaget";
        Q27.RespostaC = 2;
        ListaQuestao.Add(Q28);

        var Q29 = new Questao();
        Q28.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q28.questaoi = "Qual é a moeda oficial do Japão?";
        Q28.resposta1 = "Yuan";
        Q28.resposta2 = "Won";
        Q28.resposta3 = "Iene";
        Q28.resposta4 = "Dólar";
        Q28.resposta5 = "Euro";
        Q28.RespostaC = 3;
        ListaQuestao.Add(Q29);

        var Q30 = new Questao();
        Q29.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q29.questaoi = "Qual é o órgão responsável pela bomba do sistema circulatório?";
        Q29.resposta1 = "Cérebro";
        Q29.resposta2 = "Fígado";
        Q29.resposta3 = "Coração";
        Q29.resposta4 = "Pulmão";
        Q29.resposta5 = "Rim";
        Q29.RespostaC = 3;
        ListaQuestao.Add(Q30);

        //nivel 4
        var Q31 = new Questao();
        Q31.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q31.questaoi = "Qual é o elemento químico com símbolo 'O'?";
        Q31.resposta1 = "Ouro";
        Q31.resposta2 = "Oxigênio";
        Q31.resposta3 = "Prata";
        Q31.resposta4 = "Água";
        Q31.resposta5 = "Cobre";
        Q31.RespostaC = 2;
        ListaQuestao.Add(Q31);

        var Q32 = new Questao();
        Q32.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q32.questaoi = "Qual é o elemento químico com símbolo 'Na'?";
        Q32.resposta1 = "Nitrogênio";
        Q32.resposta2 = "Sódio";
        Q32.resposta3 = "Potássio";
        Q32.resposta4 = "Cálcio";
        Q32.resposta5 = "Magnésio";
        Q32.RespostaC = 2;
        ListaQuestao.Add(Q32);

        var Q33 = new Questao();
        Q33.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q33.questaoi = "Quem foi o primeiro presidente dos Estados Unidos?";
        Q33.resposta1 = "George Washington";
        Q33.resposta2 = "Thomas Jefferson";
        Q33.resposta3 = "Abraham Lincoln";
        Q33.resposta4 = "John Adams";
        Q33.resposta5 = "Franklin Roosevelt";
        Q33.RespostaC = 1;
        ListaQuestao.Add(Q33);

        var Q34 = new Questao();
        Q34.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q34.questaoi = "Qual é o nome do maior rio do mundo?";
        Q34.resposta1 = "Amazonas";
        Q34.resposta2 = "Nilo";
        Q34.resposta3 = "Yangtze";
        Q34.resposta4 = "Mississippi";
        Q34.resposta5 = "Ganges";
        Q34.RespostaC = 1;
        ListaQuestao.Add(Q34);

        var Q35 = new Questao();
        Q35.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q35.questaoi = "Qual é a capital da Noruega?";
        Q35.resposta1 = "Copenhague";
        Q35.resposta2 = "Oslo";
        Q35.resposta3 = "Estocolmo";
        Q35.resposta4 = "Helsinque";
        Q35.resposta5 = "Reykjavik";
        Q35.RespostaC = 2;
        ListaQuestao.Add(Q35);

        var Q36 = new Questao();
        Q36.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q36.questaoi = "Qual é a principal língua falada no Brasil?";
        Q36.resposta1 = "Espanhol";
        Q36.resposta2 = "Francês";
        Q36.resposta3 = "Português";
        Q36.resposta4 = "Inglês";
        Q36.resposta5 = "Italiano";
        Q36.RespostaC = 3;
        ListaQuestao.Add(Q36);

        var Q37 = new Questao();
        Q37.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q37.questaoi = "Em que continente fica o Egito?";
        Q37.resposta1 = "África";
        Q37.resposta2 = "Ásia";
        Q37.resposta3 = "Europa";
        Q37.resposta4 = "América";
        Q37.resposta5 = "Oceania";
        Q37.RespostaC = 1;
        ListaQuestao.Add(Q37);

        var Q38 = new Questao();
        Q38.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q38.questaoi = "Quem pintou 'A Última Ceia'?";
        Q38.resposta1 = "Michelangelo";
        Q38.resposta2 = "Leonardo da Vinci";
        Q38.resposta3 = "Raphael";
        Q38.resposta4 = "Van Gogh";
        Q38.resposta5 = "Monet";
        Q38.RespostaC = 2;
        ListaQuestao.Add(Q38);

        var Q39 = new Questao();
        Q39.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q39.questaoi = "Qual é o maior continente do mundo?";
        Q39.resposta1 = "África";
        Q39.resposta2 = "América do Sul";
        Q39.resposta3 = "Ásia";
        Q39.resposta4 = "Europa";
        Q39.resposta5 = "Oceania";
        Q39.RespostaC = 3;
        ListaQuestao.Add(Q39);

        var Q40 = new Questao();
        Q40.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q40.questaoi = "Qual é o principal gas responsável pelo efeito estufa?";
        Q40.resposta1 = "Oxigênio";
        Q40.resposta2 = "Nitrogênio";
        Q40.resposta3 = "Dióxido de carbono";
        Q40.resposta4 = "Hélio";
        Q40.resposta5 = "Metano";
        Q40.RespostaC = 3;
        ListaQuestao.Add(Q40);

        //nivel 5
        var Q41 = new Questao();
        Q41.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q41.questaoi = "Qual é o maior planeta do sistema solar?";
        Q41.resposta1 = "Terra";
        Q41.resposta2 = "Júpiter";
        Q41.resposta3 = "Marte";
        Q41.resposta4 = "Saturno";
        Q41.resposta5 = "Netuno";
        Q41.RespostaC = 2;
        ListaQuestao.Add(Q41);

        var Q42 = new Questao();
        Q42.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q42.questaoi = "Qual é a teoria que explica a origem do universo?";
        Q42.resposta1 = "Teoria da Evolução";
        Q42.resposta2 = "Teoria do Big Bang";
        Q42.resposta3 = "Teoria da Relatividade";
        Q42.resposta4 = "Teoria das Cordas";
        Q42.resposta5 = "Teoria do Caos";
        Q42.RespostaC = 2;
        ListaQuestao.Add(Q42);

        var Q43 = new Questao();
        Q43.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q43.questaoi = "Qual é o nome da obra-prima de Leonardo da Vinci que retrata uma mulher com um sorriso enigmático?";
        Q43.resposta1 = "A Última Ceia";
        Q43.resposta2 = "Mona Lisa";
        Q43.resposta3 = "A Criação de Adão";
        Q43.resposta4 = "A Escola de Atenas";
        Q43.resposta5 = "Madona das Rochas";
        Q43.RespostaC = 2;
        ListaQuestao.Add(Q43);

        var Q44 = new Questao();
        Q44.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q44.questaoi = "Quem escreveu 'Dom Quixote'?";
        Q44.resposta1 = "Gabriel García Márquez";
        Q44.resposta2 = "Miguel de Cervantes";
        Q44.resposta3 = "Jorge Luis Borges";
        Q44.resposta4 = "Mark Twain";
        Q44.resposta5 = "Victor Hugo";
        Q44.RespostaC = 2;
        ListaQuestao.Add(Q44);

        var Q45 = new Questao();
        Q45.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q45.questaoi = "Qual é a capital do Egito?";
        Q45.resposta1 = "Cairo";
        Q45.resposta2 = "Alexandria";
        Q45.resposta3 = "Luxor";
        Q45.resposta4 = "Giza";
        Q45.resposta5 = "Aswan";
        Q45.RespostaC = 1;
        ListaQuestao.Add(Q45);

        var Q46 = new Questao();
        Q46.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q46.questaoi = "Qual é a maior estrutura viva do planeta?";
        Q46.resposta1 = "A Grande Barreira de Corais";
        Q46.resposta2 = "A Floresta Amazônica";
        Q46.resposta3 = "O Cânion de Yarlung Tsangpo";
        Q46.resposta4 = "A Serra do Mar";
        Q46.resposta5 = "A Floresta de Taiga";
        Q46.RespostaC = 1;
        ListaQuestao.Add(Q46);

        var Q47 = new Questao();
        Q47.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q47.questaoi = "Qual é o nome da teoria que explica a seleção natural das espécies?";
        Q47.resposta1 = "Teoria da Evolução";
        Q47.resposta2 = "Teoria do Design Inteligente";
        Q47.resposta3 = "Teoria da Hereditariedade";
        Q47.resposta4 = "Teoria da Biogênese";
        Q47.resposta5 = "Teoria da Espontaneidade";
        Q47.RespostaC = 1;
        ListaQuestao.Add(Q47);

        var Q48 = new Questao();
        Q48.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q48.questaoi = "Qual é o nome da obra que contém os 'Princípios Matemáticos da Filosofia Natural'?";
        Q48.resposta1 = "A Origem das Espécies";
        Q48.resposta2 = "O Capital";
        Q48.resposta3 = "Principia Mathematica";
        Q48.resposta4 = "A Interpretação das Culturas";
        Q48.resposta5 = "Os Ensaios";
        Q48.RespostaC = 3;
        ListaQuestao.Add(Q48);

        var Q49 = new Questao();
        Q49.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q49.questaoi = "Qual é o principal gás responsável pela fotossíntese?";
        Q49.resposta1 = "Dióxido de carbono";
        Q49.resposta2 = "Oxigênio";
        Q49.resposta3 = "Metano";
        Q49.resposta4 = "Hélio";
        Q49.resposta5 = "Nitrogênio";
        Q49.RespostaC = 1;
        ListaQuestao.Add(Q49);

       var Q50 = new Questao();
       Q50.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
       Q50.questaoi = "Qual é o sistema político onde o poder é exercido por um pequeno grupo de pessoas?";
       Q50.resposta1 = "Democracia";
       Q50.resposta2 = "Oligarquia";
       Q50.resposta3 = "Monarquia";
       Q50.resposta4 = "Anarquia";
       Q50.resposta5 = "Autocracia";
       Q50.RespostaC = 2;
       ListaQuestao.Add(Q50); 

       //nivel 6
       var Q51 = new Questao();
        Q51.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q51.questaoi = "Qual é a obra mais famosa de Miguel de Cervantes?";
        Q51.resposta1 = "Don Quixote";
        Q51.resposta2 = "O Cortiço";
        Q51.resposta3 = "Cem Anos de Solidão";
        Q51.resposta4 = "A Divina Comédia";
        Q51.resposta5 = "Os Maias";
        Q51.RespostaC = 1;
        ListaQuestao.Add(Q51);

        var Q52 = new Questao();
        Q52.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q52.questaoi = "Qual é o princípio da física que explica a conservação da energia?";
        Q52.resposta1 = "Princípio da Inércia";
        Q52.resposta2 = "Princípio da Termodinâmica";
        Q52.resposta3 = "Princípio da Ação e Reação";
        Q52.resposta4 = "Princípio da Gravitação Universal";
        Q52.resposta5 = "Princípio da Conservação da Energia";
        Q52.RespostaC = 5;
        ListaQuestao.Add(Q52);

        var Q53 = new Questao();
        Q53.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q53.questaoi = "Qual artista é conhecido como o pai da pintura a óleo?";
        Q53.resposta1 = "Pablo Picasso";
        Q53.resposta2 = "Vincent van Gogh";
        Q53.resposta3 = "Jan van Eyck";
        Q53.resposta4 = "Claude Monet";
        Q53.resposta5 = "Edvard Munch";
        Q53.RespostaC = 3;
        ListaQuestao.Add(Q53);

        var Q54 = new Questao();
        Q54.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q54.questaoi = "Qual é a capital do Canadá?";
        Q54.resposta1 = "Toronto";
        Q54.resposta2 = "Vancouver";
        Q54.resposta3 = "Ottawa";
        Q54.resposta4 = "Montreal";
        Q54.resposta5 = "Calgary";
        Q54.RespostaC = 3;
        ListaQuestao.Add(Q54);

        var Q55 = new Questao();
        Q55.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q55.questaoi = "Quem formulou as leis do movimento e a lei da gravitação universal?";
        Q55.resposta1 = "Galileu Galilei";
        Q55.resposta2 = "Isaac Newton";
        Q55.resposta3 = "Albert Einstein";
        Q55.resposta4 = "Niels Bohr";
        Q55.resposta5 = "Max Planck";
        Q55.RespostaC = 2;
        ListaQuestao.Add(Q55);

        var Q56 = new Questao();
        Q56.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q56.questaoi = "Qual é o nome do fenômeno em que a luz é desviada ao passar por um prisma?";
        Q56.resposta1 = "Refração";
        Q56.resposta2 = "Reflexão";
        Q56.resposta3 = "Dispersão";
        Q56.resposta4 = "Absorção";
        Q56.resposta5 = "Difração";
        Q56.RespostaC = 3;
        ListaQuestao.Add(Q56);

        var Q57 = new Questao();
        Q57.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q57.questaoi = "Qual foi o primeiro país a conceder o direito de voto às mulheres?";
        Q57.resposta1 = "Suécia";
        Q57.resposta2 = "Nova Zelândia";
        Q57.resposta3 = "Estados Unidos";
        Q57.resposta4 = "Reino Unido";
        Q57.resposta5 = "França";
        Q57.RespostaC = 2;
        ListaQuestao.Add(Q57);

        var Q58 = new Questao();
        Q58.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q58.questaoi = "Qual é a principal fonte de energia do Sol?";
        Q58.resposta1 = "Fusão nuclear";
        Q58.resposta2 = "Fissão nuclear";
        Q58.resposta3 = "Combustão";
        Q58.resposta4 = "Energia geotérmica";
        Q58.resposta5 = "Energia solar";
        Q58.RespostaC = 1;
        ListaQuestao.Add(Q58);

        var Q59 = new Questao();
        Q59.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q59.questaoi = "Qual é a unidade de medida da força no Sistema Internacional?";
        Q59.resposta1 = "Joule";
        Q59.resposta2 = "Newton";
        Q59.resposta3 = "Pascal";
        Q59.resposta4 = "Watt";
        Q59.resposta5 = "Volt";
        Q59.RespostaC = 2;
        ListaQuestao.Add(Q59);

        var Q60 = new Questao();
        Q60.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q60.questaoi = "Qual é a teoria que descreve a evolução das espécies por seleção natural?";
        Q60.resposta1 = "Teoria da Relatividade";
        Q60.resposta2 = "Teoria da Evolução";
        Q60.resposta3 = "Teoria da Genética";
        Q60.resposta4 = "Teoria do Caos";
        Q60.resposta5 = "Teoria da Simplicidade";
        Q60.RespostaC = 2;
        ListaQuestao.Add(Q60);

        //nivel 7
        var Q61 = new Questao();
        Q61.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q61.questaoi = "Qual é o princípio da incerteza proposto por Heisenberg?";
        Q61.resposta1 = "É impossível conhecer simultaneamente a posição e a velocidade de uma partícula.";
        Q61.resposta2 = "Toda ação tem uma reação igual e oposta.";
        Q61.resposta3 = "A energia não pode ser criada nem destruída.";
        Q61.resposta4 = "O universo tende ao estado de maior entropia.";
        Q61.resposta5 = "A luz se comporta como partícula e onda.";
        Q61.RespostaC = 1;
        ListaQuestao.Add(Q61);

        var Q62 = new Questao();
        Q62.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q62.questaoi = "Qual é a principal obra filosófica de Friedrich Nietzsche?";
        Q62.resposta1 = "Assim Falou Zaratustra";
        Q62.resposta2 = "A Gaia Ciência";
        Q62.resposta3 = "Além do Bem e do Mal";
        Q62.resposta4 = "Ecce Homo";
        Q62.resposta5 = "A Vontade de Poder";
        Q62.RespostaC = 1;
        ListaQuestao.Add(Q62);

        var Q63 = new Questao();
        Q63.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q63.questaoi = "Quem desenvolveu a teoria da relatividade geral?";
        Q63.resposta1 = "Isaac Newton";
        Q63.resposta2 = "Albert Einstein";
        Q63.resposta3 = "Niels Bohr";
        Q63.resposta4 = "Galileu Galilei";
        Q63.resposta5 = "Stephen Hawking";
        Q63.RespostaC = 2;
        ListaQuestao.Add(Q63);

        var Q64 = new Questao();
        Q64.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q64.questaoi = "Qual é o nome do processo pelo qual as células se dividem?";
        Q64.resposta1 = "Meiose";
        Q64.resposta2 = "Mitoses";
        Q64.resposta3 = "Fagocitose";
        Q64.resposta4 = "Difusão";
        Q64.resposta5 = "Transcrição";
        Q64.RespostaC = 2;
        ListaQuestao.Add(Q64);

        var Q65 = new Questao();
        Q65.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q65.questaoi = "Qual é a corrente filosófica que defende que a verdade é relativa e depende da perspectiva?";
        Q65.resposta1 = "Realismo";
        Q65.resposta2 = "Idealismo";
        Q65.resposta3 = "Relativismo";
        Q65.resposta4 = "Empirismo";
        Q65.resposta5 = "Racionalismo";
        Q65.RespostaC = 3;
        ListaQuestao.Add(Q65);

        var Q66 = new Questao();
        Q66.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q66.questaoi = "Quem é conhecido como o 'pai da história'?";
        Q66.resposta1 = "Heródoto";
        Q66.resposta2 = "Tucídides";
        Q66.resposta3 = "Políbio";
        Q66.resposta4 = "César";
        Q66.resposta5 = "Plínio";
        Q66.RespostaC = 1;
        ListaQuestao.Add(Q66);

        var Q67 = new Questao();
        Q67.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q67.questaoi = "Qual é a principal característica das células eucarióticas?";
        Q67.resposta1 = "Possuem núcleo definido.";
        Q67.resposta2 = "Não possuem membrana plasmática.";
        Q67.resposta3 = "São unicelulares apenas.";
        Q67.resposta4 = "Possuem apenas ribossomos.";
        Q67.resposta5 = "São sempre procarióticas.";
        Q67.RespostaC = 1;
        ListaQuestao.Add(Q67);

        var Q68 = new Questao();
        Q68.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q68.questaoi = "Qual é a maior cadeia montanhosa do mundo?";
        Q68.resposta1 = "Andes";
        Q68.resposta2 = "Himalaias";
        Q68.resposta3 = "Alpes";
        Q68.resposta4 = "Rocosas";
        Q68.resposta5 = "Apalaches";
        Q68.RespostaC = 2;
        ListaQuestao.Add(Q68);

        var Q69 = new Questao();
        Q69.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q69.questaoi = "Qual é a obra de Shakespeare que conta a história de dois amantes de famílias rivais?";
        Q69.resposta1 = "Hamlet";
        Q69.resposta2 = "Otelo";
        Q69.resposta3 = "Romeu e Julieta";
        Q69.resposta4 = "Macbeth";
        Q69.resposta5 = "Sonho de uma Noite de Verão";
        Q69.RespostaC = 3;
        ListaQuestao.Add(Q69);

        var Q70 = new Questao();
        Q70.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
        Q70.questaoi = "Qual é a fórmula química do ácido sulfúrico?";
        Q70.resposta1 = "HCl";
        Q70.resposta2 = "H2SO4";
        Q70.resposta3 = "H2CO3";
        Q70.resposta4 = "HNO3";
        Q70.resposta5 = "CH3COOH";
        Q70.RespostaC = 2;
        ListaQuestao.Add(Q70);

        //nivel 8
        var Q74 = new Questao();
Q74.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
Q74.questaoi = "Qual é a teoria que explica a origem das espécies por meio da seleção natural?";
Q74.resposta1 = "Teoria da Evolução";
Q74.resposta2 = "Teoria da Genética";
Q74.resposta3 = "Teoria do Design Inteligente";
Q74.resposta4 = "Teoria da Relatividade";
Q74.resposta5 = "Teoria do Caos";
Q74.RespostaC = 1;
ListaQuestao.Add(Q74);

var Q75 = new Questao();
Q75.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
Q75.questaoi = "Quem propôs a lei da gravitação universal?";
Q75.resposta1 = "Galileu Galilei";
Q75.resposta2 = "Isaac Newton";
Q75.resposta3 = "Albert Einstein";
Q75.resposta4 = "Niels Bohr";
Q75.resposta5 = "Stephen Hawking";
Q75.RespostaC = 2;
ListaQuestao.Add(Q75);

var Q76 = new Questao();
Q76.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
Q76.questaoi = "Qual é a principal obra de Karl Marx?";
Q76.resposta1 = "A Revolução dos Bichos";
Q76.resposta2 = "O Capital";
Q76.resposta3 = "A Origem das Espécies";
Q76.resposta4 = "O Príncipe";
Q76.resposta5 = "A Riqueza das Nações";
Q76.RespostaC = 2;
ListaQuestao.Add(Q76);

var Q77 = new Questao();
Q77.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
Q77.questaoi = "Qual é o nome do filósofo que introduziu o conceito de 'imperativo categórico'?";
Q77.resposta1 = "Friedrich Nietzsche";
Q77.resposta2 = "Immanuel Kant";
Q77.resposta3 = "David Hume";
Q77.resposta4 = "Georg Hegel";
Q77.resposta5 = "John Stuart Mill";
Q77.RespostaC = 2;
ListaQuestao.Add(Q77);

var Q78 = new Questao();
Q78.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
Q78.questaoi = "Qual é a unidade de medida da energia no Sistema Internacional?";
Q78.resposta1 = "Joule";
Q78.resposta2 = "Caloria";
Q78.resposta3 = "Watt";
Q78.resposta4 = "Newton";
Q78.resposta5 = "Volt";
Q78.RespostaC = 1;
ListaQuestao.Add(Q78);

var Q79 = new Questao();
Q79.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
Q79.questaoi = "Qual é a capital da Rússia?";
Q79.resposta1 = "São Petersburgo";
Q79.resposta2 = "Moscovo";
Q79.resposta3 = "Kazan";
Q79.resposta4 = "Novosibirsk";
Q79.resposta5 = "Vladivostok";
Q79.RespostaC = 2;
ListaQuestao.Add(Q79);

var Q80 = new Questao();
Q80.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
Q80.questaoi = "Qual é o princípio da termodinâmica que afirma que a energia não pode ser criada nem destruída?";
Q80.resposta1 = "Primeira Lei da Termodinâmica";
Q80.resposta2 = "Segunda Lei da Termodinâmica";
Q80.resposta3 = "Terceira Lei da Termodinâmica";
Q80.resposta4 = "Lei de Coulomb";
Q80.resposta5 = "Lei da Conservação da Massa";
Q80.RespostaC = 1;
ListaQuestao.Add(Q80);

var Q81 = new Questao();
Q81.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
Q81.questaoi = "Qual é a maior cidade da Austrália?";
Q81.resposta1 = "Sydney";
Q81.resposta2 = "Melbourne";
Q81.resposta3 = "Brisbane";
Q81.resposta4 = "Canberra";
Q81.resposta5 = "Perth";
Q81.RespostaC = 1;
ListaQuestao.Add(Q81);

var Q82 = new Questao();
Q82.ConfiguraDesenho(per, buttonrep1, bot2, bot3, bot4, bot5);
Q82.questaoi = "Quem escreveu 'O Príncipe'?";
Q82.resposta1 = "Thomas Hobbes";
Q82.resposta2 = "Niccolò Machiavelli";
Q82.resposta3 = "John Locke";
Q82.resposta4 = "Jean-Jacques Rousseau";
Q82.resposta5 = "Friedrich Engels";
Q82.RespostaC = 2;
ListaQuestao.Add(Q82);






















    }

    void ProximaQuestao()
    {
        var NumAlert = Random.Shared.Next(0, ListaQuestao.Count);
        while (ListasQuestaoRespondidas.Contains(NumAlert)) ;
        NumAlert = Random.Shared.Next(0, ListaQuestao.Count);
        ListasQuestaoRespondidas.Add(NumAlert);
        QuestaoAtual = ListaQuestao[NumAlert];
        QuestaoAtual.Desenhar();

    }
    public int Pontuação { get; private set; }
    int NivelAtual = 0;
    void Inicializar()
    {
        Pontuação = 0;
        NivelAtual = 1;
        ProximaQuestao();
    }

    public async void VerificaCorreto(int rr)
    {
        if (QuestaoAtual.EstaCorreto(rr))
        {
            await Task.Delay(1000);
            AdicionarPontuacao(NivelAtual);
            NivelAtual++;
            ProximaQuestao();
        }
        else
        {
            await App.Current.MainPage.DisplayAlert("Fim", "Voce errou", "ok");
            Inicializar();
        }
        labelPontuacao.Text = "Pontuação:R$" + Pontuação.ToString();
        labelNivel.Text = "Nível:" + NivelAtual.ToString();
    }
    void AdicionarPontuacao(int n)
    {
        if (n == 1)
            Pontuação = 1000;
        else if (n == 2)
            Pontuação = 2000;
        else if (n == 3)
            Pontuação = 5000;
        else if (n == 4)
            Pontuação = 10000;
        else if (n == 5)
            Pontuação = 20000;
        else if (n == 6)
            Pontuação = 50000;
        else if (n == 7)
            Pontuação = 100000;
        else if (n == 8)
            Pontuação = 200000;
    }

}

