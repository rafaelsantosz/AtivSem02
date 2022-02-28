namespace AtivSem02.InjecaoDependencia
{
    public class TransferenciaBancaria
    {
        private IBancos banco1, banco2;

        public TransferenciaBancaria(IBancos bancos1, IBancos bancos2)
        {
            banco1 = bancos1;
            banco2 = bancos2;
        }

        public void Transferir()
        {
            double valorTransferencia = banco1.Envia(); //banco1 entrega o valor da transferência
            banco2.Recebe(valorTransferencia); //banco2 recebe o valor
        }
    }
}
