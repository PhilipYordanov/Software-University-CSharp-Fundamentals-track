namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class IOManager
    {
        public static void TraverseDirectory(int depth)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdentation = SessionData.CurrentPath.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(SessionData.CurrentPath);

            while (subFolders.Count != 0)
            {
                string currentPath = subFolders.Dequeue();
                int identation = currentPath.Split('\\').Length - initialIdentation;
                if (depth - identation < 0)
                {
                    break;
                }

                OutputWriter.WriteMessageOnNewLine(string.Format("{0}{1}", new string('-', identation), currentPath));

                try
                {
                    foreach (var file in Directory.GetFiles(currentPath))
                    {
                        int indexOfLastSlash = file.LastIndexOf("\\");
                        string fileName = file.Substring(indexOfLastSlash);
                        OutputWriter.WriteMessageOnNewLine(new string('-', indexOfLastSlash) + fileName);
                    }

                    foreach (var directoryPath in Directory.GetDirectories(currentPath))
                    {
                        subFolders.Enqueue(directoryPath);
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    OutputWriter.DisplayException(ExceptionMessages.UnauthorizedAccessExceptionMessage);
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void CreateDirectoryInCurrentFolder(string name)
        {
            string path = Directory.GetCurrentDirectory() + "\\" + name;
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (ArgumentException)
            {
                OutputWriter.DisplayException(ExceptionMessages.ForbiddenSymbolsContainedInName);
            }
        }

        public static void ChangeCurrentDirectoryRelative(string relativePath)
        {
            if (relativePath == "..")
            {
                try
                {
                    string currentPath = SessionData.CurrentPath;
                    int indexOfLastSlash = currentPath.LastIndexOf("\\");
                    string newPath = currentPath.Substring(0, indexOfLastSlash);
                    SessionData.CurrentPath = newPath;
                }
                catch (ArgumentOutOfRangeException)
                {
                    OutputWriter.DisplayException(ExceptionMessages.UnableToGoHigherInPartitionHierarchy);
                }
            }
            else
            {
                string currentPath = SessionData.CurrentPath;
                currentPath += "\\" + relativePath;
                ChangeCurrentDirectoryAbsolute(currentPath);
            }
        }

        public static void ChangeCurrentDirectoryAbsolute(string absolutePath)
        {
            if (!Directory.Exists(absolutePath))
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
                return;
            }

            SessionData.CurrentPath = absolutePath;
        }
    }
}
