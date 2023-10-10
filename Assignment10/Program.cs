using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment10{ 

    class Program
    {
        static void Main(string[] args)
        {
            // Example usage of StringConcatenation
            A a = new A();
            AttachStringToEachOther concatenateDelegate = a.ConcatStrings;
            string concatenatedString = concatenateDelegate("Hello, ", "World!");
            Console.WriteLine("Concatenated String: " + concatenatedString);

            // Example usage of StringLength
            StringUtility stringUtility = new StringUtility();
            FindLength lengthDelegate = stringUtility.StringLength;
            int length = lengthDelegate("Hello, World!");
            Console.WriteLine("Length of the String: " + length);

            // Example usage of GreetUser
            Greeting greeting = new Greeting();
            greeting.UserGreeted += name => Console.WriteLine("Hello, " + name + "!");
            greeting.Greet("John");

            // Example usage of ModifyString
            StringModifier stringModifier = new StringModifier();
            stringModifier.FirstCharacterUppercase += s => char.ToUpper(s[0]) + s.Substring(1);
            string modifiedString = stringModifier.ModifyString("hello");
            Console.WriteLine("Modified String: " + modifiedString);

            Console.ReadLine();
        }
    }

}
