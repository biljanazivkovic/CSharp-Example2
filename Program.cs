using System;

namespace ex2
{
    
    class Program
    {
        /* Strings */
        static void Main(string[] args)
        {
            /* String Length */
            string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("The length of the text string is: " + text.Length);

            /* ToLower method */
            string secondText = text.ToLower();
            Console.WriteLine("Second text is: " + secondText);

            /* Concatenation */
            string firstName = "Biljana ";
            string lastName = "Zivkovic";
            string name = firstName + lastName;
            Console.WriteLine(name);

            string fullName = string.Concat(firstName, lastName);
            Console.WriteLine(fullName);

            /* Access Strings */
            Console.WriteLine(firstName[0]);
            Console.WriteLine(firstName.IndexOf("B"));

            int position = name.IndexOf("Z");
            string newLastName = name.Substring(position);
            Console.WriteLine(newLastName);

            /* Special characters */
            string txt = "We are the so-called \"Vikings\" from the north.";
            Console.WriteLine(txt);

        }
    }
}
