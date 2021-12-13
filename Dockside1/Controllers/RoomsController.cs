using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authorization;

namespace Dockside1.Controllers
{
    public class RoomsController : Controller
    {
        // 
        // GET: /HelloWorld/
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;

    }
}