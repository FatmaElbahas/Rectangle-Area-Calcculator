namespace ConsoleApp108
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Width of the Rectangle");
          Double width=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Length of The Rectangle");
            Double Length = Convert.ToDouble(Console.ReadLine());
            Double Area = Length * width;
            Console.WriteLine("Area of The Rectangle : " + Area); 

        }
    }
}