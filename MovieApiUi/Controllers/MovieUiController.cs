using Microsoft.AspNetCore.Mvc;
using MovieApiUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace MovieApiUI.Controllers
{
    public class MovieUiController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        

    
    }
}
