using Microsoft.AspNetCore.Mvc;
using MVCTestProject.Models;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace MVCTestProject.Controllers
{
    public class UserSettingsController : Controller
    {
        protected internal AppDBContext DbContext { get; set; }
        public UserSettingsController(AppDBContext dbContext)
        {
            DbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public JsonResult AddUserSettings([FromBody]UserSettings userSettings)
        {
            string jsonString = JsonSerializer.Serialize(userSettings.userSettings);
            var userModel = new UserSetting(){
                Title = jsonString,
                Name = "ABC1"
            };
            userModel.Title = jsonString;
            DbContext.UserSettings.Add(userModel);
            DbContext.SaveChanges();
            return Json(true);
        }


        [HttpGet]
        public JsonResult GetUserSettings(int id)
        {
            var test =20;
            //test = "20";
            Dictionary<string, string> diction = new Dictionary<string, string>();
            var result = DbContext.UserSettings.FirstOrDefault(x => x.Id == id);

            var result1 = DbContext.UserSettings.AsNoTracking().FirstOrDefault(x => x.Id == id);
            //string abc = ;
            var vals = JsonSerializer.Deserialize<Dictionary<string,string>>(JsonSerializer.Serialize(result.Title));
            return Json(true);
        }


    }
}