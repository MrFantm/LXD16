using System;

namespace LXD16
{
    public class Program
    {
        
        public static void Main(string[] args) 
        {
            Generate();
        }

        public static int num;
        public static void Generate() 
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
            if(x < 1) 
            {
                //If the number is negative, regenerate the number
                Generate();
            }
            num = x;
        }
    }
}
