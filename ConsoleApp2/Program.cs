using Microsoft.VisualBasic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const int smallPrice = 25;
            const int largePrice = 35;
            const double taxRate = 0.06;
            
            Console.WriteLine("number of small carpets");   
            int smallCount = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("number of large carpets");
            int largeCount = Convert.ToInt32 (Console.ReadLine());
            double cost = smallCount * smallPrice + largeCount * largePrice;
            double tax = cost * taxRate;
            double total = cost + tax;
            Console.WriteLine("Estimate for carpet cleaning servise ");
            Console.WriteLine($"number of small carpets {smallCount}");
            Console.WriteLine($"nomber of large carpets {largeCount}");
            Console.WriteLine($"Price per small carpet {smallPrice} " );
            Console.WriteLine($"price per large carpet {largePrice} ");
            Console.WriteLine($"{cost}");
            Console.WriteLine($"{tax}");
            Console.WriteLine($"{total}");
            Console.WriteLine("this estimate is vild for 30 days ");


           
        }
    }
}
