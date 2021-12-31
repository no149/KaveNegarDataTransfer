using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KavehNegar
{
    class DataSourceFactory
    {
        ExcelDataSource CreateExcelDatasource(string excelFilePath)
        {
            return new ExcelDataSource(excelFilePath);
        }
        RedisDataSource CreateInMemortDatasource(string datasourceName)
        {
            throw new NotImplementedException();
        }
        IDataSource CreateSqlDatasource(string datasourcePath)
        {
            throw new NotImplementedException();
        }
    }
}
