using System.Linq;
using System.Web.Mvc;
using WebApplication3.DataAccessLayer;
using WebApplication3.ViewModels;
using System.Collections.Generic;

namespace WebApplication3.Controllers
{
    public class RegisterController : Controller
    {
        public RegisterController()
        {
        }

        public ActionResult Register()
        {
            ClarityConferenceDB db = new ClarityConferenceDB();
            List<Client> clients = db.clients.ToList();
            ViewData["clients"] = clients;
            return View();
        }

        public ActionResult Show()
        {
            ClarityConferenceDB db = new ClarityConferenceDB();
            List<Client> clients = db.clients.ToList();
            List<ClientAttendeeViewModel> clientAttendees = new List<ClientAttendeeViewModel>();
            foreach (Client item in clients){
                ClientAttendeeViewModel clientAttendee = new ClientAttendeeViewModel(item);
                clientAttendees.Add(clientAttendee);
            }
            ViewData["clients"] = clientAttendees;
            return View();
        }

        public ActionResult RegisterAttendee(Attendee attendee)
        {
            if (ModelState.IsValid)
            {
                ClarityConferenceDB db = new ClarityConferenceDB();
                db.attendees.Add(attendee);

                db.SaveChanges();
                return RedirectToAction("Show", "Register");

            }
            return RedirectToAction("Register", "Register");

        }

        public ActionResult RegisterClient(Client client)
        {
            if (ModelState.IsValid)
            {
                ClarityConferenceDB db = new ClarityConferenceDB();
                db.clients.Add(client);

                db.SaveChanges();
                return RedirectToAction("Show", "Register");

            }
            return RedirectToAction("Register", "Register");

        }
    }
}