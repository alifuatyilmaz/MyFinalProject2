using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message) : base(true, message) // base Result classını temsil ediyor. Result classına gönderiyor. True değerini gönderiyor.
        {

        }

        public SuccessResult():base(true) // Message vermek istemiyorda olabilir. Result'taki tek parametreli constructor'a parametre gönderiyor. True değerini gönderiyor.
        {

        }
    }
}
