using System;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1, str2 = ""; int i;


            Console.WriteLine("Please enter a string");
            str1 =Console.ReadLine();
            for (i = 0; i < str1.Length; i++) 
            { 
            if (str1[i] == 'a' || str1[i] == 'e'|| str1[i] == 'i' || str1[i] == 'o' || str1[i] == 'u' 
                    || str1[i] == 'A' || str1[i] == 'E' || str1[i] == 'I' || str1[i] == 'O' || str1[i] == 'U')
                {

                }
            else
                {
                    str2 =str2 + str1[i];
                }
                Console.WriteLine(str2);
            }
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
