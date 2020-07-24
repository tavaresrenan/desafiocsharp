using Domain;
using Service;
using Service.Questions;
using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = Menu();
            }
        }

        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual desafio deseja acessar?:");
            Console.WriteLine("1) Desafio 1 - Exibir nome e sobrenome ao lado de multiplos");
            Console.WriteLine("2) Desafio 2 - Soma De Quadrados");
            Console.WriteLine("3) Desafio 3 - Sequencia Fibonnaci");
            Console.WriteLine("4) Desafio 4 - Árvore e nós");
            Console.WriteLine("5) Desafio 5 - Não implementado");
            Console.WriteLine("6) Desafio 6 - Números Triangulos");
            Console.WriteLine("0) Sair");
            Console.Write("\r\nSelecione uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    QuestionFactory<IQuestion>.Register(1, () => new FirstQuestion("Renan", "Tavares"));
                    ExecuteQuestion(1);
                    return true;
                case "2":
                    QuestionFactory<IQuestion>.Register(2, () => new SecondQuestion(new int[] { 1, 2, 3, 4, 5 }));
                    ExecuteQuestion(2);
                    return true;
                case "3":
                    QuestionFactory<IQuestion>.Register(3, () => new ThirdQuestion());
                    ExecuteQuestion(3);
                    return true;
                case "4":
                    QuestionFactory<IQuestion>.Register(4, () => new FourthQuestion(TreeDomain.GenerateTree(), 9));
                    ExecuteQuestion(4);
                    return true;
                case "5":
                    Console.WriteLine("Não implementado");
                    return false;
                case "6":
                    QuestionFactory<IQuestion>.Register(6, () => new SixthQuestion("SKY"));
                    ExecuteQuestion(6);
                    return true;
                default:
                    return false;
            }
        }

        private static void ExecuteQuestion(int op)
        {
            IQuestion question = QuestionFactory<IQuestion>.Create(op);
            var result = question.Execute();
            if(result.ListOfResults != null)
            {
                foreach (var item in result.ListOfResults)
                {
                    Console.WriteLine(item);
                }
            }else
            {
                foreach (var item in result.ListResultsInt)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadLine();
        }
    }
}
