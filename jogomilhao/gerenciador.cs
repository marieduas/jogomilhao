namespace jogomilhao
{
    public class gerenciador
    
    {
        List<Questao> ListaQuestao = new List<Questao>();
        List<int> ListasQuestaoRespondidas = new List<int>();

        Questao QuestaoAtual;
        public gerenciador(Label per, Button bot1, Button bot2, Button bot3, Button bot4, Button bot5)
        {
            CriarPergunta(per,bot1,bot2,bot3,bot4,bot5);
        }

        void CriarPergunta(Label per,Button bot1, Button bot2, Button bot3, Button bot4, Button bot5)
        {
            var Q1 = new Questao();
            Q1.ConfiguraDesenho(labelPergunta,buttonrep1,buttonrep2,buttonrep3,buttonrep4,buttonrep5);
            Q1.questaoi = "Quanto é 40+30?";
            Q1.resposta1 = "1";
            Q1.resposta2 = "16";
            Q1.resposta3 = "60";
            Q1.resposta5 = "70";
            Q1.RespostaC = 5;
            ListaQuestao.Add(Q1);
            ProximaQuestao();
        }

        void ProximaQuestao()
        {
            var NumAlert =Random.Shared.Next(0,ListaQuestao.Count);
            while(ListasQuestaoRespondidas.Contains(NumAlert));
            NumAlert=Random.Shared.Next(0,ListaQuestao.Count);
            ListasQuestaoRespondidas.Add(NumAlert);
            QuestaoAtual=ListaQuestao[NumAlert];
            QuestaoAtual.desenhar;

        }
        public int Pontuação{get;private set;}
        int NivelAtual = 0;
        void Inicializar()
        {
            Pontuação = 0;
            NivelAtual = 1;
            ProximaQuestao();
        }

        public async void verificaCorreta(int rr)
        {
            if(QuestaoCorreta.EstaCorreto (rr))
            {
                await Task.Delay(1000);
                AdicionarPontuacao(NivelAtual);
                NivelAtual++;
                ProximaQuestao();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Fim","Voce errou","ok");
                Inicializar();
            }
        }
        void AdicionarPontuacao(int n)
        {
            if (n==1)
                Pontuação=1000;
            else if (n==2)
                Pontuação=2000;
            else if(n==3)
                Pontuação=5000;
            else if (n==4)
                Pontuação=10000;
            else if (n==5)
                Pontuação=20000;
            else if (n==6)
                Pontuação=50000;
            else if (n==7)
                Pontuação=100000;
            else if (n==8)
                Pontuação=200000;


        }
        
    }
}