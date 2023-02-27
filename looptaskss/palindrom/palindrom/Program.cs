namespace palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("zehmet olmasa ededi daxil edin");
            int eded = Convert.ToInt32(Console.ReadLine());
            
            int ters = 0;
            int a;
            int m = eded;

            while (eded > 0)
            {
                 a = eded % 10;
                ters = (ters * 10) + a;
                eded = eded / 10;

            }

            if ( ters ==m)
            {
                Console.Write("palindromdur");
            }
            else
            {
                Console.Write("palindrom deyil" );
            }
        }
       
        }
    }
