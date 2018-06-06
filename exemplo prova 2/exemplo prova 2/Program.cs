using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_prova_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor para variaveis: ");
            int total = int.Parse(Console.ReadLine());
            int[] val = new int[total];
            Console.WriteLine();
            Console.Write("Digite um numero: ");
            val[0] = int.Parse(Console.ReadLine());
            
            int contador = 1;            
            while (contador < total)
            {
                int aux = contador - 1;
                Console.Write("Digite um numero: ");
                val[contador] = int.Parse(Console.ReadLine());                
                while (val[contador] > val[aux])
                {
                    Console.WriteLine();
                    Console.WriteLine("Número deve ser digitado menor que o anterior");
                    Console.Write("Digite um numero: ");
                    val[contador] = int.Parse(Console.ReadLine());
                }
                contador++;
            }
            int extra;
            Console.Write("Digite um valor: ");
            extra = int.Parse(Console.ReadLine());
            Console.WriteLine();
            contador = 0;
            while(contador < total)
            {
                if (val[contador] % 2 == 0) {
                        val[contador] = val[contador] + extra;
                }
                else {
                        val[contador] = val[contador] * extra;
                }
                contador = contador + 1;
            }
            contador = total - 1;
            while(contador >= 0)
            {
                Console.WriteLine(val[contador]);
                contador--;
            }
            
            Console.ReadKey();

        }
    }
}
