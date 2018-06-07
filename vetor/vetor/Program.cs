using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*http://moodle.bandtec.com.br/pluginfile.php/52738/mod_resource/content/1/Lista%2004%20-%20Vetores.pdf */

            #region Exemplo

            //    int total;
            //    int contador;
            //    double n1, n2;

            //    Console.WriteLine("Digite a quantidade de alunos");
            //    total = int.Parse(Console.ReadLine());

            //    contador = 0;

            //    string[] nome = new string[total];
            //    double[] media = new double[total];

            //    while (contador < total)
            //    {
            //        Console.WriteLine("Digite o nome do aluno");

            //        nome[contador] = Console.ReadLine();

            //        Console.WriteLine("Digite a N1");
            //        n1 = double.Parse(Console.ReadLine());
            //        Console.WriteLine("Digite a N2");
            //        n2 = double.Parse(Console.ReadLine());

            //        media[contador] = (n1 + n2) * 0.5;

            //        contador = contador + 1;
            //    }

            //    Console.Clear();

            //    contador = 0;

            //    while (contador < total)
            //    {
            //        Console.WriteLine(
            //            "A média de " +
            //            nome[contador] +
            //            " é " +
            //            media[contador]);

            //        contador = contador + 1;
            //    }

            //Console.ReadKey();

            #endregion

            #region A

            //string[] nome = new string[10];
            //int contador = 0;
            //while (contador < 10)
            //{
            //    Console.Write("Digite o nome da pessoa: ");
            //    nome[contador] = Console.ReadLine();
            //    contador = contador + 1;
            //}
            //Console.Clear();
            //contador = 0;
            //while (contador < 10)
            //{
            //    Console.WriteLine(nome[contador]);
            //    contador = contador + 1;
            //}

            //Console.ReadKey();

            #endregion

            #region B

            //int[] A = new int[8];
            //int[] B = new int[8];

            //int contador = 0;
            //while (contador < 8)
            //{
            //    Console.Write("Digite um número: ");
            //    A[contador] = int.Parse(Console.ReadLine());
            //    B[contador] = A[contador] * 3;
            //    contador++;
            //}
            //Console.WriteLine();
            //contador = 0;
            //int c = 0;
            //while (contador < 8)
            //{
            //    Console.WriteLine("O vetor B" +c+ ": " +B[contador]);
            //    contador = contador + 1;
            //    c++;
            //}

            //Console.ReadKey();

            #endregion

            #region C

            //int[] A = new int[20];
            //int[] B = new int[20];
            //int[] C = new int[20];

            //int contador = 0;
            //while (contador < 20)
            //{
            //    Console.Write("Digite um número: ");
            //    A[contador] = int.Parse(Console.ReadLine());
            //    Console.Write("Digite um número: ");
            //    B[contador] = int.Parse(Console.ReadLine());
            //    contador = contador + 1;
            //}
            //contador = 0;
            //while (contador < 20)
            //{
            //    C[contador] = A[contador] - B[contador];
            //    contador = contador + 1;
            //}
            //Console.Clear();
            //contador = 0;
            //while (contador < 20)
            //{
            //    Console.WriteLine($"Vetor C{contador} = " + C[contador]);
            //    contador = contador + 1;
            //}

            //Console.ReadKey();

            #endregion

            #region D

            //int[] A = new int[15];
            //int[] B = new int[15];

            //int contador = 0;
            //while (contador < 15)
            //{
            //    Console.Write("Digite um número: ");
            //    A[contador] = int.Parse(Console.ReadLine());

            //    B[contador] = A[contador] * A[contador];
            //    contador = contador + 1;
            //}
            //Console.Clear();
            //contador = 0;
            //while (contador < 15)
            //{
            //    Console.WriteLine($"Vetor A{contador} = " + A[contador]);
            //    Console.WriteLine($"Vetor B{contador} = " + B[contador]);
            //    Console.WriteLine();
            //    contador = contador + 1;
            //}

            //Console.ReadKey();

            #endregion

            #region E

            //int[] A = new int[15];
            //int[] B = new int[15];

            //int contador = 0;
            //while (contador < 15)
            //{
            //    Console.Write("Digite un número inteiro: ");
            //    A[contador] = int.Parse(Console.ReadLine());

            //    int soma = 1;
            //    int contador1 = 1;
            //    while (A[contador] >= contador1)
            //    {
            //        soma = soma * contador1;
            //        contador1 = contador1 + 1;
            //    }
            //    B[contador] = soma;
            //    contador = contador + 1;
            //}
            //Console.Clear();
            //contador = 0;
            //while (contador < 15)
            //{
            //    Console.WriteLine($"vetor A{contador} = {A[contador]}");
            //    Console.WriteLine($"vetor B{contador} = {B[contador]}");
            //    contador = contador + 1;
            //}

            //Console.ReadKey();

            #endregion

            #region F

            //int[] A = new int[15];
            //int[] B = new int[15];
            //int[] C = new int[30];

            //int contador = 0;
            //while (contador < 15)
            //{
            //    Console.Write("Digite números inteiros: ");
            //    A[contador] = int.Parse(Console.ReadLine());
            //    Console.Write("Digite números inteiros: ");
            //    B[contador] = int.Parse(Console.ReadLine());

            //    C[contador] = A[contador];
            //    C[15 + contador] = B[contador];
            //    contador = contador + 1;
            //}
            //Console.Clear();
            //contador = 0;
            //while (contador < 30)
            //{
            //    Console.WriteLine(C[contador]);
            //    contador = contador + 1;
            //}

            //Console.ReadKey();

            #endregion

            #region G

            //string[] A = new string[20];
            //string[] B = new string[30];
            //string[] C = new string[50];

            //int contador = 0;
            //int nome = 20;
            //while (contador < 20)
            //{
            //    Console.Write($"Digite mais {nome} nome: ");
            //    A[contador] = Console.ReadLine();

            //    C[contador] = A[contador];
            //    nome--;
            //    contador++;
            //}
            //nome = 30;
            //contador = 0;
            //while (contador < 30)
            //{
            //    Console.Write($"Digite mais {nome} nomes: ");
            //    B[contador] = Console.ReadLine();

            //    C[20 + contador] = B[contador];
            //    nome--;
            //    contador++;
            //}
            //contador = 0;
            //Console.Clear();
            //while (contador < 50)
            //{
            //    Console.WriteLine(C[contador]);
            //    contador++;
            //}

            //Console.ReadKey();

            #endregion

            #region H

            //double[] A = new double[20];
            //double[] B = new double[20];
            
            //int contador = 0;
            //while (contador < 20)
            //{
            //    Console.Write("Digite qualquer número: ");
            //    A[contador] = int.Parse(Console.ReadLine());
            //    contador++;
            //}
            //contador = 0;
            //while (contador < 20)
            //{
            //    B[19 - contador] = A[contador];
            //    contador++;
            //}
            //contador = 0;
            //while (contador < 20)
            //{
            //    Console.WriteLine("A " + A[contador]);
            //    Console.WriteLine("B " + B[contador]);
            //    contador++;
            //}

            //Console.ReadKey();

            #endregion

            #region 




            #endregion







        }
    }
}
 