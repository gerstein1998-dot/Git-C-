namespace class_task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape("broun");
            Circle c1 = new Circle("red");
            Rectangle r1 = new Rectangle("pink");
            
            Shape[] shapes = new Shape[3] { s1, c1, r1 };

            foreach (var shape in shapes)
            {
                Console.WriteLine();
                shape.Drow();
            }

            //בגלל שיש לי פה אוברייד על הפונקצייה של לצייר זה עובר כל פעם על הפונקציה של צורה ואומר האם יש לי פונקציה של צייר גם במשולש או בעיגול ומדפיס לכל אחד את הפונקציה שלו
    }
}
}
