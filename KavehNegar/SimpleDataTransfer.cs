using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KavehNegar
{
    class SimpleDataTransfer : IDataTransfer
    {
        public DataTransferStatus Status => throw new NotImplementedException();

        public bool Start(IDataSource source, IDataSource destination)
        {
            throw new NotImplementedException();
        }

        public bool Stop()
        {
            throw new NotImplementedException();
        }
    }
}
