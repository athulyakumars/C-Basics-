using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAPIDemo.BusinessLayer;

namespace WebAPIDemo.Controllers
{
    [Route("[controller]")]
    public class BulkUploadController : Controller
    {
        private readonly ILogger<BulkUploadController> _logger;

        private readonly IBulkUploadService _bulkUpload;

        public BulkUploadController(ILogger<BulkUploadController> logger, IBulkUploadService bulkUpload)
        {
            _logger = logger;
            _bulkUpload = bulkUpload;

        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public bool BulkUpload()
        {
            var dataTable = _bulkUpload.CreateDataTable();
            

            return true;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}