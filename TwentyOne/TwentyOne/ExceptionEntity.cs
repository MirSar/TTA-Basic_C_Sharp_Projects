using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class ExceptionEntity
    {
        // This class Entity maps exactly to our dB table
        public int Id { get; set; }
        public string ExceptionType { get; set; }
        public string ExceptionMessage { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
