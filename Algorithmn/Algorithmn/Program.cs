namespace Algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Assignment");
            Console.WriteLine("1 for insert sort");
            Console.WriteLine("2 for anagrams");

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
            }
           
        }
    }
}
