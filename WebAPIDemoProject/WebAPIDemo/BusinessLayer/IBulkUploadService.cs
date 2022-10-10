using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemo.BusinessLayer
{
    public interface IBulkUploadService
    {
        DataTable CreateDataTable();

        bool BulkUpload(string con, DataTable dataTable);
    }
}