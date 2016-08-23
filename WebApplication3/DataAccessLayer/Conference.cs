namespace WebApplication3.DataAccessLayer
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Conference")]
    public partial class Conference
    {
        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string name { get; set; }

        [Required]
        [StringLength(2000)]
        public string description { get; set; }

        [Required]
        [StringLength(200)]
        public string adr_street { get; set; }

        [Required]
        [StringLength(50)]
        public string adr_city { get; set; }

        [Required]
        [StringLength(10)]
        public string adr_state { get; set; }

        public int adr_zip { get; set; }
    }
}
