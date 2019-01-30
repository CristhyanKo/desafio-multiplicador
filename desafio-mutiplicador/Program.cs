using System;

namespace desafio_mutiplicador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================================================");
            Console.WriteLine("=                        Desafio Multiplicador - TJMT                        =");
            Console.WriteLine("=============================================================================");
            Console.WriteLine();
            Console.Write("Objetivo: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("O desafio consiste em fazer um algorítimo que multiplique 2 números");
            Console.Write("          inteiros sem o uso do operador de multiplicação (");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(")");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite o primeiro número: ");
            var firstNumber = Console.ReadLine();
            Console.Write("Digite o segundo número: ");
            var secondNumber = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("A multiplicação dos dois números é igual a: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Calcular(Convert.ToInt32(firstNumber), Convert.ToInt32(secondNumber)));
            Console.ReadKey();
        }

        private static int Multiplicar(int firstNumber, int secondNumber)
        {
            if (firstNumber == 0 || secondNumber == 0)
                return firstNumber;

            return firstNumber + Multiplicar(firstNumber, secondNumber - 1);
        }

        private static int Calcular(int firstNumber, int secondNumber)
        {
            var firstNumberFix = (firstNumber < 0) ? (0 - (firstNumber)) : firstNumber;
            var secondNumberFix = (secondNumber < 0) ? (0 - (secondNumber)) : secondNumber;

            return Multiplicar(firstNumberFix, secondNumberFix) - firstNumberFix;
        }
    }
}
