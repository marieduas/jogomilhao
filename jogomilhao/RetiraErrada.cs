using jogomilhao;

public class RetiraErrada:Ajuda
{
    public override void RealizaAjuda(Questao questao)
    {
        switch (questao.respostacorreta)
        {
            case 1:
            btResposta02.IsVisible = false;
            btResposta03.IsVisible = false;
            btResposta04.IsVisible = false;
            break;
            case 2:
            btResposta01.IsVisible = false;
            btResposta03.IsVisible = false;
            btResposta05.IsVisible = false;
            break;
            case 3:
            btResposta01.IsVisible = false;
            btResposta02.IsVisible = false;
            btResposta04.IsVisible = false;
            break;
            case 4:
            btResposta01.IsVisible = false;
            btResposta02.IsVisible = false;
            btResposta05.IsVisible = false;
            break;
            case 5:
            btResposta01.IsVisible = false;
            btResposta02.IsVisible = false;
            btResposta03.IsVisible = false;
            break;
        }
    }
}