using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Algorithms
    {
        public void Insert()
        {
            string[] names = { "Rohan", "Xerbes", "Ben", "Pauli", "Mark" };
            InsertSort(names);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
        public void InsertSort(IComparable[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {

                IComparable value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
        }
        public void Anagrams()
        {
            Console.WriteLine("Enter the First Name:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Second Name:");
            string SecondName = Console.ReadLine();

            char[] charFirst = FirstName.ToCharArray();
            char[] charSecond = SecondName.ToCharArray();
            Array.Sort(charFirst);
            Array.Sort(charSecond);

            string firstName = new string(charFirst);
            string secondName = new string(charSecond);
            if (firstName == secondName)
            {
                Console.WriteLine("The Entered Words are Anagrams", firstName, secondName);
            }
            else
            {
                Console.WriteLine("The Entered Words are not Anagrams", firstName, secondName);
            }
        }
    }
}
