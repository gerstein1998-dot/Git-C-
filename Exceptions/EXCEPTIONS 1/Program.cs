namespace EXCEPTIONS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numKM, numLiter;
            double res = 0;
            // קליטה של מספר עשרוני וזריקת חריגה מתאימה 
            try
            {
                Console.WriteLine("please enter num of km:");
                numKM = double.Parse(Console.ReadLine());
                
                if (numKM > 999 || numKM <= 0)
                {
                    throw new IndexOutOfRangeException();
                }
               
                Console.WriteLine("please enter num of liter:");
                numLiter = double.Parse(Console.ReadLine());
              
                    res = numKM / numLiter;
                Console.WriteLine($"mileage is {res} miles per gallon. ");

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("no car can drive that many miles.");  
            }
            catch (FormatException fe)
            {
                Console.WriteLine("input string was not in a correct format." + fe);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            

         
        }
    }
}
