using System.Collections.Generic;
using DemoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebAPI.Controllers
{
    public class StudentController : ControllerBase
    {
        List<Student> students = new List<Student>();
    }
}