using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KavehNegar
{
    class DataTransferException : Exception
    {
        public DataTransferException(string error, Exception innerException) : base(error, innerException)
        {

        }
    }
}
