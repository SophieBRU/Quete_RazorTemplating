using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quete_RazorTemplating.Models;

namespace Quete_RazorTemplating.Controllers
{
    public class ExpenditureController : Controller
    {
        public IActionResult Index()
        {
            List<Expenditure> expend = new List<Expenditure> { new Expenditure { Name="Fournitures", Date="05/12/2020", Amount=250 },
                                                               new Expenditure { Name="Bois", Date="08/12/2020", Amount=400 },
                                                               new Expenditure { Name="Cadeaux", Date="05/12/2020", Amount=300 }};
            return View(expend);
        }
    }
}
