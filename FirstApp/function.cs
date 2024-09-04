using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class function
    {
        public function()
        {

            DisplayMessage();
          var value=  GetNumber();
            Console.WriteLine(value);

            var stringValue = GetGreeting();
            Console.WriteLine(stringValue);

            var flagValue = IsTrue();
            Console.WriteLine(flagValue);

            var numbers = GetNumbers();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var sum = Add(10, 30);
            Console.WriteLine($"addition is {sum}");
            var person = CreatePerson("lily", 25);
            Console.WriteLine($"person name is {person.Name} and her age is {person.Age}");

            DisplayGreeting();
            DisplayGreeting("hello lily");

        }

        //1.No Parameters and No Return Value(void)
        void DisplayMessage()
        {
            Console.WriteLine("Hello, World!");
        }

        //2. No peramater and a return Type  int
        int GetNumber()
        {
            return 42;
        }

        //3. No peramater and a return Type  string

        string GetGreeting()
        {
            return "Hello, World!";
        }

        //4. No perameter and a bool return type
        bool IsTrue()
        {
            return true;
        }

        //5. No perameter and a return type is list
        List<int> GetNumbers()
        {
            return new List<int> { 10, 20, 30, 40, 15 };
        }

        //6.perameter and with return type

        int Add(int a, int b)
        {
            return a + b;
        }


      //7. return an object
        Person CreatePerson(string name, int age)
        {
            return new Person { Name = name, Age = age };
        }


        // Optional Parameters

        void DisplayGreeting(string name = "Guest")
        {
            Console.WriteLine($"Hello, {name}!");
        }

    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
