using System;
using System.Collections.Generic;
using static BashSoft.ExceptionMessages;
using static BashSoft.OutputWriter;

namespace BashSoft
{
    public static class Data
    {
        public static bool isDataInitialized = false;
        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

        public static void initializeData()
        {
            if (!isDataInitialized)
            {
                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                isDataInitialized = true;
                ReadData();
            }
            else
            {
                WriteMessageOnNewLine(DataAlreadyInitialisedException);
            }
        }

        private static void ReadData()
        {
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                string[] tokens = input.Split(' ');
                string course = tokens[0];
                string student = tokens[1];
                int mark = int.Parse(tokens[2]);

                if (!studentsByCourse.ContainsKey(course))
                {
                    studentsByCourse.Add(course, new Dictionary<string, List<int>>());
                }

                if (!studentsByCourse[course].ContainsKey(student))
                {
                    studentsByCourse[course].Add(student, new List<int>());
                }

                studentsByCourse[course][student].Add(mark);
                input = Console.ReadLine();
            }
            isDataInitialized = true;
            WriteMessageOnNewLine("Data Read!");
        }

        private static bool IsQueryForCoursePossible(string courseName)
        {
            if (isDataInitialized)
            {
                if (studentsByCourse.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    DisplayException(InexistingCourseInDataBase);
                }
            }
            else
            {
                DisplayException(DataNotInitializedExceptionMessage);
            }
            return false;
        }

        private static bool IsQueryForStudentPossible(string courseName, string StudentUserName)
        {
            if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(StudentUserName))
            {
                return true;
            }
            else
            {
                DisplayException(InexistingStudentInDataBase);
            }
            return false;
        }

        public static void GetStudentScoreFromCourse(string coureName, string userName)
        {
            if (IsQueryForStudentPossible(coureName, userName))
            {
                PrintStudent(new KeyValuePair<string, List<int>>(userName, studentsByCourse[coureName][userName]));
            }
        }
        public static void GetAllStudentsFromCourse(string coureName)
        {
            if (IsQueryForCoursePossible(coureName))
            {
                foreach (var studentMarks in studentsByCourse[coureName])
                {
                    PrintStudent(studentMarks);
                }
            }
        }
    }
}
