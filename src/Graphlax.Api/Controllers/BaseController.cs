using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Graphlax.Api.Models;

namespace Graphlax.Api.Controllers
{
    public abstract class BaseController 
        : Controller
    {

        public IActionResult OnError()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
