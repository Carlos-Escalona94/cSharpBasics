using System;

namespace IntroStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firtsName = "Mosh";
            String lastName = "Hamedani";
            string myname = "Mosh";

            var fullName = firtsName + " " + lastName;

            var myFullName = string.Format("{0} {1}", firtsName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            Console.WriteLine(formattedNames);

            var text = @"Hi John
Look into the following paths
c:\folder1\folder2";

            Console.WriteLine(text);

        }
    }
}
