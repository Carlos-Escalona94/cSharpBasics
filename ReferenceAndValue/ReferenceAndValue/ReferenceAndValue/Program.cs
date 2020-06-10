using System;

namespace ReferenceAndValue
{
    public class Person
    {
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() {age = 20};
            MakeOld(person);
            Console.WriteLine(person.age);

            /*var a = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("{0} {1}", a, b));

            var array1 = new int[] {1,2,3};
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0]:{0} array2[0]:{1}", array1[0], array2[0]));*/
        }

        public static void Increment(int number)
        {

            number += 10;

        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
        }
    }
}
