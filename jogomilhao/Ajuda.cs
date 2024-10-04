using jogomilhao;

public abstract class Ajuda
{
    protected Button btResposta01;
    protected Button btResposta02;
    protected Button btResposta03;
    protected Button btResposta04;
    protected Button btResposta05;
    protected Frame  frameAjuda;

    public void ConfigurarEstruturaDesenho(Button btResposta01, Button btResposta02, Button btResposta03, Button btResposta04, Button btResposta05)
    {
        this.btResposta01 = btResposta01;
        this.btResposta02 = btResposta02;
        this.btResposta03 = btResposta03;
        this.btResposta04 = btResposta04;
        this.btResposta05 = btResposta05;
    }
    public void ConfigurarEstruturaDesenho (Frame frameAjuda)
    {
        this.frameAjuda = frameAjuda;
    }

    public abstract void RealizaAjuda(Questao questao);
}