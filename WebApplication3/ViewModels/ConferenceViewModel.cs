using WebApplication3.DataAccessLayer;

namespace WebApplication3.ViewModels
{
    public class ConferenceViewModel
    {

        public ConferenceViewModel(Conference conference)
        {
            this.ConferenceCity = conference.adr_city;
            this.ConferenceDescription = conference.description;
            this.ConferenceName = conference.name;
            this.ConferenceState = conference.adr_state;
            this.ConferenceStreetAddress = conference.adr_street;
            this.ConferenceZip = conference.adr_zip.ToString();
        }
        public string ConferenceName { get; set; }
        public string ConferenceDescription { get; set; }
        public string ConferenceStreetAddress { get; set; }
        public string ConferenceCity { get; set; }
        public string ConferenceState { get; set; }
        public string ConferenceZip { get; set; }
        public string ConferencePhone { get; set; }
        public string ConferenceEmail { get; set; }
    }
}