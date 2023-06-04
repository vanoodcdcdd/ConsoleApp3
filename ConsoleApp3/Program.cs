using System.Globalization;
using System.Xml.Schema;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tiv1 = 50;
            int tiv2 = 70;
            int tiv3 = 0;

            for (int i = tiv1; i <= tiv2; i++)

            {
                while (tiv3 == 1)
                {


                    if (i % 2 == 0)
                    {
                        tiv3 = (i / 2 * 3 + 1) / 2;
                    }
                    else
                    {
                        tiv3 = (i * 3 + 1) / 2;
                    }
                }
                



            }
Console.WriteLine(tiv3);
        }
    }
}