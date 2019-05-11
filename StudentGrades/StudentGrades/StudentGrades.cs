using System;
using System.Collections.Generic;

namespace StudentGrades
{
    class MainClass
    {
        static Dictionary<String, int[]> students = new Dictionary<String, int[]>();
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to student grades!");
            String name;
            String[] gradesRaw;
            int[] grades;
            while (1==1)
            {
                Console.WriteLine("Enter the student's Name (or \'done\'):");
                name = Console.ReadLine();
                if(name == "done")
                {
                    break;
                }
                Console.WriteLine("Enter the student's grades:");
                gradesRaw = Console.ReadLine().Split(' ');
                grades = convertToInts(gradesRaw);
                students.Add(name, grades);


            }
            foreach(String key in students.Keys)
            {
                Console.WriteLine("______");
                Console.WriteLine(key + ": ");
                Console.WriteLine("");
                Console.WriteLine("Lowest Grade: " + getLowestGrade(key));
                Console.WriteLine("Highest Grade: " + getHighestGrade(key));
                Console.WriteLine("Average Grade: " + getAverageGrade(key));
                Console.WriteLine("");
            }

        }

        public static int[] convertToInts(String[] grades)
        {
            int[] ret = new int[grades.Length];
            for(int i = 0; i < ret.Length; i++)
            {
                try
                {
                    ret[i] = Convert.ToInt32(grades[i]);
                }
                catch
                {
                    ret[i] = 0;
                }
            }


            return ret;
        }
        public static int getLowestGrade(String name)
        {
            int lowest = 100;
            int[] grades = students[name];
            
            for(int i = 0; i < grades.Length; i++)
            {
                if(lowest > grades[i])
                {
                    lowest = grades[i];
                }
            }

            return lowest;
        }
        public static int getHighestGrade(String name)
        {
            int highest = 0;
            int[] grades = students[name];
            for(int i = 0; i < grades.Length; i++)
            {
                if(grades[i] > highest)
                {
                    highest = grades[i];
                }
            }
            return highest;
        }
        public static int getAverageGrade(String name)
        {
            int average = 0;
            int[] grades = students[name];
            for (int i = 0; i < grades.Length; i++)
            {
                average += grades[i];
            }
            average = average / grades.Length;
            return average;
        }
    }
}
