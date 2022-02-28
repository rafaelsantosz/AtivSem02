using System;
using System.Collections.Generic;
using System.Linq;

namespace AtivSem02
{
    class Generics
    {
        //Método que retorna Generic do tipo List<> com 10 alunos incluidos
        public static List<Alunos> GerarLista()
        {
            List<Alunos> listaAlunos = new List<Alunos>
            {
                new Alunos() { RA = 1, Nome = "Rafael", Turma = "7A" },
                new Alunos() { RA = 2, Nome = "Luiz", Turma = "7A" },
                new Alunos() { RA = 3, Nome = "Jorge", Turma = "7B" },
                new Alunos() { RA = 4, Nome = "Paloma", Turma = "7B" },
                new Alunos() { RA = 5, Nome = "Miguel", Turma = "7C" },
                new Alunos() { RA = 6, Nome = "Carlos", Turma = "7C" },
                new Alunos() { RA = 7, Nome = "Pedro", Turma = "7D" },
                new Alunos() { RA = 8, Nome = "Laura", Turma = "7D" },
                new Alunos() { RA = 9, Nome = "João", Turma = "8A" },
                new Alunos() { RA = 10, Nome = "Maria", Turma = "8B" }
            };

            return listaAlunos;
        }

        //Método que solicita RA do aluno
        public int SolicitarRA()
        {
            try
            {
                Console.Write("Digite o RA do aluno: ");
                int ra = int.Parse(Console.ReadLine());
                return ra;
            }
            //Caso ocorra um erro, é apresentado uma mensagem de erro e retornado -1
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO! {ex.Message}");
                return -1;
            }
        }

        //Método que faz pesquisa na Generic via LINQ, retornando um aluno a partir do parâmetro (ra)
        public string PesquisarAluno(int ra)
        {
            try
            {
                var listaAlunos = GerarLista(); //Chama o método GerarLista e guarda a lista na variável

                //Faz pesquisa através do LINQ e seleciona o aluno com o RA igual ao passado como parâmetro
                var alunoPesquisado = from a in listaAlunos where a.RA == ra select a;

                foreach (var aluno in alunoPesquisado)
                    return $"Aluno(a): {aluno.Nome}, Turma: {aluno.Turma}"; //Apresenta os dados do aluno
            }
            //Caso ocorra um erro, é apresentado uma mensagem de erro
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO! {ex.Message}");
            }

            return "Aluno não encontrado!"; //Se o RA do aluno não for encontrado é apresentado esta mensagem
        }
    }
}
