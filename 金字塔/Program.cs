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

            blank(n - i);

            asterisk(2 * i - 1);

            Console.WriteLine("");

            if (n != i)
            {

                recursive(n, i + 1);

            }

        }

        private void blank(int i)
        {

            printString(i, " ");

        }

        private void asterisk(int i)
        {

            printString(i, "*");

        }

        private void printString(int i, String s)
        {

            while (i > 0)
            {

                Console.Write(s);

                i--;

            }

        }

    }

}
