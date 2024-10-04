namespace jogomilhao;

public class Questao:IEquatable<Questao>
{
public Questao()
{

}
    public bool Equals(Questao questao)
    {
        return this.Nivel == questao.Nivel && this.pergunta==questao.pergunta;
    }
    public string pergunta { get; set; }
    public string resposta1 { get; set; }
    public string resposta2 { get; set; }
    public string resposta3 { get; set; }
    public string resposta4 { get; set; }
    public string resposta5 { get; set; }
    public int nivelpergunta { get; set; }
    public int respostacorreta { get; set;}
    public int Nivel;
    
    public void desenhar()
    {
        labelPergunta.Text = pergunta;
        btResposta01.Text = resposta1;
        btResposta02.Text = resposta2;
        btResposta03.Text = resposta3;
        btResposta04.Text = resposta4;
        btResposta05.Text = resposta5;

        btResposta01.BackgroundColor = Colors.DarkBlue;
        btResposta01.TextColor       = Colors.White;
        btResposta02.BackgroundColor = Colors.DarkBlue;
        btResposta02.TextColor       = Colors.White;
        btResposta03.BackgroundColor = Colors.DarkBlue;
        btResposta03.TextColor       = Colors.White;
        btResposta04.BackgroundColor = Colors.DarkBlue;
        btResposta04.TextColor       = Colors.White;
        btResposta05.BackgroundColor = Colors.DarkBlue;
        btResposta05.TextColor       = Colors.White;

        btResposta01.IsVisible = true;
        btResposta02.IsVisible = true;
        btResposta03.IsVisible = true;
        btResposta04.IsVisible = true;
        btResposta05.IsVisible = true;
    }

    private Label labelPergunta;
    private Button btResposta01;
    private Button btResposta02;
    private Button btResposta03;
    private Button btResposta04;
    private Button btResposta05;

    public Questao(Label lp, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta = lp;
        btResposta01 = bt01;
        btResposta02 = bt02;
        btResposta03 = bt03;
        btResposta04 = bt04;
        btResposta05 = bt05;
    }
    public void ConfigurarEstruturaDesenho(Label lp, Button bt01, Button bt02, Button bt03, Button bt04, Button bt05)
    {
        labelPergunta = lp;
        btResposta01 = bt01;
        btResposta02 = bt02;
        btResposta03 = bt03;
        btResposta04 = bt04;
        btResposta05 = bt05;
    }
    public bool VerificaResposta(int RR)
    {
        if (respostacorreta == RR)
        {
            var botao = QualBotao (RR);
            botao.BackgroundColor = Colors.Green;
            return true;
        }
        else
        {
            var botaocorreto = QualBotao (respostacorreta);
            var botaoincorreto = QualBotao (RR);
            botaocorreto.BackgroundColor = Colors.Yellow;
            botaoincorreto.BackgroundColor = Colors.Red;
            return false;
        }
    } 
    private Button QualBotao (int RR)
    {
        if (RR == 1)
        return btResposta01;
        else if (RR == 2)
        return btResposta02;
        else if (RR == 3)
        return btResposta03;
        else if (RR == 4)
        return btResposta04;
        else if (RR == 5)
        return btResposta05;
        else
        return null;
    }
}