using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabLinq2
{
    public class Linq2
    {
        #region student list
        private static List<Student> students = new List<Student> {
            new Student("Don", "CS", 2015, true),
            new Student("Dan", "CS", 2012, true),
            new Student("Dee", "CS", 2013, false),
            new Student("Bob", "CJ", 2013, false),
            new Student("Ben", "CJ", 2013, true),
            new Student("Jan", "FA", 2012, true),
            new Student("Jim", "FA", 2014, false),
            new Student("Rob", "EE", 2015, true),
            new Student("Ray", "EE", 2012, true)
         };
        #endregion

        #region Linq2Challenges

        public static void LinqChallenges()
        {
            Console.WriteLine("\nL I N Q   C H A L L E N G E 2:");

            Console.WriteLine("\n\n======= Group students by honor (no group name):");
            GroupStudentsByHonorNoGroupName();

            Console.WriteLine("\n\n======= Group students by honor (with group name):");
            GroupStudentsByHonorWithGroupName();

            Console.WriteLine("\n\n======= Group students by major:");
            GroupStudentsByMajor();

            Console.WriteLine("\n\n======= Group students by first letter of major:");
            GroupStudentsByFirstLetterOfMajor();

            Console.WriteLine("\n\n======= Group student names by year:");
            GroupStudentNamesByYear();

            Console.WriteLine("\n\n======= Group student names by year (ordered by year):");
            GroupStudentNamesByYearOrdered();

            Console.WriteLine("\n\n======= Number of students per year:");
            NumberOfStudentsPerYear();

            Console.WriteLine("\n\n======= List Numbered Students:");
            ListNumberedStudents();

            Console.WriteLine("\n\n. . . press enter . . .");
            Console.Read();
        }
        #endregion

        #region GroupStudentsByHonor()
        private static void GroupStudentsByHonorNoGroupName()
        {
            var studentsByHonor =
                from s in students
                group s by s.Honor; //indentation is important!
            
            foreach (var group in studentsByHonor)
            {
                Console.WriteLine($"Honor: {group.Key}");
                foreach (Student s in group) {
                    Console.WriteLine($"    {s}");
                }
            }
        }

        private static void GroupStudentsByHonorWithGroupName()
        {
            var studentsByHonor =
                from s in students
                group s by s.Honor into g //new group name
                select new {Honor = g.Key, Students = g };

            foreach (var group in studentsByHonor) {
                Console.WriteLine($"Honor: {group.Honor}");
                foreach (Student s in group.Students) {
                    Console.WriteLine($"    {s}");
                }
            }
        }
        #endregion

        #region GroupStudentsByMajor()
        private static void GroupStudentsByMajor()
        {
            var studentsByMajor =
                from s in students
                group s by s.Major;

            foreach (var group in studentsByMajor) {
                Console.WriteLine($"Major: {group.Key}");
                foreach (Student s in group) {
                    Console.WriteLine($"    {s}");
                }
            }
          
         }
        #endregion

        #region GroupStudentsByFirstLetterOfMajor()
        private static void GroupStudentsByFirstLetterOfMajor()
        {
            var studentsByMajorInitial =
                from s in students

                group s by s.Major[0]; //like a substring search

            foreach (var group in studentsByMajorInitial)
            {
                Console.WriteLine($"Major: {group.Key}");
                foreach (Student s in group)
                {
                    Console.WriteLine($"    {s}");
                }
            }
        }
        #endregion

        #region GroupStudentNamesByYear
        private static void GroupStudentNamesByYear()
        {
            var studentsByNameAndYear =
                from s in students
                group s.Name by s.Year;
            
            foreach (var group in studentsByNameAndYear) {
                Console.WriteLine($"{group.Key}");
                foreach (string s in group) {
                    Console.WriteLine($"    {s}");
                }
            }
        }
        #endregion

        #region GroupStudentNamesByYearOrdered
        private static void GroupStudentNamesByYearOrdered()
        {
            var studentsByNameAndYearOrdered =
                from s in students
                group s.Name by s.Year into g
                orderby g.Key
                select new { Year = g.Key, Names = g };
             foreach (var group in studentsByNameAndYearOrdered)
            {
                Console.WriteLine($"Year: {group.Year}");
             
                foreach (String s in group.Names)
                {
                    Console.WriteLine($"    {s}");
                }
            }

        }
        #endregion

        #region NumberOfStudentsPerYear
        private static void NumberOfStudentsPerYear()
        {
            var studentNumPerYear =
                from s in students
                group s by s.Year into g
                orderby g.Key
                select new { Year = g.Key, Count = g.Count()};

            foreach(var group in studentNumPerYear){
                Console.WriteLine($"{group.Year} : {group.Count} " +
                    $"{(group.Count == 1 ? "student" : "students")}");
            }
        }
        #endregion

        #region ListNumberedStudents
        private static void ListNumberedStudents()
        {

        }
        #endregion
    }
}
