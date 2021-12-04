using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebClient.Models;

namespace WebClient.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private ManagerRepository _manager;
        public HomeController()
        {
            _manager = new ManagerRepository();
        }
        public IActionResult Index()
        {
            string token = User.FindFirst("AccessToken").Value;
            return View(_manager.GetManager(token));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Manager manager)
        {
            string token = User.FindFirst("AccessToken").Value;
            _manager.AddManager(manager, token);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id )
        {
            string token = User.FindFirst("AccessToken").Value;
            var manager = _manager.GetManagerId(id, token);
            return View(manager);
        }
        [HttpPost]
        public IActionResult Edit(Manager manager)
        {
            string token = User.FindFirst("AccessToken").Value;
            _manager.UpdateManager(manager, token);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            string token = User.FindFirst("AccessToken").Value;
            _manager.DeleteManager(id, token);
            return RedirectToAction("Index");
        }
       
    }

}
