using AtivSem02.InjecaoDependencia;
using System;

namespace AtivSem02
{
    class InjDep
    {
        //Classe que implementa interface IBancos
        public class Itau : IBancos 
        {
            public double Envia()
            {
                try
                {
                    double valor;
                    Console.WriteLine("-------------------------BANCO ITAÚ-------------------------");
                    Console.Write("Quanto você deseja transferir? ");
                    valor = double.Parse(Console.ReadLine());

                    return valor;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERRO! {ex.Message}");
                }

                return 0;
            }

            public void Recebe(double transferencia)
            {
                if(transferencia <= 0)
                    Console.WriteLine("Transferência não realizada! Digite um valor maior que 0.");
                else
                {
                    double valorTransferencia = transferencia;
                    Console.WriteLine($"Valor de {valorTransferencia}R$ transferido com sucesso para a conta Banco Itaú!");
                }
            }
        }

        //Classe que implementa interface IBancos
        public class Bradesco : IBancos
        {
            public double Envia()
            {
                try
                {
                    double valor;
                    Console.WriteLine("-------------------------BANCO BRADESCO-------------------------");
                    Console.Write("Quanto você deseja transferir? ");
                    valor = double.Parse(Console.ReadLine());

                    return valor;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERRO! {ex.Message}");
                }

                return 0;
            }

            public void Recebe(double transferencia)
            {
                if (transferencia <= 0)
                    Console.WriteLine("Transferência não realizada! Digite um valor maior que 0.");
                else
                {
                    double valorTransferencia = transferencia;
                    Console.WriteLine($"Valor de {valorTransferencia}R$ transferido com sucesso para a conta Banco Bradesco");
                }
            }
        }

        //Classe que implementa interface IBancos
        public class Santander : IBancos
        {
            public double Envia()
            {
                try
                {
                    double valor;
                    Console.WriteLine("-------------------------BANCO SANTANDER-------------------------");
                    Console.Write("Quanto você deseja transferir? ");
                    valor = double.Parse(Console.ReadLine());

                    return valor;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"ERRO! {ex.Message}");
                }

                return 0;
            }

            public void Recebe(double transferencia)
            {
                if (transferencia <= 0)
                    Console.WriteLine("Transferência não realizada! Digite um valor maior que 0.");
                else
                {
                    double valorTransferencia = transferencia;
                    Console.WriteLine($"Valor de {valorTransferencia}R$ transferido com sucesso para a conta Banco Santander!");
                }
            }
        }
    }
}

