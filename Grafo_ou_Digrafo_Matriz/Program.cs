using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafo_ou_Digrafo_Matriz
{
    class Program
    {
        //public static void Joao()
        //{
        //    int x = 3, y = 3; //Declaração do tamanho da matriz
        //    int[,] matriz = new int[x, y];

        //    for (int l = 0; l < x; l++)
        //        for (int c = 0; c < y; c++)
        //        {
        //            Console.WriteLine("Entre com [{0}, {1}]: ", l, c);
        //            matriz[l, c] = Convert.ToInt32(Console.ReadLine());
        //        }

        //    Console.Clear();
        //    Console.WriteLine("\n\n-------EXIBIÇÃO-------\n\n");
        //    for (int l = 0; l < x; l++)
        //    {
        //        for (int c = 0; c < y; c++)
        //        {
        //            Console.Write("[{0}, {1}]({2})\t", l, c, matriz[l, c]);
        //        }
        //        Console.WriteLine("\n----------");
        //    }
        //    Console.ReadKey();
        //}

        static void Main(string[] args)
        {
            //Joao();
            //return;             
            string sn;

            do
            {
                int esc, aresta, linha, coluna, vertice;
                int[,] matriz;

                Console.WriteLine("============================");
                Console.WriteLine("| [1] M A T R I Z  C O M P.|");
                Console.WriteLine("| [2] G R A F O            |");
                Console.WriteLine("| [3] D I G R A F O        |");
                Console.WriteLine("| [4] S A I R              |");
                Console.WriteLine("============================");
                Console.WriteLine();

                Console.Write("Escolha uma opção: ");
                esc = Convert.ToInt16(Console.ReadLine());

                if (esc != 4)
                {
                    switch (esc)
                    {
                        case 1:
                            Console.Write("Quantidade de posições da matriz: ");
                            linha = Convert.ToInt16(Console.ReadLine());
                            coluna = linha;
                            for (int i = 0; i < linha; i++)
                            {
                                for (int j = 0; j < coluna; j++)
                                {
                                    Console.Write(" " + 0 + "  ");
                                }

                                Console.WriteLine();
                                Console.WriteLine();
                            }
                            break;

                        case 2:
                            int origem = 0, destino = 0;

                            Console.Write("Quantos Vertices? ");
                            vertice = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Quantas Arestas? ");
                            aresta = Convert.ToInt32(Console.ReadLine());
                            matriz = new int[vertice, vertice];

                            for (int i = 0; i < aresta; i++)
                            {
                                Console.Write("Vertice Origem: ");
                                origem = (Convert.ToInt16(Console.ReadLine()) - 1);

                                Console.Write("Vertice Destino: ");
                                destino = (Convert.ToInt16(Console.ReadLine()) - 1);

                                for (int j = 0; j < vertice; j++)
                                {
                                    for (int x = 0; x < vertice; x++)
                                    {
                                        if ((j == origem) && (x == destino))
                                        {
                                            matriz[j, x] = 1;
                                            matriz[x, j] = 1;
                                        }
                                    }
                                }
                            }
                            Console.WriteLine();
                            for (int j = 0; j < vertice; j++)
                            {
                                for (int x = 0; x < vertice; x++)
                                {
                                    if (matriz[j, x] == 1 || matriz[x, j] == 1)
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    else
                                        Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(" " + matriz[j, x] + "  ");
                                    
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        case 3:
                            Console.Write("Quantos Vertices? ");
                            vertice = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Quantas Arestas? ");
                            aresta = Convert.ToInt32(Console.ReadLine());
                            matriz = new int[vertice, vertice];

                            for (int i = 0; i < aresta; i++)
                            {
                                Console.Write("Vertice Origem: ");
                                origem = (Convert.ToInt16(Console.ReadLine()) - 1);

                                Console.Write("Vertice Destino: ");
                                destino = (Convert.ToInt16(Console.ReadLine()) - 1);

                                for (int j = 0; j < vertice; j++)
                                {
                                    for (int x = 0; x < vertice; x++)
                                    {
                                        if ((j == origem) && (x == destino))
                                        {
                                            matriz[j, x] = 1;
                                        }
                                    }
                                }
                            }
                            Console.WriteLine();
                            for (int j = 0; j < vertice; j++)
                            {
                                for (int x = 0; x < vertice; x++)
                                {
                                    if (matriz[j, x] == 1)
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    else
                                        Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(" " + matriz[j, x] + "  ");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        default:
                            break;
                    }
                    Console.Write("Deseja fazer outra apresentação de matriz? [S/N]: ");
                    sn = Console.ReadLine().ToUpper();
                }
                else
                    sn = "N";
                Console.Clear();
            } while (sn != "N");

            Console.WriteLine("E N C E R R A N D O. . .");
            Console.ReadKey();
        }
    }
}
