using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financemanager.Exceptions
{
    public class InvalidDayException : Exception
    {
        public InvalidDayException() { }
        public InvalidDayException(string message = "Invalid day input") : base(message) { }
        public InvalidDayException(Exception inner, string message = "Invalid day input") : base(message, inner) { }
    }

    public class InvalidMonthException : Exception {

        public InvalidMonthException() { }
        public InvalidMonthException(string message = "Invalid month input") : base(message) { }
        public InvalidMonthException(Exception inner, string message = "Invalid month input") : base(message, inner) { }
    }

    public class InvalidYearException : Exception{

        public InvalidYearException() { }
        public InvalidYearException(string message = "Invalid year input") : base(message) { }
        public InvalidYearException(Exception inner, string message = "Invalid month input") : base(message, inner) { }
    }
}
