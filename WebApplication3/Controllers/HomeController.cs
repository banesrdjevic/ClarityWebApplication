using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.DataAccessLayer;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ClarityConferenceDB db = new ClarityConferenceDB();
            Conference conference = db.conferences.First();
            ConferenceViewModel conferenceViewModel = new ConferenceViewModel(conference);
            ViewData["conference"] = conferenceViewModel;
            return View();
        }
    }
}