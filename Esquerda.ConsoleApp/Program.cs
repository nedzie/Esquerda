using System;

namespace Esquerda.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variáveis
            int quantiaDeComandos;
            char sentido = 'P';
            string sentidos = "";
            string comandos;
            char[] arrComandos;
            #endregion
            #region Processamento
            do
            {
                Console.Write("> ");
                quantiaDeComandos = int.Parse(Console.ReadLine());
                if(quantiaDeComandos == 0)
                {
                    break;
                }
                Console.Write("> ");
                comandos = Console.ReadLine().ToUpper();
                arrComandos = comandos.ToCharArray();
                sentido = 'N';
                for (int movimentos = 0; movimentos < quantiaDeComandos; movimentos++)
                {
                    if (arrComandos[movimentos] == 'E')
                    {
                        if (sentido == 'N')
                        {
                            sentido = 'O';
                        }
                        else if (sentido == 'O')
                        {
                            sentido = 'S';
                        }
                        else if (sentido == 'S')
                        {
                            sentido = 'L';
                        }
                        else if (sentido == 'L')
                        {
                            sentido = 'N';
                        }
                    }

                    if (arrComandos[movimentos] == 'D')
                    {
                        if (sentido == 'N')
                        {
                            sentido = 'L';
                        }
                        else if (sentido == 'L')
                        {
                            sentido = 'S';
                        }
                        else if (sentido == 'S')
                        {
                            sentido = 'O';
                        }
                        else if (sentido == 'O')
                        {
                            sentido = 'N';
                        }
                    }
                }
                sentidos += Convert.ToString(sentido) + "\n"; // Salva e formata os sentidos
                sentido = 'N'; // Reseta
            } while ((quantiaDeComandos != 0));
            #endregion
            #region Saídas
            Console.Clear();
            Console.WriteLine(sentidos);
            Console.ReadKey();
            #endregion
        }
    }
}