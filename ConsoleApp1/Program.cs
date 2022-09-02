using System;

namespace kalkluyator
{
    class Program
    {
        static void Main(string[] args)
        {
            MainForCalc();
        }
        static void MainForCalc()
        {
            Console.WriteLine("First Num :");
            string a = Console.ReadLine();
            int a1 = int.Parse(a);
            Console.WriteLine("Second Num :");
            string b = Console.ReadLine();
            int b1 = int.Parse(b);
            Console.WriteLine("Emeliyyati secin");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Cixma");
            Console.WriteLine("3. Bolme");
            Console.WriteLine("4. Vurma");
            Console.WriteLine("5. Qüvvete Yüksetmek");
            Console.WriteLine("6. Kök Almaq:");
            CalcMachine(a1, b1);
        }
        static void CalcMachine(int a1, int b1)
        {


            string c = Console.ReadLine();
            int c1 = int.Parse(c);
            switch (c1)
            {
                case 1:
                    int toplama = a1 + b1;
                    Console.WriteLine(toplama);
                    break;
                case 2:
                    int cixma = a1 - b1;
                    Console.WriteLine(cixma);
                    break;

                case 3:
                    try
                    {
                        int bolme = a1 / b1;
                        Console.WriteLine(bolme);
                    }
                    catch (ArithmeticException)
                    {
                        Console.WriteLine("0 a bolmek olmaz");
                    }
                    break;
                case 4:
                    int vurma = a1 * b1;
                    Console.WriteLine(vurma);
                    break;
                case 5:
                    PowerOfNumber(a1, b1);
                    break;
                case 6:
                    SquareRootOfNumber(a1, b1);
                    break;
                default:
                    Console.WriteLine("Duzgun daxil edin (1-4)");                    
                    break;
            }
        }
        static void PowerOfNumber(int a,int b)
        {
           
            Console.WriteLine("Quvvete yukseldeceyiniz ededi secin :");
            Console.WriteLine("1 - " + a);
            Console.WriteLine("2 - " + b);
            string Num = Console.ReadLine();
            int Num1 = int.Parse(Num);
            Console.WriteLine("Ededin quvvet derecesini yazin :");
            string PowerOfNumber = Console.ReadLine();
            int Number = int.Parse(PowerOfNumber);
            int i = 2;
            switch (Num1)
            {
                case 1:
                    int c = a;
                    while (i <= Number)
                    {
                        a = a * c;
                        i++;
                    }
                    Console.WriteLine(a);
                    break;
                case 2:
                    int d = b;
                    while (i <= Number)
                    {
                        b = b * d;
                        i++;
                    }
                    Console.WriteLine(b);
                    break;

            }

        }
        static void SquareRootOfNumber(int a,int b)
        {
            Console.WriteLine("Kvadrat Kokunu alacaginiz ededi secin :");
            Console.WriteLine("1 - " + a);
            Console.WriteLine("2 - " + b);
            string Num = Console.ReadLine();
            int Num1 = int.Parse(Num);
            switch (Num1)
            {
                case 1:
                    double Sqrt1 = Math.Sqrt(a);
                    Console.WriteLine(Sqrt1);
                    break;
                case 2:
                    double Sqrt2 = Math.Sqrt(b);
                    Console.WriteLine(Sqrt2);
                    break;

            }
        }
    }

}

