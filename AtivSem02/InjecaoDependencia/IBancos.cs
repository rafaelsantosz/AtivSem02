namespace AtivSem02.InjecaoDependencia
{
    public interface IBancos
    {
        double Envia(); //Método que retorna double

        void Recebe(double transferencia); //Método que recebe double como parâmetro
    }
}
