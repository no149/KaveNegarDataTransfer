using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KavehNegar
{
    interface IDataTransfer
    {
        DataTransferStatus Status { get; }

        bool Start(IDataSource source, IDataSource destination);
        bool Stop();

    }
}
