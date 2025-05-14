using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SeriesAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> series = new List<int>();
            bool loop = true;
            while (loop)
            {
                bool test = false;
                while (!test)
                {
                    series = GetSeries(series); // קריאה לפונקציה שמקבלת סדרת מספרים
                    test = CheckerSeries(series); // קריאה לפונקציה שבודקת אם הסדרה חוקית
                }
                loop = Menu(series); // אם הסדר חוקית, קריאה לפונקציה שמציגה תפריט
            }
        }

        static List<int> GetSeries(List<int> series)
        {
            Console.Write("Enter a series of numbers: ");
            string[] strSeries = Console.ReadLine().Split(' '); // קבלה מהמשתמש סדרת מספרים
            try
            {
                foreach (string num in strSeries) // המרת הסדרה למערך של מספרים
                {
                    series.Add(int.Parse(num));
                }
            }
            catch
            {
                Console.WriteLine("Only numbers must be entered.");
                series.Clear();
                GetSeries(series);
            }
            return series; // החזרת הסדרה
        }

        static bool CheckerSeries(List<int> series)
        {
            if (series.Count < 3) // בדיקה אם הסדרה מכילה לפחות 3 מספרים
            {
                Console.WriteLine("The series must contain at least 3 numbers.");
                return false; // החזרת true אם הסדרה חוקית, אחרת false
            }
            return true;
        }

        static bool Menu(List<int> series)
        {
            while (true)
            {
                Console.WriteLine("menu"); // הצגת תפריט למשתמש
                Console.WriteLine("a. Input a Series");
                Console.WriteLine("b. Display the series in the order it was entered");
                Console.WriteLine("c. Display the series in the reversed order it was entered");
                Console.WriteLine("d. Display the series in sorted order");
                Console.WriteLine("e. Display the Max value of the series");
                Console.WriteLine("f. Display the Min value of the series");
                Console.WriteLine("g. Display the Average of the series");
                Console.WriteLine("h. Display the Number of elements in the series");
                Console.WriteLine("i. Display the Sum of the series");
                Console.WriteLine("j. Exit");
                Console.Write("Enter a value from A to J: ");

                string userInput = Console.ReadLine(); // קבלת input מהמשתמש

                switch (userInput)
                {
                    case "a":
                        return true; // חזרה לקבלת סדרה חדשה
                    case "b":
                        PrintSeries(series);
                        break; // קריאה לפונקציה שמדפיסה את הסדרה
                    case "c":
                        List<int> reverse = ReverseSeries(series); // קריאה לפונקציה שהופכת את הסדרה
                        PrintSeries(reverse); // קריאה לפונקציה שמדפיסה את הסדרה ההפוכה
                        break;
                    case "d":
                        List<int> sorted = SortSeries(series); // קריאה לפונקציה שממיינת את הסדרה
                        PrintSeries(sorted); // קריאה לפונקציה שמדפיסה את הסדרה הממוינת
                        break;
                    case "e":
                        Console.WriteLine(MaxSeries(series)); // קריאה לפונקציה שמחזירה את הערך המקסימלי ולהדפיס אותה
                        break;
                    case "f":
                        Console.WriteLine(MinSeries(series)); // קריאה לפונקציה שמחזירה את הערך המינימלי ולהדפיס אותה
                        break;
                    case "g":
                        Console.WriteLine(AverageSeries(series)); // קריאה לפונקציה שמחזירה את ממוצע הסדרה ולהדפיס אותה
                        break;
                    case "h":
                        Console.WriteLine(LenghtSeries(series)); // קריאה לפונקציה שמחזירה את מספר האיברים בסדרה ולהדפיס אותה
                        break;
                    case "i":
                        Console.WriteLine(SumSeries(series)); // קריאה לפונקציה שמחזירה את סכום הסדרה ולהדפיס אותה
                        break;
                    case "j":
                        return false;// יציאה מהתוכנית
                    default:
                        Console.WriteLine("Invalid input, please try again"); // הודעה על קלט לא חוקי
                        break;
                }
            }
        }

        static void PrintSeries(List<int> mySeries)
            {
                foreach (int num in mySeries)
                {
                    Console.Write(num); // הדפסת הסדרה
                }
                
            }

        static List<int> ReverseSeries(List<int> series)
        {
            List<int> reverse = new List<int>();
            for (int i = series.Count - 1; i >= 0; i--) // הפיכת הסדרה
            {
                reverse.Add(series[i]);
            }
            return reverse; // החזרת הסדרה ההפוכה
        }

        static List<int> SortSeries(List<int> series)
        {
            List<int> sorted = new List<int>(series);
            sorted.Sort(); // מיון הסדרה
            return sorted; // החזרת הסדרה הממוינת
        }

        static int MaxSeries(List<int> series)
        {
            int max = series[0];
            foreach (int num in series)
            {
                if (num > max) // חיפוש הערך המקסימלי בסדרה
                {
                    max = num;
                }
            }
            return max; // החזרת הערך המקסימלי בסדרה
        }

        static int MinSeries(List<int> series)
        {
            int min = series[0];
            foreach (int num in series)
            {
                if (num < min) // חיפוש הערך המינימלי בסדרה
                {
                    min = num;
                }
            }
            return min; // החזרת הערך המינימלי בסדרה
        }

        static int AverageSeries(List<int> series)
        {
            int sum = SumSeries(series);
            int average = sum / series.Count; // חישוב ממוצע הסדרה
            return average; // החזרת ממוצע הסדרה
        }

        static int LenghtSeries(List<int> series)
        {
            return series.Count; // חישוב מספר האיברים בסדרה והחזרתו
        }

        static int SumSeries(List<int> series)
        {

            int sum = 0;
            foreach (int num in series)
            {
                sum += num; // חישוב סכום הסדרה
            }
            return sum; // החזרת סכום הסדרה
        }
    }
}
