namespace Algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Assignment");
            Console.WriteLine("1 for insert sort");
            Console.WriteLine("2 for anagrams");
            Console.WriteLine("3 for bubble sort");
            Console.WriteLine("4 for prime numbers");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Algorithms algorithms = new Algorithms();
                    algorithms.Insert();
                    break;
                case 2:
                    Algorithms anagram = new Algorithms();
                    anagram.Anagrams();
                    break;
                case 3:
                    Algorithms bubble = new Algorithms();
                    bubble.BubbleSort();
                    break;
                case 4:
                    Algorithms prime = new Algorithms();    
                    prime.PrimeNumbers();
                    break;

            }
           
        }
    }
}
