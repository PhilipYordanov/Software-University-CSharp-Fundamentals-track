namespace _04.Online_Radio_Database.CustomExceptions
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {
        public override string Message => "Song minutes should be between 0 and 14.";
    }
}
