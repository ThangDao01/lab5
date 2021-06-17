using System;

namespace Part3._2
{
    public class AmoutException : Exception
    {
        private string _personName;
        private string _message;

        public AmoutException(string personName, string message)
        {
            _personName = personName;
            _message = message;
            PrintError();
        }

        private void PrintError()
        {
            Console.WriteLine($"Error :{_message} ,Name {_personName}");
        }
    }
}