namespace BashSoft
{
    using System;
    using System.IO;

    public static class Tester
    {
        public static void PrintOutput(string[] mismatches, bool hasMismatch, string mismatchesPath)
        {
            if (hasMismatch)
            {
                foreach (var line in mismatches)
                {
                    OutputWriter.WriteMessageOnNewLine(line);
                }

                try
                {
                    File.WriteAllLines(mismatchesPath, mismatches);
                }
                catch (DirectoryNotFoundException)
                {
                    OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
                }

                return;
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine("Files are identical. There are no mismatches.");
            }
        }

        public static void CompareContent(string userOutputPath, string executedOutputPath)
        {
            OutputWriter.WriteMessageOnNewLine("Reading files....");
            try
            {
                string mismatchPath = GetMismatchPath(executedOutputPath);
                string[] actualOutputLines = File.ReadAllLines(userOutputPath);
                string[] expectedOutputLines = File.ReadAllLines(executedOutputPath);

                bool hasMismatch;
                string[] mismatches = GetLineWithPossibleMismatches(actualOutputLines, expectedOutputLines, out hasMismatch);
                PrintOutput(mismatches, hasMismatch, mismatchPath);
                OutputWriter.WriteMessageOnNewLine("Files Read");
            }
            catch (FileNotFoundException)
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
            }
        }

        private static string[] GetLineWithPossibleMismatches(string[] actualOutputLines, string[] expectedOutputLines, out bool hasMismatch)
        {
            hasMismatch = false;
            string output = string.Empty;

            string[] mismatches = new string[actualOutputLines.Length];
            OutputWriter.WriteMessageOnNewLine("Compareing files...");

            int minOutputLInes = actualOutputLines.Length;
            if (actualOutputLines.Length != expectedOutputLines.Length)
            {
                hasMismatch = true;
                minOutputLInes = Math.Min(actualOutputLines.Length, expectedOutputLines.Length);
                OutputWriter.DisplayException(ExceptionMessages.ComparisonOfFilesWithDifferentSizes);
            }

            for (int index = 0; index < minOutputLInes; index++)
            {
                string actualLine = actualOutputLines[index];
                string expectedLine = actualOutputLines[index];

                if (!actualLine.Equals(expectedLine))
                {
                    output = string.Format($"Mismatches at line {index}  -- expected : \"{expectedLine}\" actual \"{actualLine}\"");
                    output += Environment.NewLine;
                    hasMismatch = true;
                }
                else
                {
                    output = actualLine;
                    output += Environment.NewLine;
                }

                mismatches[index] = output;
            }

            return mismatches;
        }

        private static string GetMismatchPath(string executedOutputPath)
        {
            int indexOf = executedOutputPath.LastIndexOf('\\');
            string directoryPath = executedOutputPath.Substring(0, indexOf);
            string finalPath = directoryPath + @"\Mismatches.txt";
            return finalPath;
        }
    }
}
