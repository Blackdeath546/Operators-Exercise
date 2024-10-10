namespace OperatorExercise
{
    public class Program
    {

   
        
       // double radius = double.Parse(Console.ReadLine());
        
        
        static double AreaOfCircle(double radius)
        {
            //double radius = double.Params(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
                    
        }
        
        
        
        static void Main(string[] args)
        {
            
            //Exercise 1
            
            int a = 15;
            int b = 6;
            
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
           // {
               // if (remainder == 0)
              //  {
                    //Console.WriteLine("With no remainder");
               // }
              //  else
                //{
                   // Console.WriteLine("Remainder: " + remainder);
               // }
            // }
            
            Console.WriteLine($"{a} + {b} is {sum}.");
            Console.WriteLine($"{a} - {b} is {difference}.");
            Console.WriteLine($"{a} * {b} is {product}.");
            Console.WriteLine($"{a} / {b} is {quotient} with remainder {remainder}.");

            
            
            //Exercise 2 Calculating the Area of a Circle
            
            Console.WriteLine($"What is the radius of your circle?");
            
            double radius = double.Parse(Console.ReadLine());
            
            double area = AreaOfCircle(radius);
            
            double roundedArea = Math.Round(area, 2); // Round to two decimal places
            
            Console.WriteLine($"The area of your circle with a radius of {radius} is {area} or {roundedArea} when rounded.");
            

        }
    }
}
