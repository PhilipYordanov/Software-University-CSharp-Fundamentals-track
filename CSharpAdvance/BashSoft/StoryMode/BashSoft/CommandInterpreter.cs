namespace BashSoft
{
    using System;
    using System.Diagnostics;

    public static class CommandInterpreter
    {
        public static void InterpredCommand(string input)
        {
            var data = input.Split();
            var command = data[0];

            switch (command)
            {
                case "open":
                    TryOpenFile(input, data);
                    break;
                case "mkdir":
                    TryCreateDirectory(input, data);
                    break;
                case "ls":
                    TryTraverseFolders(input, data);
                    break;
                case "cmp":
                    TryCompareFiles(input, data);
                    break;
                case "cdRel":
                    TryCahngePathRelatively(input, data);
                    break;
                case "cdAbs":
                    TryChangePathAbsolute(input, data);
                    break;
                case "readDb":
                    TryReadDatabaseFromFile(input, data);
                    break;
                case "help":
                    TryGetHelp();
                    break;
                case "filter":
                    TryFilterAndTake(input, data);
                    break;
                case "order":
                    TryOrderAndTake(input, data);
                    break;
                case "decOrder":
                    // TryOpenFile(input, data);
                    break;
                case "download":
                    // TryOpenFile(input, data);
                    break;
                case "downloadAsynch":
                    // TryOpenFile(input, data);
                    break;
                case "show":
                    TryShowWantedData(input, data);
                    break;
                default:
                    DisplayInvalidCommandMessage(input);
                    break;
            }
        }

        private static void DisplayInvalidCommandMessage(string input)
        {
            OutputWriter.DisplayException($"The command '{input}' is invalid");
        }

        private static void TryShowWantedData(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string courseName = data[1];
                StudentsRepository.GetAllStudentsFromCourse(courseName);
            }
            else if (data.Length == 3)
            {
                string courseName = data[1];
                string userName = data[2];
                StudentsRepository.GetStudentScoresFromCourse(courseName, userName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private static void TryOrderAndTake(string input, string[] data)
        {
            throw new NotImplementedException();
        }

        private static void TryFilterAndTake(string input, string[] data)
        {
            throw new NotImplementedException();
        }

        private static void TryGetHelp()
        {
            throw new NotImplementedException();
        }

        private static void TryReadDatabaseFromFile(string input, string[] data)
        {
            if (data.Length == 2)
            {
                var fileName = data[1];
                StudentsRepository.InitializeData(fileName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private static void TryChangePathAbsolute(string input, string[] data)
        {
            string absolutePath = data[1];
            IOManager.ChangeCurrentDirectoryRelative(absolutePath);
        }

        private static void TryCahngePathRelatively(string input, string[] data)
        {
            string relPath = data[1];
            IOManager.ChangeCurrentDirectoryRelative(relPath);
        }

        private static void TryCompareFiles(string input, string[] data)
        {
            if (data.Length == 3)
            {
                string firstpath = data[1];
                string secondPath = data[2];

                Tester.CompareContent(firstpath, secondPath);
            }
        }

        private static void TryTraverseFolders(string input, string[] data)
        {
            if (data.Length == 1)
            {
                IOManager.TraverseDirectory(0);
            }
            else if (data.Length == 2)
            {
                int depth;
                bool hasPassed = int.TryParse(data[1], out depth);
                if (hasPassed)
                {
                    IOManager.TraverseDirectory(depth);
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.UnableToParseNumber);
                }
            }
        }

        private static void TryCreateDirectory(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string folderName = data[1];
                IOManager.CreateDirectoryInCurrentFolder(folderName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }

        private static void TryOpenFile(string input, string[] data)
        {
            if (data.Length == 2)
            {
                string fileName = data[1];
                Process.Start(SessionData.CurrentPath + "\\" + fileName);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }
        }
    }
}
