using System.Globalization;

namespace duzbucaqliApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zehmet olmasa kvadratin hundurluyunu daxil edin");
            int hun = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("zehmet olmasa kvadratin enini  daxil edin");
            int en = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= hun; i++)
            {
                for (int j = 1; j <= en; j++)
                {
                    if (i == 1 || i == hun)
                    {
                        Console.Write("*");
                    }
                    else if(j==1 || j == en)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine("");
            }
            Console.WriteLine("Cavidan Shushayev");
        }
    }
}

