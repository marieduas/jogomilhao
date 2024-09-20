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
            Q1.desenhar (per,bot1,bot2,bot3,bot4,bot5);
            Q1.Questao = "Quanto é 40+30?";
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
            var NumAlert =Random.Shared.Next(0,ListaQuestao);
            while(ListasQuestaoRespondidas.Contains(NumAlert));
            NumAlert=Random.Shared.Next(0,ListaQuestao.Count);
            ListasQuestaoRespondidas.Add(NumAlert);
            QuestaoAtual=ListaQuestao[NumAlert];
            QuestaoAtual.desenhar;

        }
        
    }
}