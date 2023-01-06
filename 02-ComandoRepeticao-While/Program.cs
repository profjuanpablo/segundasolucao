namespace _02_ComandoRepeticao_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10) {
                Console.WriteLine($"Contando: {i} x 5 = {i*5}");
                i++; // i = i+1
            }
            Console.WriteLine("------------------");
            
            for (int j = 1; j <=10; j++)
            {
                Console.WriteLine($"Contando: {j} x 5 = {j*5}");
            }
        }
    }
}