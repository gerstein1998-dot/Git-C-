namespace targil_7_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DBConnection db = new DBConnection();
            Console.WriteLine(db.ReadKnightsTable());
        }
    }
}
