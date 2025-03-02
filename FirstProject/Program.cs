namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many small Carpet required?");
            int SmallCarpet = Convert.ToInt32(Console.ReadLine());
            int Small = 25;
            int large = 35;
            double Tax = 6.6;

            Console.WriteLine("How Many large Carpet required?");
           int LargeCarpet= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("******************************");
            Console.WriteLine($"Small carpet Price: {Small}");
            Console.WriteLine($"Large carpet Price: {large}");
            Console.WriteLine("***************************");
            Console.WriteLine($"Small Carpet Calculated Price: {Small*SmallCarpet}");
            double Total1 = SmallCarpet * Small;
            Console.WriteLine($"Large Carpet Calculated Price: {large*LargeCarpet}");
            double Total2 = LargeCarpet * large;
            Console.WriteLine("***************************");
            Console.WriteLine($"Cost Without Tax is: {Total1+Total2}");
            Console.WriteLine($"Your Tax:{Tax}");
            Console.WriteLine("*************************************");
            Console.WriteLine($"Your Total After Adding Tax: {Total1 + Total2 + Tax}");

            
                }
    }
}
