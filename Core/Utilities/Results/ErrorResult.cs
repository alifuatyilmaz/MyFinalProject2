using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        public ErrorResult(string message) : base(false, message) // base Result classını temsil ediyor. Result classına gönderiyor. False değerini gönderiyor.
        {

        }

        public ErrorResult() : base(false) // Message vermek istemiyorda olabilir. Result'taki tek parametreli constructor'a parametre gönderiyor. False değerini gönderiyor.
        {

        }
    }
}
