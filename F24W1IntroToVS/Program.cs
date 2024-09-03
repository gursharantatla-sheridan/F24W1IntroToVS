namespace F24W1IntroToVS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            // area of a circle example

            Console.Write("Enter radius of circle: ");
            
            // get input
            //double r = double.Parse(Console.ReadLine());
            double r = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * r * r;

            Console.WriteLine("\nArea = " + area);
        }
    }
}
