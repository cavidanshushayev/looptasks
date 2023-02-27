namespace sadeededcemi
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                int eded = 100;
                int say = 0;
                int cem = 0;

                for (int i = 2; i < eded; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {

                            say = say + 1;
                        }


                    }
                    if (say < 1)
                    {
                        cem += i;

                    }
                    say = 0;

                }



                Console.WriteLine(cem);
            }
        }
    }