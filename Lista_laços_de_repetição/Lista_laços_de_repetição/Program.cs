using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_laços_de_repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ex:A

            //int x = 15, z;
            //while (x <= 200)
            //{
            //    z = (x * x);
            //    Console.WriteLine(z);
            //    x = x + 1;
            //}
            //Console.ReadKey();

            #endregion

            #region ex:B

            //int z = 1, x, s;
            //Console.Write("Digite um numero para se ter a tabuada: ");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //while (z <= 10)
            //{
            //    s = x * z;
            //    Console.WriteLine($"{x} X {z} = {s}");
            //    z = z + 1;
            //}
            //Console.ReadKey();

            #endregion

            #region ex:C

            //int x = 1;
            //int resul = 0;
            //while (x <= 100)
            //{
            //    resul = resul + x;
            //    x = x + 1;
            //}
            //Console.WriteLine(resul);
            //Console.ReadKey();

            #endregion

            #region ex:D

            //int a = 0, b = 2;
            //while (b <= 500)
            //{
            //    a = a + b;
            //    b = b + 2;
            //}
            //Console.WriteLine(a);
            //Console.ReadKey();

            #endregion

            #region ex:E

            //int Resultado = 0;
            //while (Resultado <= 20)
            //{
            //    if (Resultado % 2 == 1)
            //    {
            //        Console.WriteLine(Resultado);
            //    }
            //    Resultado = Resultado + 1;
            //}
            //Console.ReadKey();

            #endregion

            #region ex:F

            //int Resul = 0, cont = 1;
            //while (cont <= 200)
            //{
            //    if (Resul % 4 == 0)
            //    {
            //        Console.WriteLine(Resul);
            //    }
            //    Resul = Resul + 1;
            //    cont = cont + 1;
            //}

            //Console.ReadKey();

            #endregion

            #region ex:G

            //double x = 0, z;
            //while (x <= 15)
            //{
            //    z = Math.Pow(3, x);
            //    Console.WriteLine($"3^{x} = {z}");
            //    x = x + 1;
            //}
            //Console.ReadKey();
            ////Math.Sqrt(xx);

            #endregion

            #region ex:H

            //int Base = 0, expoente = 0, contador = 0, valor = 1;

            //Console.Write("Digite a base de calculo: ");
            //Base = int.Parse(Console.ReadLine());

            //Console.Write("Digite o expoente para o calculo: ");
            //expoente = int.Parse(Console.ReadLine());


            //while (contador < expoente)
            //{
            //    valor = valor * Base;
            //    contador = contador + 1;

            //}

            //Console.WriteLine("Valor da potência: " + valor);
            //Console.ReadKey();

            #endregion

            #region ex:I

            //int anterior = 0, atual = 1, proximo = 0, contador = 0;

            //Console.WriteLine(atual);

            //while (contador < 14)
            //{
            //    proximo = anterior + atual;
            //    Console.WriteLine(proximo);

            //    anterior = atual;
            //    atual = proximo;
            //    contador = contador + 1;
            //}

            //Console.ReadKey();

            #endregion

            #region ex:J

            //int celsius = 10;
            //double fahrenheit = 0;

            //while (celsius <= 100)
            //{
            //    fahrenheit = ((1.8 * celsius) + 32);
            //    Console.WriteLine($"{celsius}ºC = {fahrenheit}ºF");
            //    celsius = celsius + 10;
            //}

            //Console.ReadKey();

            #endregion

            #region ex:K

            //decimal grao = 1, soma = 1, contador = 0;

            //while(contador <= 64)
            //{
            //    grao =  grao * 2;
            //    soma = soma + grao;
            //    contador = contador + 1; 
            //}
            //Console.Write(soma);

            //Console.ReadKey();

            #endregion

            #region ex:L

            //int contador = 1;
            //while (contador <= 15)
            //{
            //    int fatorial = 1;
            //    int contadorFatorial = 1;
            //    int numero = int.Parse(Console.ReadLine());
            //    while (contadorFatorial <= numero)
            //    {
            //        fatorial = fatorial * contadorFatorial;
            //        contadorFatorial = contadorFatorial + 1;
            //    }
            //    Console.WriteLine(fatorial);
            //    contador = contador + 1;
            //}

            //Console.ReadKey();

            #endregion

            #region ex:M

            //int soma = 0, contador = 0, valor, xx = 10;
            //double media;


            //while (contador < 10)
            //{
            //    Console.WriteLine($"DIgite {xx} números: ");
            //    valor = int.Parse(Console.ReadLine());
            //    soma = valor + soma;
            //    contador = contador + 1;
            //    xx = xx - 1;
            //}

            //Console.WriteLine("Soma: " + soma);
            //media = soma / 10;
            //Console.WriteLine("Média: " + media);

            //Console.ReadKey();

            #endregion

            #region ex:N

            //int numero = 0, media, total = 0, soma = 0;

            //Console.Write("Digite um numero positivo: ");
            //numero = int.Parse(Console.ReadLine());

            //while (numero >= 0)
            //{
            //    total = total + 1;
            //    soma = numero + soma;

            //    Console.Write("Digite um numero positivo: ");
            //    numero = int.Parse(Console.ReadLine());

            //}
            //media = soma / total;
            //Console.WriteLine("Somatória: " + soma);
            //Console.WriteLine("Média: " + media);
            //Console.WriteLine("Total de números: " + total);

            //Console.ReadKey();

            #endregion

            #region ex:O

            //int numero, contador = 1;
            //float soma = 1; 

            //while (contador <= 10)
            //{
            //    numero = contador;
            //    if (numero % 2 == 1)
            //    {
            //        while(numero > 0)
            //        {
            //            soma = numero * soma;
            //            numero = numero - 1;
            //        }
            //        Console.WriteLine($"Fatorial de {contador} = {soma}");
            //    }
            //    contador = contador + 1; 
            //}
            //Console.ReadKey();

            #endregion

            #region ex:P

            //int soma = 0, total = 0, media, contador = 50;

            //while(contador <= 70)
            //{
            //    if (contador % 2 == 0)
            //    {
            //        soma = soma + contador;
            //        total = total + 1;
            //    }
            //    contador = contador + 1;
            //}
            //media = soma / total;
            //Console.WriteLine("Somatória: " + soma);
            //Console.Write("Média: " + media);

            //Console.ReadKey();

            #endregion

            #region ex:Q

            //string comodo = "S";
            //double largura, comprimento, tamanho = 0, total = 0;

            //while (comodo == "s" || comodo == "S") {
            //    Console.Write("Digite o nome do cômodo: ");
            //    comodo = Console.ReadLine();
            //    Console.Write("Digite a Largura: ");
            //    largura = double.Parse(Console.ReadLine());
            //    Console.Write("Digite o comprimento: ");
            //    comprimento = double.Parse(Console.ReadLine());
            //    tamanho = (largura * comprimento);
            //    Console.WriteLine($"O Cômodo \"{comodo}\" tem " +
            //        $"{tamanho}m²");
            //    Console.Write("Continuar calculando digite S: ");
            //    comodo = Console.ReadLine();
            //    total = tamanho + total;
            //}
            //Console.Write($"Tamanho total da residencia {total}m²");

            //Console.ReadKey();

            #endregion

            #region ex:R

            //int numero = 0, maior, menor;

            //Console.Write("Digite um valor: ");
            //numero = int.Parse(Console.ReadLine());
            //menor = numero;
            //maior = numero;
            //while(numero >= 0)
            //{

            //    if(numero > maior)
            //    {
            //        maior = numero;
            //    }
            //    if(numero < menor)
            //    {
            //        menor = numero;
            //    }
            //    Console.Write("Digite um valor: ");
            //    numero = int.Parse(Console.ReadLine());      
            //}
            //Console.WriteLine("O maior: " + maior);
            //Console.Write("O menor: " + menor);

            //Console.ReadKey();

            #endregion

            #region ex:S

            //int resultado = 0, num1, num2;

            //Console.WriteLine("Digite dois numeros: ");
            //num1 = int.Parse(Console.ReadLine());
            //num2 = int.Parse(Console.ReadLine());

            //while(num1 >= num2)
            //    {
            //        num1 = num1 - num2;
            //        resultado = resultado + 1;
            //    }

            //Console.Write("Resultado: " + resultado);
            //Console.ReadKey();

            #endregion




        }
    }
}
