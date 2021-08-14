using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompanySite2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompanySite2.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public ActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }

    }
}
