using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tuliva.com.AK.Utilities;

namespace Tuliva.com.AnimalKingdom.Exceptions
{
    public sealed class CustomExceptions : Exception
    {
        public CustomExceptions()
        {

        }

        public CustomExceptions (string message)
            :base (message)
        {
            Utilities.LogIt("We do not have that option", Utilities.MessageSeverity.ERROR, true);
        }

        public CustomExceptions (string message, Exception inner)
            :base (message, inner)
        {

        }
    }
}
