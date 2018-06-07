using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Atividade a"

            //Console.Write("Digite uma temperatura em °C: ");

            //double c, f;
            //c = double.Parse(Console.ReadLine());

            //f = (9.0 * c + 160.0) / 5.0;
            ////Console.WriteLine("O valor de Celsius em Fahrenheit é: "+ f);//concatenação
            ////Console.WriteLine($"O valor de Celsius em Fahrenheit é: {f}");//interpolação
            //Console.WriteLine($"O valor de Celsius em Fahrenheit é: {f:0.00}");//interpolação

            //Console.ReadKey();

            #endregion

            #region "Atividade b"

            //Console.Write("Digite uma temperatura em °F: ");

            //double C, F;
            //F = double.Parse(Console.ReadLine());

            //C = (F - 32.0) * (5.0 / 9.0);
            //Console.WriteLine($"A temperatura de Fahrenheit em Celsius: {C:0.00} °F");
            //Console.ReadKey();

            #endregion

            #region "Atividade c"

            ////double alturalata, raiolata;
            //Console.Write("Digite a altura da lata: ");
            //double alturalata = double.Parse(Console.ReadLine());

            //Console.Write("Digite o Raio da lata: ");
            //double raiolata = double.Parse(Console.ReadLine());

            //double volume = (3.14159 * (raiolata * raiolata) * alturalata);
            //Console.WriteLine($"O volume da lata é: {volume:0.00}");
            //Console.ReadKey();

            #endregion

            #region "Atividade d"

            //Console.Write("Digite o tempo em "minutos" gasto na viagem: ");
            //double tempo = double.Parse(Console.ReadLine());

            //Console.Write("Digite a velocidade média: ");
            //double velocidade = double.Parse(Console.ReadLine());

            //double distancia = tempo * velocidade;

            //double litrosgasto = distancia / 12;

            //Console.WriteLine();
            //Console.WriteLine($"A velocidade foi: {velocidade}Km/h");
            //Console.WriteLine($"O tempo foi: {tempo/60}h");
            //Console.WriteLine($"A distância percorrida foi: {distancia}Metros");
            //Console.WriteLine($"O consumo de litros foi: {litrosgasto}L");

            //Console.ReadKey();

            #endregion

            #region "Atividade e"

            //Console.Write("Digite o valor da prestação: ");
            //double valor= double.Parse(Console.ReadLine());

            //Console.Write("Digite a taxa ao mês: ");
            //double taxa= double.Parse(Console.ReadLine());

            //Console.Write("Digite o tempo em meses: ");
            //int tempo = int.Parse(Console.ReadLine());

            //double prestacao = valor + (valor * (taxa / 100) * tempo);
            //Console.Write($"prestação em atraso é: R${prestacao:0.00}");

            //Console.ReadKey();

            #endregion

            #region "Atividade f"

            //Console.Write("A Digite uma valor: ");
            //double A = double.Parse(Console.ReadLine());

            //Console.Write("B Digite outro valor: ");
            //double B = double.Parse(Console.ReadLine());

            //double C = A;
            //A = B;
            //B = C;

            //Console.WriteLine(A);
            //Console.WriteLine(B);

            //Console.ReadKey();

            #endregion

            #region "Atividade g"

            //Console.Write("Digite o 1º número: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Digite o 2º número: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Digite o 3º número: ");
            //int c = int.Parse(Console.ReadLine());
            //Console.Write("Digite o 4º número: ");
            //int d = int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Multiplicação");
            //double cd_multiplicação = c * d;
            //Console.WriteLine($"{a} x {b} = {a * b}");
            //Console.WriteLine($"{a} x {c} = {a * c}");
            //Console.WriteLine($"{a} x {d} = {a * d}");
            //Console.WriteLine($"{b} x {c} = {b * c}");
            //Console.WriteLine($"{b} x {d} = {b * d}");
            //Console.WriteLine($"{c} x {d} = {cd_multiplicação}");

            //Console.WriteLine();
            //Console.WriteLine("Adição");
            //Console.WriteLine($"{a} + {b} = {a + b}");
            //Console.WriteLine($"{a} + {c} = {a + c}");
            //Console.WriteLine($"{a} + {d} = {a + d}");
            //Console.WriteLine($"{b} + {c} = {b + c}");
            //Console.WriteLine($"{b} + {d} = {b + d}");
            //Console.WriteLine($"{c} + {d} = {c + d}");

            //Console.ReadKey();

            #endregion

            #region "Atividade h"

            //Console.Write("Digite o comprimento da caixa: ");
            //double comprimento = double.Parse(Console.ReadLine());
            //Console.Write("Digite a largura: ");
            //double largura = double.Parse(Console.ReadLine());
            //Console.Write("Digite a altura: ");
            //double altura = double.Parse(Console.ReadLine());

            //double volume = comprimento * largura * altura;
            //Console.WriteLine("O Volume da caixa é: "+ volume);

            //Console.ReadKey();

            #endregion

            #region "Atividade i"

            //int x;

            //Console.Write("Insira um Valor: ");
            //x = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write($"O número {x} ao quadrado é: {x * x}");

            //Console.ReadKey();

            #endregion

            #region "Atividade j"

            //int a, b;

            //Console.Write("Digite um valor: ");
            //a = int.Parse(Console.ReadLine());

            //Console.Write("Digite um valor: ");
            //b = int.Parse(Console.ReadLine());

            //double x = (a * a) - (b * b);
            //Console.Write($"o quadrado da diferença do primeiro valor pelo segundo valor: "+ x);

            //Console.ReadKey();

            #endregion

            #region "Atividade k"

            //Console.Write("Insira o valor em Reais: ");
            //double real = double.Parse(Console.ReadLine());

            //Console.Write("Digite a cotação do Dólar: ");
            //double dolar = double.Parse(Console.ReadLine());

            //double atualdolar = dolar * real;

            //Console.WriteLine($"Você tem em dolar: {atualdolar}");

            //Console.ReadKey();

            #endregion

            #region "Atividade l"

            //Console.Write("Digite a cotação do Dólar: ");
            //double dolar = double.Parse(Console.ReadLine());

            //Console.Write("Insira o valor em Reais: ");
            //double real = double.Parse(Console.ReadLine());

            //double atualdolar = real * dolar;

            //Console.WriteLine($"Você tem em dolar: {atualdolar}");

            //Console.ReadKey();

            #endregion

            #region "Atividade m"

            //Console.Write("DIgite um valor: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Digite outro valor: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Digite um outro valor: ");
            //int c = int.Parse(Console.ReadLine());

            //double total = ((a * a) + (b * b) + (c * c));

            //Console.Write($"O valor da soma dos quadrados dos três valoress: {total:0.00}");

            //Console.ReadKey();

            #endregion

            #region "Atividade n"

            //Console.Write("DIgite um valor: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Digite outro valor: ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Digite um outro valor: ");
            //int c = int.Parse(Console.ReadLine());

            //Console.Write("O valor da soma dos quadrados dos três valoress: "+ ((a*a)+(b*b)+(c*c)));

            //Console.ReadKey();

            #endregion

            #region "Atividade o"

            //Console.Write("Digite um número: ");
            //int A = int.Parse(Console.ReadLine());

            //Console.Write("Digite um número: ");
            //int B = int.Parse(Console.ReadLine());

            //Console.Write("Digite um número: ");
            //int C = int.Parse(Console.ReadLine());

            //Console.Write("Digite um número: ");
            //int D = int.Parse(Console.ReadLine());

            //int S = (B + D);
            //double P = (A * C);

            //Console.WriteLine($"A soma de S é: {S}");
            //Console.WriteLine($"O produto de P é: {P}");

            //Console.ReadKey();

            #endregion

            #region "Atividade p"

            //Console.Write("Digite o salário mensal: ");
            //long SM = long.Parse(Console.ReadLine());

            //Console.Write("Digite o valor do percentual de reajuste: ");
            //long PR = long.Parse(Console.ReadLine());

            //long NS = (SM * (PR / 100)) + SM;
            //Console.Write($"O novo valor do sálario: R${NS:0.00}");

            //Console.ReadKey();

            #endregion

            #region "Atividade q"

            //Console.Write("Digite o valor do raio: ");
            //double R = double.Parse(Console.ReadLine());

            //double A = 3.14159 * (R * R);

            //Console.WriteLine("O Valor do raio é: " + A);

            //Console.ReadKey();

            #endregion

            #region "Atividade r"

            //Console.Write("Quantidades de votos para candidato A: ");
            //double a = double.Parse(Console.ReadLine());

            //Console.Write("Quantidades de votos para candidato B: ");
            //double b = double.Parse(Console.ReadLine());

            //Console.Write("Quantidades de votos para candidato C: ");
            //double c = double.Parse(Console.ReadLine());

            //Console.Write("Digite a quantidade de votos Nulos: ");
            //double nulos = double.Parse(Console.ReadLine());

            //Console.Write("Digite a quantidade de votos em Branco: ");
            //double brancos = double.Parse(Console.ReadLine());

            //double votovalido = a + b + c;
            //double total = votovalido + nulos + brancos;
            //Console.WriteLine();
            //Console.WriteLine($"O percentual total valido foi: {(votovalido * 100) / total:0.00}%");
            //Console.WriteLine($"O percentual de A: {(a * 100) / total:0.00}%");
            //Console.WriteLine($"O percentual de B: {(b * 100) / total:0.00}%");
            //Console.WriteLine($"O percentual de C: {(c * 100) / total:0.00}%");
            //Console.WriteLine($"O percentual de Nulos: {(nulos * 100) / total:0.00}%");
            //Console.WriteLine($"O percentual de Brancos: {(brancos * 100) / total:0.00}%");

            //Console.ReadKey();

            #endregion

            #region "Atividade s"

            //Console.Write("Digite um valor: ");
            //double A = double.Parse(Console.ReadLine());

            //Console.Write("Digite um valor: ");
            //double B = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine($"{A} x {B} = {A * B}");
            //Console.WriteLine($"{A} + {B} = {A + B}");
            //Console.WriteLine($"{A} / {B} = {A / B}");
            //Console.WriteLine($"{A} - {B} = {A - B}");

            //Console.ReadKey();

            #endregion

            #region "Atividade t"

            //Console.Write("Digite a distancia de um projétil que percorre uma determinada distância em quilômetros: ");
            //double distância = double.Parse(Console.ReadLine());

            //Console.Write("Digite um determinado espaço de tempo percorrido pelo projétil em minutos: ");
            //double tempo = double.Parse(Console.ReadLine());

            //Console.WriteLine();
            //double Velocidade = (distância * 1000) / (tempo * 60);
            //Console.WriteLine($"A distância em metros por segundo do projétil foi: {Velocidade:0.00}");

            //Console.ReadKey();

            #endregion

            #region "Atividade u"

            //Console.WriteLine("descobrir o volume de um espera");
            //Console.Write("Digite o raio para conversão: ");
            //double raio = double.Parse(Console.ReadLine());

            //double Volume = (4 / 3) * 3.14159 * (raio * raio * raio);
            //Console.Write($"O Raio é de: {Volume:0.00}m³");

            //Console.ReadKey();

            #endregion
        }
    }
}
