using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_multifuncional
{
    public class Program
    {

        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Calculadora Simples\n ------------------------------");
            Console.WriteLine("1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n5-Somar e Multiplicar\n0-Sair");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                switch (input)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Subtração();
                        break;
                    case 3:
                        Multiplicação();
                        break;
                    case 4:
                        Divisão();
                        break;
                    case 5:
                        SomaMult();
                        break;
                    case 0:
                        break;


                    default:
                        Main();
                        break;
                }
            }
            else { Main(); }
        }
        public static int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        public static void Soma()
        {

            Console.WriteLine("Realiza a soma de 2 numeros:");
            Console.WriteLine("Primeiro Numero:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Numero:");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado:\n" + Somar(numero1, numero2));

            Console.ReadLine();

            Main();
        }
        public static int Subtrair(int primeiroNumeroSub, int segundoNumeroSub)
        {
            return primeiroNumeroSub - segundoNumeroSub;
        }
        public static void Subtração()
        {
            Console.WriteLine("Realiza a Subtração de 2 numeros:");
            Console.WriteLine("Primeiro Numero:");
            int primeiroNumeroSub = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Numero:");
            int segundoNumeroSub = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado:" + Subtrair(primeiroNumeroSub, segundoNumeroSub));
            Console.ReadLine();
            Main();
        }
        public static int Dividir(int primeiroNumeroDiv, int segundoNumeroDiv)
        {
            return primeiroNumeroDiv / segundoNumeroDiv;
        }


        public static void Divisão()
        {
            Console.WriteLine("Realiza a Divisão de 2 numeros:");
            Console.WriteLine("Primeiro Numero:");
            int primeiroNumeroDiv = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Numero:");
            int segundoNumeroDiv = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine("Resultado:" + Dividir(primeiroNumeroDiv, segundoNumeroDiv));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por Zero!");
            }

            Console.ReadLine();
            Main();
        }
        public static int Multiplicar(int primeiroNumeroMult, int segundoNumeroMult)
        {
            return primeiroNumeroMult * segundoNumeroMult;
        }
        public static void Multiplicação()
        {
            Console.WriteLine("Realiza a Multiplicação de 2 numeros:");
            Console.WriteLine("Primeiro Numero:");
            int primeiroNumeroMult = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo Numero:");
            int segundoNumeroMult = int.Parse(Console.ReadLine());
            Console.WriteLine("Resultado:" + Multiplicar(primeiroNumeroMult, segundoNumeroMult));
            Console.ReadLine();
            Main();
        }
        public static void SomaMult()
        {
            Console.WriteLine("1º numero");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("2º numero");
            int segundoNumero = int.Parse(Console.ReadLine());

            int resultadoSoma = Somar(primeiroNumero, segundoNumero);

            Console.WriteLine("3º numero");
            int terceiroNumero = int.Parse(Console.ReadLine());

            int resultadoMult = Multiplicar(resultadoSoma, terceiroNumero);

            Console.WriteLine("Resultado:\n" + resultadoMult);
            Console.ReadLine();

            Main();
        }

    }
}
