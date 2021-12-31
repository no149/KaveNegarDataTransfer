using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KavehNegar
{
    public interface IDataSource<L,T> where L : IEnumerable<T>
    {
        Task<L> ReadData();
        Task<bool> WriteData(L data);
    }
}
