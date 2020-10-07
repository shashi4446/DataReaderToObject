using System;
using System.Data;

namespace AutoMapperDemo
{
    public class MyDataBuilder
    {
        public IDataReader GetDataReader()
        {
            var tempTable = new DataTable();
            tempTable.Columns.Add("TenantId", typeof(Guid));
            tempTable.Columns.Add("ConsumptionUnits", typeof(decimal));
            tempTable.Columns.Add("Date", typeof(DateTime));

            for (int i = 1; i <= 10; i++)
            {
                var tempDataRow = tempTable.NewRow();
                tempDataRow["TenantId"] = Guid.NewGuid();
                tempDataRow["ConsumptionUnits"] = 1000*i;
                tempDataRow["Date"] = DateTime.Now.AddDays(i);

                tempTable.Rows.Add(tempDataRow);
            }

            return tempTable.CreateDataReader();
        }
        
    }
}
