namespace _04.Online_Radio_Database.CustomExceptions
{
    using System;

    class InvalidSongException : Exception
    {
        private string exceptionMessage;

        public string ExceptionMessage
        {
            set
            {
                this.exceptionMessage = value;
            }
        }
        public override string Message => exceptionMessage;
    }
}
