using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;

namespace KavehNegar
{
    class RedisDataSource : IDataSource<IEnumerable<RedisData>,RedisData>
    {
        RedisClient _client;
        public Task<IEnumerable<RedisData>> ReadData()
        {
            return Task.FromResult(_client.GetAll<RedisData>());
        }

        public Task<bool> WriteData(IEnumerable<RedisData> data)
        {
            try
            {
                _client.Store(data);
                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return Task.FromResult(false);
            }
        }
    }
}
