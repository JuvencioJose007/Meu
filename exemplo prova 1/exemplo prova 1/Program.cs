using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_prova_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            int[] numero = new int[3];
            string continuar = "sim";
            while (continuar == "sim") {
                while (contador < 3)
                {
                    Console.Write("Digite um numero: ");
                    numero[contador] = int.Parse(Console.ReadLine());

                    contador = contador + 1;
                }
                Console.WriteLine();
                Console.WriteLine("Como deseja ordenar os numeros");
                Console.Write("Digite \"1\" para ordenar de forma crescente ou digite \"-1\" para ordenar de forma decrescente: ");
                int ordem = int.Parse(Console.ReadLine());
                if (ordem == 1)
                {
                    contador = 0;
                    while(contador < 10){
                        int depois = contador + 1;
                        while (depois < 10)
                        {
                            if (numero[contador] > numero[depois])
                            {
                                int tmp = numero[contador];
                                numero[contador] = numero[depois];
                                numero[depois] = tmp;
                            }
                            depois = depois + 1;
                        }
                        contador = contador + 1;
                    }
                    contador = 0;
                    while(contador < 10)
                    {
                        Console.WriteLine(numero[contador]);
                        contador++;
                    }
                } else if (ordem == -1)
                {
                    contador = 0;
                    while(contador < 10)
                    {
                        int depois = contador + 1;
                        while (depois < 10)
                        {
                            if(numero[contador] < numero[depois])
                            {
                                int tmp;
                                tmp = numero[depois];
                                numero[depois] = numero[contador];
                                numero[contador] = tmp;
                            }
                            depois = depois + 1;
                        }
                        contador = contador + 1;
                    }
                    contador = 0;
                    while (contador < 10)
                    {
                        Console.WriteLine(numero[contador]);
                        contador++;
                    }
                } else
                {
                    Console.WriteLine("Número digitado errado");
                    Console.Write("Deseja continuar Digite sim: ");
                    continuar = Console.ReadLine();                    
                }
            }
            Console.Write("Fim programa");
            Console.ReadKey();



        }
    }
}
