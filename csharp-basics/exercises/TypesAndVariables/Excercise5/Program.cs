using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstTeacher = "Ms. Lapan",
                   secondTeacher = "Mrs. Gideon",
                   thirdTeacher = "Mr. Davis",
                   fourthTeacher = "Ms. Palmer",
                   fifthTeacher = "Ms. Garcia",
                   sixthTeacher = "Mrs. Barnett",
                   seventhTeacher = "Ms. Johannessen",
                   eigthTeacher = "Mr. James",
                   firstClass = "English III",
                   secondClass = "Precalculus",
                   thirdClass = "Music Theory",
                   fourthClass = "Biotechnology",
                   fifthClass = "Principles of Technology I",
                   sixthClass = "Latin II",
                   seventhClass = "AP US History",
                   eigthClass = "Business Computer Infomation Systems";

            Console.WriteLine("+----------------------------------------+");
            Console.WriteLine($"| 1 | { firstClass} | {firstTeacher} |");
            Console.WriteLine($"| 2 | { secondClass} | {secondTeacher} |");
            Console.WriteLine($"| 3 | { thirdClass} | {thirdTeacher} |");
            Console.WriteLine($"| 4 | { fourthClass} | {fourthTeacher} |");
            Console.WriteLine($"| 5 | { fifthClass} | {fifthTeacher} |");
            Console.WriteLine($"| 6 | { sixthClass} | {sixthTeacher} |");
            Console.WriteLine($"| 7 | { seventhClass} | {seventhTeacher} |");
            Console.WriteLine($"| 8 | { eigthClass} | {eigthTeacher} |");
            Console.WriteLine("+----------------------------------------+");
            Console.ReadKey();
        }
    }
}
