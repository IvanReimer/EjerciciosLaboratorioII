using System;
using System.Runtime.Serialization;

namespace CentralitaHerencia
{
    internal class FallaLogException : Exception
    {
        public FallaLogException()
        {
        }

        public FallaLogException(string message) : base(message)
        {
        }

        public FallaLogException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}