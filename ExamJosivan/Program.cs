using System;

namespace ExamJosivan
{
    class Program
    {

        static void Main(string[] args)  //Question 1-----
        {
            var myName = "Josivan Santos";
            Console.WriteLine("");
            Console.WriteLine("Question 1");
            Console.WriteLine(myName + " " + DateTime.Now);
            Console.WriteLine("");
            Console.ReadLine();
        }
        static void countString()  // Question 2----------
        {
            Console.WriteLine("Question 2");
            Console.WriteLine("");
            Console.WriteLine("Type something");
            string name = Console.ReadLine();
            int nameLength = name.Length;
            Console.WriteLine("The word you typed is: " + name + ", and contains " + nameLength + " letter(s).");

            Console.ReadLine();
        }
        static void evenOdd()      // Question 3----------
        {
            Console.WriteLine("Question 3");
            Console.WriteLine("");
            int q3;
            Console.WriteLine("Type a number");
            while (int.TryParse(Console.ReadLine(), out q3))
            {
                Console.WriteLine(q3 % 2 == 0 ? "EVEN" : "ODD");
                Console.WriteLine("Enter again, or type " + "'ENTER'" + " to exit");
            }
        }
        static void printTill10()  // Question 4----------
        {
            Console.WriteLine("Question 4");
            Console.WriteLine("");
            for (int num = 1; num <= 10; num++)

            {
                System.Console.WriteLine("{0}", num);
            }
        }
        static void multiplie()    // Question 5----------
        {
            int num1;
            int num2;
            string operation;
            int result;

            Console.WriteLine("Please enter your First Value");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your Second Value");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose the operation: ( * or + ) ");
            operation = Console.ReadLine();

            if (operation == "*")
            {
                result = (num1 * num2);
                Console.WriteLine("The operation result is : " + result);
            }

            if (operation == "+")
            {
                result = (num1 + num2);
                Console.WriteLine("The operation result is : " + result);
            }
        }
        static void WeekDay()      // Question 6----------
        {
            Console.WriteLine("Question 6");
            Console.WriteLine("");
            Console.WriteLine("Type a date format: AAAA-MM-DD");
            string weekDay = Console.ReadLine();
            DateTime parsedDate = DateTime.Parse(weekDay);
            Console.WriteLine("");
            Console.WriteLine("Week day is:" + " " + parsedDate.ToString("dddd"));
        }
        static void PosOrNeg()     // Question 7----------

        {
            int typedNumber;
            Console.WriteLine("Enter your value");
            typedNumber = int.Parse(Console.ReadLine());

            if (typedNumber < 0)
            {
                Console.WriteLine("It´s a negative number!");
            }
            else if (typedNumber == 0)
            {
                Console.WriteLine("It´s 'Zero'");
            }
            else
            {
                Console.WriteLine("It´s a positive number!");
            }
        }
        static void upperCase()    // Question 8----------

        {
            string[] strArray2 = new string[] { "this", "is", "an", "array" };
            Console.Write("Before converting to-upper: ");
            Array.ForEach<string>(strArray2, delegate (string x) { Console.Write(x + " "); });
            Console.WriteLine();

            string[] revArray = Array.ConvertAll<string, string>(strArray2, delegate (string s) { return s.ToUpper(); });
            Console.Write("Converted to upper-case: ");
            Array.ForEach<string>(revArray, delegate (string x) { Console.Write(x + " "); });
            Console.WriteLine();
        }
        static void array()        // Question 9----------
        {
            int[] arr1 = { 1, 3, 6 };
            int[] arr2 = { 2, 5, 4 };

            // show array1

            Console.WriteLine("Array 1...");
            foreach (int element in arr1)
            {
                Console.WriteLine(element);
            }
            // show  array2
            Console.WriteLine("Array 2...");
            foreach (int element in arr2)
            {
                Console.WriteLine(element);
            }
            var myList = new List <int>();
            myList.AddRange(arr1);
            myList.AddRange(arr2);
            int[] arr3 = myList.ToArray();

            // Sort array in ascending order. 
            Array.Sort(arr3);

            Console.WriteLine("Combined elements..");
            foreach (int res in arr3)
            {
                Console.WriteLine(res);
            }
        }
    }
        //Question 10----------------------------------------------------                
}
    
