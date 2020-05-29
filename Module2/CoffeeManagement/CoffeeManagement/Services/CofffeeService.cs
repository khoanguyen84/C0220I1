using CoffeeManagement.Models;
using System;
using System.Collections.Generic;

namespace CoffeeManagement.Services
{
    class CofffeeService
    {
        public Data data;
        private string path;
        private string databasename;
        private string fullpath => @$"{path}\{databasename}";
        public CofffeeService(string _path, string _databasename)
        {
            data = new Data()
            {
                tables = new List<Table>()
            };
            path = _path;
            databasename = _databasename;
            ReadWriteService<Data>.ReadData(fullpath, data);
        }
        
        public string ShowAll()
        {
            string str = "";
            foreach (var table in data.tables)
            {
                str = $"{str}\n{table.ToString()}";
            }
            return str;
        }

        public bool NewOrder(Table table)
        {
            try
            {
                data.tables.Add(table);
                ReadWriteService<Data>.WriteData(fullpath, data);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool UpdateOrder(string tableId, List<OrderDetail> orderDetails)
        {
            try
            {
                var table = Check(tableId);
                if(table != null)
                {
                    foreach(var od in orderDetails)
                    {
                        table.orderdetails.Add(od);
                    }
                    ReadWriteService<Data>.WriteData(fullpath, data);
                    return true;
                }
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public string ShowTable(string tableId)
        {
            var table = Check(tableId);
            if (table != null)
                return table.ToString();
            return string.Empty;
        }

        public bool Pay(string tableId)
        {
            try
            {
                var table = Check(tableId);
                if(table != null)
                {
                    table.endtime = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
                    table.ispaid = true;
                    ReadWriteService<Data>.WriteData(fullpath, data);
                    PrintBill(table);
                    return true;
                }
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool PrintBill(Table table)
        {
            try
            {
                string billName = $"bill_{table.tableid}_{DateTime.Now.ToString("ddMMyyyyhhmmtt")}.json";
                string fullBill = @$"{path}\{billName}";
                ReadWriteService<Table>.WriteData(fullBill, table);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public Table Check(string tableId)
        {
            foreach(var table in data.tables)
            {
                if (table.tableid.Equals(tableId) && !table.ispaid)
                {
                    return table;
                }
            }
            return null;
        }
    }
}
