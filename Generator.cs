using System;

namespace LXD16
{
    public class Program
    {
        //This is not required to generate a number unless you're not calling the Generate() method from another script
        public static void Main(string[] args) 
        {
            Generate(false);
        }

        public static int num;
        public static void Generate(bool allowNegatives)  //The Generate() method takes in a boolean to determine whether it can generate negative numbers
        {
            Random ran = new Random();
            int l = ran.Next(0,5000);
            int d = 0;
            for(int i = 0; i < l; i++) 
            {
                d += i * i^16;
            }

            //Final Product
            int x = d^16;
            if(x < 1 && !allowNegatives) 
            {
                //If the number is negative, regenerate the number
                Generate(false);
            }
            num = x;

            //Just comment this out or delete it along with the PrintOutput() method, unless you want to print the number to the console.
            PrintOutput(num);
        }

        public static void PrintOutput(int num) 
        {
            //Prints the generated number to the console along with the length
            int i2 = 0;
            foreach(char c in num.ToString()) 
            {
                i2++;
            }
            Console.WriteLine(num + " [" + i2 + "]");

            Console.ReadLine();
            Generate(false);
        }
    }
}
