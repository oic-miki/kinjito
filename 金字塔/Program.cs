using System;

namespace Main
{

    class Program
    {

        static void Main(string[] args)
        {

            string s = Console.ReadLine();

            new Program().recursive(int.Parse(s), 1);

        }

        private void recursive(int n, int i)
        {

            for (int blank = n - i; blank > 0; blank--)
            {

                Console.Write(" ");

            }

            for (int asterisk = 2 * i - 1; asterisk > 0; asterisk--)
            {

                Console.Write("*");

            }

            Console.WriteLine("");

            if (n != i)
            {

                recursive(n, i + 1);

            }

        }

    }

}
