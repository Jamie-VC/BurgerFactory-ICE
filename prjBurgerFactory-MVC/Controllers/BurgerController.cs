using Microsoft.AspNetCore.Mvc;
using prjBurgerFactory_MVC.Factory;
using prjBurgerFactory_MVC.Models;
using System;
using System.Reflection;

namespace prjBurgerFactory_MVC.Controllers
{
    public class BurgerController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Create(SelectedBurger temp)
        {
            SelectedBurger selected = temp;
            BurgerFactory factory = new BurgerFactory();

            if(selected.BurgerType ==null)
            {
                ViewBag.Error = "Please select a burger type";
                return View();
            }
            else
            {
                IBurger burger = factory.getBurger(selected.BurgerType);
                ViewBag.Burger = burger.getBun() + " bun and a " + burger.getPatty() + " patty with " + burger.getCondiments();
                return View();
            }
        }
    }
}
