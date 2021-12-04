using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebClient.Repository;

namespace WebClient.Controllers
{
    public class OfficialController : Controller
    {
        private OfficialRepository _official;
        public OfficialController()
        {
            _official = new OfficialRepository();
        }
        public IActionResult Index()
        {
            string token = User.FindFirst("AccessToken").Value;
            return View(_official.GetOfficial(token));
        }
    }
}
