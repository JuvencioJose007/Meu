using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //int anoatual, anonasc, idade;

            //anoatual = int.Parse(Console.ReadLine());
            //anonasc = int.Parse(Console.ReadLine());

            //idade = anoatual - anonasc;

            //if (idade >= 18) {
            //    Console.WriteLine("Maior!");
            //} else {
            //    Console.WriteLine("Menor!");
            //}

            //Console.ReadKey();
            #endregion

            // Atividade 3

            #region A
            //Console.Write("Digite um número: ");
            //int A = int.Parse(Console.ReadLine());

            //Console.Write("Digite outro número: ");
            //int B = int.Parse(Console.ReadLine());

            //int C;

            //if (A >= B)
            //{
            //    C = A - B;
            //}
            //else
            //{
            //    C = B - A;
            //}

            //Console.WriteLine("O resultado da diferença: "+C);

            //Console.ReadKey();
            #endregion

            #region B

            //Console.Write("digite um valor: ");
            //int A = int.Parse(Console.ReadLine());

            //if (A > 0)
            //{
            //    Console.Write(A);
            //    Console.Write($"O valor positivamente é: {A}");
            //}
            //else
            //{
            //    A = A * -1;
            //    Console.Write($"O valor positivamente é: {A}");

            //}
            //Console.ReadKey();

            #endregion

            #region C

            //Console.WriteLine("Digite as quatro notas: ");
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());
            //int D = int.Parse(Console.ReadLine());

            //double med = (A + B + C + D) / 4;

            //if (med >= 5)
            //{
            //    Console.Write("Aprovado! " + med);
            //}
            //else
            //{
            //    Console.Write("Reprovado! " + med);
            //}

            //Console.ReadKey();

            #endregion

            #region D

            //Console.WriteLine("Digite as Quatro notas do aluno: ");
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());
            //int D = int.Parse(Console.ReadLine());

            //double med = (A + B + C + D) / 4;

            //if (med >= 7)
            //{
            //    Console.Write($"Aprovado! {med}");
            //}
            //else
            //{
            //    Console.Write("Digite a nota do exame: ");
            //    int E = int.Parse(Console.ReadLine());

            //    double emed = (med + E) / 2;

            //    if (emed >= 5)
            //    {
            //        Console.Write("Aprovado em exame nota: " + emed);
            //    }
            //    else
            //    {
            //        Console.Write("Reprovado " + emed);
            //    }

            //}

            //Console.ReadKey();

            #endregion

            #region E

            //int a, b, c;
            //double delta, x1, x2;

            //Console.Write("digite um valor: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("digite outro valor: ");
            //b = int.Parse(Console.ReadLine());
            //Console.Write("digite um outro valor: ");
            //c = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //if (a == 0 && b == 0 && c == 0)
            //{
            //    Console.Write("Os valores digitados devem ser diferente de 0");
            //}
            //else
            //{
            //    delta = (b * b) - 4 * a * c;

            //    if (delta < 0)
            //    {
            //        Console.WriteLine("Não existe uma raiz real");
            //    }
            //    else if (delta == 0)
            //    {
            //        x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            //        x2 = (-b - Math.Sqrt(delta)) / 2 * a;
            //        Console.WriteLine("Só existe uma raiz possivel");
            //        Console.WriteLine($"O valor de x' é: {x1:0.00}");
            //        Console.WriteLine($"O valor de x\" é: {x2:0.00}");
            //    }
            //    else
            //    {
            //        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            //        x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //        Console.WriteLine($"O valor de x' é: {x1:0.00}");
            //        Console.WriteLine($"O valor de x\" é: {x2:0.00}");
            //    }
            //}

            //Console.ReadKey();            

            #endregion

            #region F

            //Console.Write("Digite um valor: ");
            //int A = int.Parse(Console.ReadLine());
            //Console.Write("Digite outro valor: ");
            //int B = int.Parse(Console.ReadLine());
            //Console.Write("Digite outro valor: ");
            //int C = int.Parse(Console.ReadLine());

            //if (A <= B && B <= C)
            //{
            //    Console.WriteLine(A + ", " + B + ", " + C);
            //}
            //else if (A <= B && C <= B)
            //{
            //    Console.WriteLine(A + ", " + C + ", " + B);
            //}
            //else if (B <= A && A <= C)
            //{
            //    Console.WriteLine(B + ", " + A + ", " + C);
            //}
            //else if (C <= A && A <= B)
            //{
            //    Console.WriteLine(C + ", " + A + ", " + B);
            //}
            //else if (C <= B && B <= A)
            //{
            //    Console.WriteLine(C + ", " + B + ", " + A);
            //}
            //else
            //{
            //    Console.WriteLine(B + ", " + C + ", " + A);
            //}

            //Console.ReadKey();

            #endregion

            #region G

            //Console.WriteLine("Digite Quatro números: ");
            //Console.Write("1º:");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("2º:");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("3º:");
            //int c = int.Parse(Console.ReadLine());
            //Console.Write("4º:");
            //int d = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //if (a % 2 == 0 && a % 3 == 0)
            //{
            //    Console.WriteLine($"O número {a} é divisével por 2 e 3");
            //}
            //if (b % 2 == 0 && b % 3 == 0)
            //{
            //    Console.WriteLine($"O número {b} é divisível por 2 e 3");
            //}
            //if (c % 2 == 0 && c % 3 == 0)
            //{
            //    Console.WriteLine($"O número {c} é divisível por 2 e 3");
            //}
            //if (d % 2 == 0 && d % 3 == 0)
            //{
            //    Console.WriteLine($"O número {d} é divisível por 2 e 3");
            //}
            //else
            //{
            //    Console.WriteLine("Nenhum número digitado é divisível por 2 e 3");
            //}

            //Console.ReadKey();

            #endregion

            #region H
            
            //Console.WriteLine("Digite Quatro números: ");
            //Console.Write("1º:");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("2º:");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("3º:");
            //int c = int.Parse(Console.ReadLine());
            //Console.Write("4º:");
            //int d = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //if (a % 2 == 0 || a % 3 == 0)
            //{
            //    Console.WriteLine($"O número {a} é divisível por 2 ou 3");
            //}
            //if (b % 2 == 0 || b % 3 == 0)
            //{
            //    Console.WriteLine($"O número {b} é divisível por 2 ou 3");
            //}
            //if (c % 2 == 0 || c % 3 == 0)
            //{
            //    Console.WriteLine($"O número {c} é divisível por 2 ou 3");
            //}
            //if (d % 2 == 0 || d % 3 == 0)
            //{
            //    Console.WriteLine($"O número {d} é divisível por 2 ou 3");
            //}
            //else
            //{
            //    Console.WriteLine("Nenhum número digitado é divisível por 2 ou 3");
            //}

            //Console.ReadKey();

            #endregion

            #region  I

            //Console.Write("Digite cinco valores: ");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //int e = int.Parse(Console.ReadLine());

            //if (a >= b && a >= c && a >= d && a >= e) {
            //    Console.WriteLine("O maior: " + a);
            //} else if (b >= a && b >= c && b >= d && b >= e) {
            //    Console.WriteLine("O maior: " + b);
            //} else if (c >= a && c >= b && c >= d && a >= e) {
            //    Console.Write("O maior: " + c);
            //} else if (d >= a && d >= b && d >= c && d >= e) {
            //    Console.Write("O maior: " + d);
            //} else {
            //    Console.WriteLine("O maior: " + e);
            //}
            //if (a <= b && a <= c && a <= d && a <= e) {
            //    Console.WriteLine("O menor: " + a);
            //} else if (b <= a && b <= c && b <= d && b <= e) {
            //    Console.WriteLine("O menor: " + b);
            //} else if (c <= a && c <= b && c <= d && c <= e) {
            //    Console.WriteLine("O menor: " + c);
            //} else if (d <= a && d <= b && d <= c && d <= e) {
            //    Console.WriteLine("O menor: " + d);
            //} else {
            //    Console.WriteLine("O menor: " + e);
            //}

            //Console.ReadKey();

            #endregion

            #region J

            //Console.Write("Digite um valor: ");
            //int a = int.Parse(Console.ReadLine());

            //if (a % 2 == 0) {
            //    Console.WriteLine("O número é par");
            //}if (a % 3 == 0) {
            //    Console.WriteLine("O número é ímpar");
            //}else {
            //    Console.Write("O número não é ímpar nem par");
            //}

            //Console.ReadKey(); 

            #endregion

            #region K

            //Console.Write("DIgite um valor: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (x >= 1 && x <= 9) {
            //    Console.WriteLine("O valor está na faixa permitida");
            //} else {
            //    Console.WriteLine("O valor está fora da faixa permitida");
            //}

            //Console.ReadKey();

            #endregion

            #region L

            //Console.Write("Dígite um valor: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //if (!(b <= 3)) {
            //    Console.WriteLine("Verdadeiro");
            //} else {
            //    Console.WriteLine("Falso");
            //}

            //Console.ReadKey();

            #endregion

            #region M

            //Console.Write("Dígite seu nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Dígite seu sexo (masculino ou feminino): ");
            //string sexo = Console.ReadLine();
            //Console.WriteLine();
            //if (sexo == "masculino") {
            //    Console.WriteLine("Sr. " + nome);
            //    Console.Write("Prezado " + nome + ". Estamos felizes pelo seu cadastro no nosso sistema");
            //} else if (sexo == "feminino"){
            //    Console.WriteLine("Sra. " + nome);
            //    Console.Write("Prezado " + nome + ". Estamos felizes pelo seu cadastro no nosso sistema");
            //} else {
            //    Console.Write("Sexo digitado errado");
            //}

            //Console.ReadKey();

            #endregion


        }
    }
}
