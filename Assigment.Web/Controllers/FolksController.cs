using Assigment.Interface;
using Assignment.Models;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assigment.Web.Controllers
{
    public class FolksController : Controller
    {
        // GET: Folks
        public static IFolksService _iFolksService;
        public FolksController()
        {
            // _iFolksService = folksService;
            _iFolksService = ObjectFactory.GetInstance<IFolksService>();
        }
        public ActionResult Index()
        {
            List<FolksViewModel> resultObj = _iFolksService.GetAllFolksDetails();
            var _folksDetails = new FolksViewModel();
            _folksDetails.FolksDetails = resultObj;
            return View(_folksDetails);
        }
        public JsonResult GetAllFolksDetails()
        {
            List<FolksViewModel> resultObj = _iFolksService.GetAllFolksDetails();
            return Json(new { data = resultObj }, JsonRequestBehavior.AllowGet);
        }
    }
}