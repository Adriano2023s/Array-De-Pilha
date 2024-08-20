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
                Console.WriteLine("Opção 3: Remover um item da lista");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Push(nomes);
                        break;

                    case 2:
                        ImprimeLista(nomes);
                        break;

                        case 3:
                        Pop(nomes);
                        break;
                }
            }
        }

        public static void Push(string[] ListaNomes)
        {
            Console.WriteLine("Digite um nome para adicionar na lista");
            string nome = Console.ReadLine();

            if (ListaCheia(ListaNomes))
            {
                Console.WriteLine("A lista está cheia. Remova um item para continuar adicionando");
                return;
            }

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

public static void Pop(string[] ListaNomes)
        {
            Console.WriteLine("Removendo o item da lista:");
if (ListaNomes == null || ListaNomes.Length == 0)
            {
                Console.WriteLine("A lista está vazia");
                return;
            }

            string nomeRemovido = ListaNomes[0];

            for (int i = 1; i < ListaNomes.Length; i++)
                {
                ListaNomes[i - 1] = ListaNomes[i];
            }

            ListaNomes[ListaNomes.Length - 1] = null;

            Console.WriteLine($"O nome: {nomeRemovido}, foi removido");

            return;
        }   
   
public static bool ListaCheia(string[] ListaNomes)
        {
for (int i = 0; i < ListaNomes.Length; i++)
            {
                if (ListaNomes[i] == null)
                {
                    return false;
                }
            }
return true;
        }
    }
}
