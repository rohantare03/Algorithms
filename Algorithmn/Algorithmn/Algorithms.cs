using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Algorithms
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
        public void BubbleSort()
        {
            int[] Numbers = { 66, 55, 33, 22, 88, 11 };
            int temp;
            for (int j = 0; j <= Numbers.Length - 2; j++)
            {
                for (int i = 0; i <= Numbers.Length - 2; i++)
                {
                    if (Numbers[i] > Numbers[i + 1])
                    {
                        temp = Numbers[i + 1];
                        Numbers[i + 1] = Numbers[i];
                        Numbers[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted values are :");
            foreach (int element in Numbers)
                Console.Write(element + " ");
        }
        public void PrimeNumbers()
        {
            int i, Num, count;
            Console.WriteLine("Prime Numbers in 0-1000 range are : ");
            for (Num = 0; Num <= 1000; Num++)
            {
                count = 0;
                for ( i = 2; i <= Num / 2; i++)
                {
                    if ( Num % i == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 && Num != 1)
                    Console.WriteLine("{0}", Num);
            }
            Console.WriteLine();
        }
    }
}
