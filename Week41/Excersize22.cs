using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week41
{
    class Excersize22
    {
        public static void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> listOfInt = new List<int>();
            listOfInt.Add(4);
            listOfInt.Add(12);
            listOfInt.Add(9);

            // Case 1
            Console.WriteLine("Case 1: Element with index 1 is {0}", listOfInt[1]);

            // Case 2
            Console.WriteLine("Case 2: List contains {0} elements", listOfInt.Count);

            listOfInt.Add(5);
            listOfInt.Add(22);

            // Case 3
            Console.WriteLine("Case 3: Element with index 3 is {0}", listOfInt[3]);

            listOfInt.RemoveAt(0);

            // Case 4
            Console.WriteLine("Case 4: Element with index 3 is {0}", listOfInt[3]);



            listOfInt.Clear();
            listOfInt.Add(14);
            listOfInt.Add(87);
            listOfInt.Add(62);
            listOfInt.Add(21);
            listOfInt.Add(40);
            listOfInt.Add(3);

            // Case 5: Add code that prints out 
            // all the elements in the list
            foreach(int i in listOfInt)
            {
                Console.Write($"{i}    ");
            }
            Console.WriteLine();


            // Case 6: Add code that finds the 
            // sum of the elements in the list, and prints the result
            int sum=0;
            foreach(int i in listOfInt)
            {
                sum = sum + i;
            }
            Console.WriteLine($"Sum is: {sum}");

            // [DIFFICULT]
            // Case 7: Add code that finds the smallest  
            // element in the list, and prints the result
            // Tip: Think in detail about how you would do this manually
            int smallest=listOfInt[1];
            for(int i = 0; i<listOfInt.Count; i++)
            {
                if (listOfInt[i] < smallest)
                {
                    smallest = listOfInt[i];
                }
            }
            Console.WriteLine($"Smallest: {smallest}");
            // [(maybe) DIFFICULT]
            // Case 8: Add code that sorts the content of the list.
            // Tip: Think before you code...
            List<int> SortedList = listOfInt;
            for (int i = (SortedList.Count - 1); i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (SortedList[j - 1] > SortedList[j])
                    {
                        var temp = SortedList[j - 1];
                        SortedList[j - 1] = SortedList[j];
                        SortedList[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted List:");
            foreach(int j in SortedList)
            {
                Console.Write($"{j}    ");
            }

            // The LAST line of code should be ABOVE this line
        }
    }
}
