using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class list
    {
      
        public list()
        {

            List<int> numbers = new List<int>();
            Console.WriteLine("Created an empty list.");

            // 2. Adding Elements to a List
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(10);
            Console.WriteLine("Added elements: 1, 2, 3");

            // 3. Accessing Elements in a List
            Console.WriteLine($"First element: {numbers[0]}");

            // 4. Inserting Elements
            numbers.Insert(1, 10);
            Console.WriteLine("Inserted 10 at index 1");

            // 5. Removing Elements
            numbers.Remove(10); // By value
            Console.WriteLine("Removed 10 by value");

            numbers.RemoveAt(0); // By index
            Console.WriteLine("Removed element at index 0");

            // 6. Checking if an Element Exists
            bool containsTwo = numbers.Contains(2);
            Console.WriteLine($"List contains 2: {containsTwo}");

            // 7. Finding Elements
            int foundNumber = numbers.Find(n => n > 2);
            Console.WriteLine($"First number greater than 2: {foundNumber}");

            List<int> evenNumbers = numbers.FindAll(n => n % 2 == 0);
            Console.WriteLine("All even numbers:");
            foreach (int num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            // 8. Sorting a List
            numbers.Sort();
            Console.WriteLine("Sorted list:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // 9. Reversing a List
            numbers.Reverse();
            Console.WriteLine("Reversed list:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // 10. Getting the Number of Elements
            Console.WriteLine($"Number of elements in list: {numbers.Count}");

            // 11. Converting a List to an Array
            int[] numbersArray = numbers.ToArray();
            Console.WriteLine("Converted list to array:");
            foreach (int num in numbersArray)
            {
                Console.WriteLine(num);
            }

            // 12. Iterating Over a List
            Console.WriteLine("Iterating over list:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // 13. Adding a Range of Elements
            numbers.AddRange(new int[] { 4, 5, 6 });
            Console.WriteLine("Added range: 4, 5, 6");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // 14. Removing a Range of Elements
            numbers.RemoveRange(1, 2);
            Console.WriteLine("Removed 2 elements starting at index 1:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // 15. Capacity vs. Count
            Console.WriteLine($"Capacity of list: {numbers.Capacity}");
            Console.WriteLine($"Count of list: {numbers.Count}");

            // 16. Checking Index of an Element
            int index = numbers.IndexOf(4);
            Console.WriteLine($"Index of 4: {index}");

            // 17. Checking if All Elements Match a Condition
            bool allEven = numbers.TrueForAll(n => n % 2 == 0);
            Console.WriteLine($"All elements are even: {allEven}");

            // 18. Copying to Another List
            int[] array = new int[numbers.Count];
            numbers.CopyTo(array);
            Console.WriteLine("Copied list to array:");
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }

            // 19. Getting a Range of Elements
            List<int> subList = numbers.GetRange(1, 2);
            Console.WriteLine("Sublist (3 elements starting at index 1):");
            foreach (int num in subList)
            {
                Console.WriteLine(num);
            }

            // 20. Custom Sorting
            numbers.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine("List sorted in descending order:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
