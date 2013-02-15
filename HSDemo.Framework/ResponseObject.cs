using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HSDemo.Framework
{
    public class ResponseObject
    {
        public int CountPrintedValues { get; set; }

        //Property to quickly identify if the call to a method was successful or not.
        public bool IsSuccess { get; set; }

        //Property to have access to the Exception object.
        public Exception Exception { get; set; }

        //Removed this properties because they should not be part of the class definition
        //They are too specific for one emthod. Class should be abstract enough to be reusable.
        //public bool IsFizzPrintedFor3 { get; set; }

        //public bool IsFizzPrintedFor5 { get; set; }

        //public bool IsFizzPrintedFor3And5 { get; set; }
    }
}
