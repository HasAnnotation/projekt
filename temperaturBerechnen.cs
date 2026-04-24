namespace rechteck
{
    internal class Program
    {

        static void Main (string[]args)
        {
            Console.WriteLine ("gib mir celsius und ich geb dir fahrenheit");
            int Celsius = Convert.ToInt32(Console.ReadLine());

            int Fahrenheit = (Celsius * 9 / 5) + 32;

            Console.WriteLine (Fahrenheit + " fahrenheit");
            
        }

    
        
    }    
}
