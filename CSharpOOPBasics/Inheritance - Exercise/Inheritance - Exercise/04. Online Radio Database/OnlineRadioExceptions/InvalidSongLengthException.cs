namespace _04.Online_Radio_Database.CustomExceptions
{
    class InvalidSongLengthException : InvalidSongException
    {
        public override string Message => "Invalid song length.";
    }
}
