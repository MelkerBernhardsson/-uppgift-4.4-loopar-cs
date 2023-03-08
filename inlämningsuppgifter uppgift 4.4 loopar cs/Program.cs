using System;

namespace loopar7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("välj ett av alternativen: ");
            Console.WriteLine("1. subtrahera ett tal med ett annat");
            Console.WriteLine("2. dividera ett tal med ett annat");
            Console.WriteLine("3. avsluta programmet");
            int val = int.Parse(Console.ReadLine());
            switch (val)
            {
                case 1:
                    Console.WriteLine("välj två tal (det första subtraheras md det andra)");
                    int ch1 = int.Parse(Console.ReadLine());
                    int ch2 = int.Parse(Console.ReadLine());
                    int ans = ch1 - ch2;
                    Console.WriteLine("när dina tal suptraheras blir det: " + ans);
                    break;
                case 2:
                    Console.WriteLine("välj två tal (det första divideras med det andra)");
                    int ch3 = int.Parse(Console.ReadLine());
                    int ch4 = int.Parse(Console.ReadLine());
                    int ans2 = ch3/ch4;
                    Console.WriteLine("när du dividerar dina tal med varandra blir det: " + ans2);
                    break;
                case 3:
                    Console.WriteLine("ok hejdå!!");
                    break;
            }
        }
    }
}
