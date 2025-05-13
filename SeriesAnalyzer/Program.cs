using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> series = new List<int>();
            // קריאה לפונקציה שמקבלת סדרת מספרים
            // קריאה לפונקציה שבודקת אם הסדרה חוקית
            // אם הסדר חוקית, קריאה לפונקציה שמציגה תפריט
        }

        static List<int> GetSeries(List<int> series)
        {
            // קבלה מהמשתמש סדרת מספרים
            // המרת הסדרה למערך של מספרים
            // החזרת הסדרה
        }

        static bool CheckerSeries(List<int> series)
        {
            // בדיקה אם הסדרה חוקית
            // החזרת true אם הסדרה חוקית, אחרת false
        }

        static void Menu(List<int> series)
        {
            // הצגת תפריט למשתמש
            // קבלת input מהמשתמש

            switch (input)
            {
                case "a":
                    // חזרה לקבלת סדרה חדשה
                case "b":
                    // קריאה לפונקציה שמדפיסה את הסדרה
                case "c":
                // קריאה לפונקציה שהופכת את הסדרה
                // קריאה לפונקציה שמדפיסה את הסדרה ההפוכה
                case "d":
                    // קריאה לפונקציה שממיינת את הסדרה
                    // קריאה לפונקציה שמדפיסה את הסדרה הממוינת
                case "e":
                    // קריאה לפונקציה שמחזירה את הערך המקסימלי ולהדפיס אותה
                case "f":
                    // קריאה לפונקציה שמחזירה את הערך המינימלי ולהדפיס אותה
                case "g":
                    // קריאה לפונקציה שמחזירה את ממוצע הסדרה ולהדפיס אותה
                case "h":
                // קריאה לפונקציה שמחזירה את מספר האיברים בסדרה ולהדפיס אותה
                case "i":
                // קריאה לפונקציה שמחזירה את סכום הסדרה ולהדפיס אותה
                case "j":
                    // יציאה מהתוכנית
                default:
                    // הודעה על קלט לא חוקי
            }

            static void PrintSeries(List<int> mySeries)
            {
                // הדפסת הסדרה
            }

            static List<int> ReverseSeries(List<int> series)
            {
                // הפיכת הסדרה
                // החזרת הסדרה ההפוכה
            }

            static List<int> SortSeries(List<int> series)
            {
                // מיון הסדרה
                // החזרת הסדרה הממוינת
            }

            static int MaxValue(List<int> series)
            {
                // חיפוש הערך המקסימלי בסדרה
                // החזרת הערך המקסימלי בסדרה
            }

            static int MinSeries(List<int> series)
            {
                // חיפוש הערך המינימלי בסדרה
                // החזרת הערך המינימלי בסדרה
            }

            static int AverageSeries(List<int> series)
            {
                // חישוב ממוצע הסדרה
                // החזרת ממוצע הסדרה
            }

            static int LenghtSeries(List<int> series)
            {
                // חישוב מספר האיברים בסדרה
                // החזרת מספר האיברים בסדרה
            }

            static int SumSeries(List<int> series)
            {
                // חישוב סכום הסדרה
                // החזרת סכום הסדרה
            }
        }
    }
}
