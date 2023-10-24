namespace Nested_For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 3;
            int colums = 2;
            for (int r = 1; r <= rows; r++) {
                Console.WriteLine("row = " + r);
                for (int c = 1; c <= colums; c++)
                {
                    Console.WriteLine(" colums" +  c);
                }
            }
        }
    }
}