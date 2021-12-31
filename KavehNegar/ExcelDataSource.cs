using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
namespace KavehNegar
{
    public class ExcelDataSource : IDataSource<IEnumerable<ExcelData>,ExcelData>
    {
        private string _filepath;
        private XLWorkbook _workbook;

        public ExcelDataSource(string filepath)
        {
            _filepath = filepath;
        }
        public async Task<IEnumerable<ExcelData>> ReadData()
        {
            try
            {
                using (_workbook = new XLWorkbook(_filepath))
                {
                    var firstSheet = _workbook.Worksheets.First();
                    var rowCount = firstSheet.RowCount();
                    var colCount = firstSheet.ColumnCount();
                    var data = new string[rowCount, colCount];

                    for (int i = 0; i < rowCount; i++)
                    {
                        for (int j = 0; j < colCount; j++)
                        {
                            data[i, j] = firstSheet.Cell(i, j).Value.ToString();
                        }
                    }
                    return await Task.FromResult(data);
                }

            }
            catch (ClosedXML.Excel.Exceptions.ClosedXMLException ex)
            {
                throw new DataTransferException("The spreadsheet file could not be opened. Make sure the file exists and is readable.", ex);
            }
        }

        public async Task<bool> WriteData(IEnumerable<ExcelData> data)
        {
            throw new NotImplementedException();
        }
    }
}
