using AtivSem02.InjecaoDependencia;
using System;
using static AtivSem02.InjDep;

namespace AtivSem02
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Generics
            Generics generics = new Generics();

            Console.WriteLine("1 - PESQUISAR ALUNO");
            int ra = generics.SolicitarRA();

            Console.WriteLine(generics.PesquisarAluno(ra));
            Console.ReadKey();
            Console.Clear();

            //2. Injeção de Dependências
            TransferenciaBancaria transferencia = new TransferenciaBancaria(new Bradesco { }, new Itau { });
            TransferenciaBancaria transferencia2 = new TransferenciaBancaria(new Santander { }, new Bradesco { });

            Console.WriteLine("2 - TRANSFERÊNCIA BANCÁRIA (exemplos)");

            transferencia.Transferir();
            transferencia2.Transferir();
            Console.ReadKey();
        }
    }
}
