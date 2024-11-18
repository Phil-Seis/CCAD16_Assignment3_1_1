using System.ComponentModel;
using System.Text;

namespace CCAD16_Assignment3_1_1
{
    internal class Program
    {
        //Write a method that returns a string of even numbers greater than 0 and less than 100.
        //Use StringBuilder class
        
        static void Main(string[] args)
        {
            Console.WriteLine(EvenNums(100));
        }

        static string EvenNums(int numAmount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 2; i < numAmount; i += 2)
            {
                sb.Append(i);
                sb.Append(',');
            }
            return sb.ToString();
        }
    }
}
