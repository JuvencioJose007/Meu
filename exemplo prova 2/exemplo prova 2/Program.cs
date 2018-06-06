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
            int contador = 1;
            while (contador <= total)
            {
                int aux = contador - 1;
                Console.Write("digite um numero: ");
                val[0] = int.Parse(Console.ReadLine());
                
                while (val[contador] > val[aux])
                {

                }
                contador++;
            }




        }
    }
}
