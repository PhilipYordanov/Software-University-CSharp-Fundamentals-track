namespace BashSoft
{
    using System.Collections.Generic;
    using System.IO;
    using System.Text.RegularExpressions;

    public static class StudentsRepository
    {
        public static bool IsDataInitialized = false;

        // Course name,userName,ScoresOnTask
        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

        public static void GetStudentScoresFromCourse(string courseName, string username)
        {
            if (IsQueryForStudentPossiblе(courseName, username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username, studentsByCourse[courseName][username]));
            }
        }

        public static void GetAllStudentsFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}");
                foreach (var studentMarksEntry in studentsByCourse[courseName])
                {
                    OutputWriter.PrintStudent(studentMarksEntry);
                }
            }
        }

        public static void InitializeData(string fileName)
        {
            if (!IsDataInitialized)
            {
                OutputWriter.WriteMessageOnNewLine("Reading data ...");
                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData(fileName);
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitialisedException);
            }
        }

        private static void ReadData(string fileName)
        {
            var path = SessionData.CurrentPath + "\\" + fileName;
            if (File.Exists(path))
            {
                var pattern = @"([A-Z][a-zA-Z#+]*_[A-Z][a-z]{2}_\d{4})\s+([A-Z][a-z]{0,3}\d{2}_\d{2,4})\s+(\d+)";
                var regex = new Regex(pattern);
                var allInputLines = File.ReadAllLines(path);
                for (var line = 0; line < allInputLines.Length; line++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[line]) && regex.IsMatch(allInputLines[line]))
                    {
                        var tokens = regex.Match(allInputLines[line]);
                        var course = tokens.Groups[1].Value;
                        var student = tokens.Groups[2].Value;
                        int grade;
                        var hasParsed = int.TryParse(tokens.Groups[3].Value, out grade);
                        if (hasParsed && grade >= 0 && grade <= 100)
                        {
                            if (!studentsByCourse.ContainsKey(course))
                            {
                                studentsByCourse[course] = new Dictionary<string, List<int>>();
                            }

                            if (!studentsByCourse[course].ContainsKey(student))
                            {
                                studentsByCourse[course].Add(student, new List<int>());
                            }

                            studentsByCourse[course][student].Add(grade);
                        }
                    }
                }

                IsDataInitialized = true;
                OutputWriter.WriteMessageOnNewLine("Data read!");
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InvalidPath);
            }

            IsDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("StudentsRepository read!");
        }

        private static bool IsQueryForCoursePossible(string courseName)
        {
            if (IsDataInitialized)
            {
                if (studentsByCourse.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            return false;
        }

        private static bool IsQueryForStudentPossiblе(string courseName, string studentUserName)
        {
            if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
            }

            return false;
        }
    }
}
