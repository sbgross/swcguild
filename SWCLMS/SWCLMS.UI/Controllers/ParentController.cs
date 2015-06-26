using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWCLMS.UI.Controllers
{
    [Authorize(Roles = "Parent")]
    public class ParentController : Controller
    {
        // GET: Parent
        public ActionResult Index()
        {
            return View();
        }
    }
}