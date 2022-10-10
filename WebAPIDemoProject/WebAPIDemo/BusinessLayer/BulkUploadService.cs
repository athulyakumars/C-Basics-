using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;

namespace WebAPIDemo.BusinessLayer
{
    public class BulkUploadService : IBulkUploadService
    {
        BulkUploadService()
        {

        }

        public DataTable CreateDataTable()
        {
            DataTable dt = new DataTable { TableName = "Countries" };
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("CountryCOde", typeof(string));
            return dt;
        }

        public bool BulkUpload(string con, DataTable dataTable)
        {
            using (var conn = new NpgsqlConnection(con))
            {
                conn.Open();
                NpgsqlTransaction trans = null;
                try{
                    trans = conn.BeginTransaction();
                    using (var sqlbulkCOpy = new NpgsqlBulkCOpy)
                }
            }
            return true;
        }
    }
}