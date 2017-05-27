namespace BashSoft
{
    class BashSoftProgram
    {
        public static void Main()
        {
            // Passed
            IOManager.ChangeCurrentDirectoryAbsolute(@"D:\Asus\moveIt\CV");

            // Passed
            IOManager.TraverseDirectory(20);

            // Passed
            IOManager.CreateDirectoryInCurrentFolder("*2");

            // Passed
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
            IOManager.ChangeCurrentDirectoryRelative("..");
        }
    }
}
