namespace WebApplication3.DataAccessLayer
{
    using System.ComponentModel.DataAnnotations;

    public partial class Attendee
    {
        public int id { get; set; }

        public int? client_id { get; set; }

        [Required]
        [StringLength(50)]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        public string last_name { get; set; }
        
        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string email { get; set; }
        
        public Client client { get; set; }
    }
}
