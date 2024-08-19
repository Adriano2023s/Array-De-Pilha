using System;

namespace Vetor_De_Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            bool loopMenu = true;

            while (loopMenu)
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("Opção 1: Adicionar um nome na lista");
                Console.WriteLine("Opção 2: Imprimir os nomes da lista");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Push(nomes);
                        break;

                    case 2:
                        ImprimeLista(nomes);
                        break;
                }
            }
        }

        public static void Push(string[] ListaNomes)
        {
            Console.WriteLine("Digite um nome para adicionar na lista");
            string nome = Console.ReadLine();

            if (ListaNomes.Length == 0)
            {
                Console.WriteLine("A lista esttá vazia.");
                return;
            }

            for (int i = ListaNomes.Length - 1; i > 0; i--)
            {
                ListaNomes[i] = ListaNomes[i - 1];
            }

            ListaNomes[0] = nome;
            Console.WriteLine($"O nome: {nome}, foi adicionado");
            return;
        }
   
        public static void ImprimeLista(string[] ListaNomes)
        {
            Console.WriteLine("Os nomes da lista são:");
            for (int i = 0;i < ListaNomes.Length;i++)
            {
                if (ListaNomes[i] != null)
                {
                    Console.WriteLine($"{ListaNomes[i]}");
                }
            }
            return;
        }
   
    }
}
