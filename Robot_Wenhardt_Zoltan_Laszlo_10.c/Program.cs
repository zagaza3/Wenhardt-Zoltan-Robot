using System;

namespace Robot_Wenhardt_Zoltan_Laszlo_10.c
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canRun = true;
            string input, rovidut;
            int e, d, k, n;
            char eL = 'e', dL = 'd', kL = 'k', nL = 'n';
            while (canRun)
            {
                rovidut = "";
                input = "";
                e = 0;
                d = 0;
                k = 0;
                n = 0;
                Console.WriteLine("Program megállítása : Stop | Kérem a robot parancsait: ");
                input = Console.ReadLine();
                input = input.ToLower();
                if (input == "stop")
                {
                    canRun = false;
                }
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] == 'e')
                        {
                            e++;
                        }
                        if (input[i] == 'd')
                        {
                            d++;
                        }
                        if (input[i] == 'k')
                        {
                            k++;
                        }
                        if (input[i] == 'n')
                        {
                            n++;
                        }
                    }
                    int minED = Math.Min(e, d);
                    e -= minED;
                    d -= minED;

                    int minKN = Math.Min(k, n);
                    k -= minKN;
                    n -= minKN;

                    Console.WriteLine("E betűk száma: " + e);
                    Console.WriteLine("D betűk száma: " + d);
                    Console.WriteLine("K betűk száma: " + k);
                    Console.WriteLine("N betűk száma: " + n);
                    for (int i = 0; i < e; i++)
                    {
                        rovidut = rovidut + eL;
                    }
                    for (int i = 0; i < d; i++)
                    {
                        rovidut = rovidut + dL;
                    }
                    for (int i = 0; i < k; i++)
                    {
                        rovidut = rovidut + kL;
                    }
                    for (int i = 0; i < n; i++)
                    {
                        rovidut = rovidut + nL;
                    }
                    Console.WriteLine("Egy legrövidebb út parancsszava: " + rovidut);
                }
            }
        }
    }
}
//Wenhardt Zoltán László 10.c 2024.11.21
