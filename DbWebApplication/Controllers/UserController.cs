using DbWebApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DbWebApplication.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            HardCodedSampleUserDataRepo hardCodedSampleUserDataRepo = new HardCodedSampleUserDataRepo();

            return View(hardCodedSampleUserDataRepo.GetAllUsers());
        }
    }
}
