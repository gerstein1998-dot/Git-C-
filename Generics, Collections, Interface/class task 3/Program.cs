namespace class_task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[][] students = new Student[3][];
            students[0] = new Student[1];
            students[1] = new Student[5];
            students[2] = new Student[3];

            students[0][0] = new Student("moshe", 100); //הכנסה של כל הסטודנטים למערך כיתות לפי הכיתות

            students[1][0] = new Student("moshe", 10);
            students[1][1] = new Student("oran", 100);
            students[1][2] = new Student("lior", 90);
            students[1][3] = new Student("yuval", 70);
            students[1][4] = new Student("yossi", 50);

            students[2][0] = new Student("moshe", 10);
            students[2][1] = new Student("moshe", 100);
            students[2][2] = new Student("moshe", 900);

            Console.WriteLine("studen list by class-");
            Console.WriteLine();
            int maxLen = 0; // הגדרת שדה אורך מקסימלי- כלומר הכיתה הכי גדולה שנכנסה למערך הסטודנטים 
            int maxIndex = -1; // הגדרת שדה אינדקס מקסימלי - בעצם באיזה מספר כיתה במערך הכיתה הזו נמצאת
            
            for (int i = 0; i < students.Length; i++)   // נכנס למערך כלל הסטודנטים ומתחיל לעבור כיתה כיתה
            {
                Console.WriteLine($"class number {i+1}:");
                for (int j = 0; j < students[i].Length; j++) // בכל כיתה נכנס ועובר על סטודנט
                {
                    Console.WriteLine($"{j+1}. name: {students[i][j].Name}, grade: {students[i][j].Grade}"); // הדפסה של כל סטודנט בכיתה
                }
                Console.WriteLine("------------------------------");
                    if (students[i].Length > maxLen)     // בודק האם הכיתה הזו היא יותר ארוכה מ0 בהתחלה, ושומר את האורך שלה, אחרכך בודק את זה בין כיתה לכיתה
                {
                    maxLen = students[i].Length; // ישמור את מספר הסטודנטים בכיתה כאורך מקסימלי
                    maxIndex = i; // וישמור באיזה כיתה במערך מדובר 
                }
            }

            // הרי שמרנו את אינדקס הכיתה הכי אורכה בשדה מקס.אינדקס   אז עכשיו אפשר לקרוא למערך במיקוד מקס.אינדקס ולהשתמש בו למיון
            Array.Sort(students[maxIndex],new StudentNameComparer()); // ממיין את הכיתה הגדולה ביותר לפי השמות
            
            Console.WriteLine("sorted by name: ");

            foreach (Student student in students[maxIndex]) 
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}"); // מדפיס לכל סטודנט בכיתה הגדולה ביותר את השם והציון ממויין לפי א-ב
            }

            Console.WriteLine("----");

            // עכשיו אני אשתמש שוב במיון אבל של ציון ושוב אפנה למערך סטודנטים באינדקס של הכיתה הגדולה ביותר
            Array.Sort(students[maxIndex]); 

            Console.WriteLine("sorted by grade: ");

            foreach (Student student in students[maxIndex])
            {
                Console.WriteLine($"Grade: {student.Grade,-3} | Name: {student.Name}"); //מדפיס כל סטודנט בכיתה הגדולה ביותר לפי הסדר של הציונים
            }


        }
}
}

