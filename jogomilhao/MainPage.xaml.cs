
namespace jogomilhao
{
    public partial class MainPage : ContentPage
    {
        Gerenciador gerenciador;
        public MainPage()
        {
            InitializeComponent();
            gerenciador = new Gerenciador (labelPergunta, btResposta01, btResposta02, btResposta03, btResposta04, btResposta05, labelPontuacao, labelNivel);
        }

        private void Resposta1Clicked (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(1);
        }
        private void Resposta2Clicked (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(2);
        }
        private void Resposta3Clicked (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(3);
        }
        private void Resposta4Clicked (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(4);
        }
        private void Resposta5Clicked (object sender, EventArgs e)
        {
            gerenciador!.VerificaResposta(5);
 
        }
        void RetirarClicked (object s, EventArgs e)
        {
            var ajuda = new RetiraErrada();
            ajuda.ConfigurarEstruturaDesenho (btResposta01, btResposta02, btResposta03, btResposta04, btResposta05);
            ajuda.RealizaAjuda(gerenciador.GetQuestaoCorrente());
            (s as Button).IsVisible = false;
        }
        void PularClicked (object s, EventArgs e)
        {
            gerenciador.ProximaQuestao();
            (s as Button).IsVisible = false;
        }
    }
}