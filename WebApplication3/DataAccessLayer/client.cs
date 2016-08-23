namespace WebApplication3.DataAccessLayer
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Client
    {
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        [Required]
        [Phone]
        [StringLength(20)]
        public string phone { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(200)]
        public string adr_street { get; set; }

        [Required]
        [StringLength(50)]
        public string adr_city { get; set; }

        [Required]
        [StringLength(10)]
        public string adr_state { get; set; }

        [Required]
        [Range(0,int.MaxValue)]
        public int? adr_zip { get; set; }
        
        [ForeignKey("client_id")]
        public virtual ICollection<Attendee> attendees { get; set; }
    }
}
