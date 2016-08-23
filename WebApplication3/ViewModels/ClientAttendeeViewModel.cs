using System.Collections.Generic;
using System.Linq;
using WebApplication3.DataAccessLayer;


namespace WebApplication3.ViewModels
{
    public class ClientAttendeeViewModel
    {
        public ClientAttendeeViewModel(Client client)
        {
            this.Attendees = (List<Attendee>)client.attendees.ToList();
            this.ClientCity = client.adr_city;
            this.ClientEmail = client.email;
            this.ClientName = client.name;
            this.ClientPhone = client.phone;
            this.ClientState = client.adr_state;
            this.ClientStreetAddress = client.adr_street;
            this.ClientZip = client.adr_zip.ToString();
        }
        public string ClientName { get; set; }
        public string ClientStreetAddress { get; set; }
        public string ClientCity { get; set; }
        public string ClientState { get; set; }
        public string ClientZip { get; set; }
        public string ClientPhone { get; set; }
        public string ClientEmail { get; set;}
        public List<Attendee> Attendees { get; set; }

    }
}