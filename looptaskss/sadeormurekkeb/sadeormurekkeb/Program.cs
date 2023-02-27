namespace sadeormurekkeb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ededi daxil edin");
            int eded = Convert.ToInt32(Console.ReadLine());
            int say = 0;

            for(int i = 1; i <= eded; i++)
            {
                if (eded % i == 0)
                {
                    say = say + 1;
                }

            }
            if (say <= 2)
            {
                Console.WriteLine("sadedir");
            }else
            {
                Console.WriteLine("murekkebdir");
            }

        }
    }
}