using System;
using System.Collections.Generic;
using System.Text;

namespace Eve
{
    public class LineResponse
    {
        public string Message { get; set; }

        public LineResponse(string message) {
            Message = message;
        }
    }
}
