using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class PersonalDetail
    {
        [Key]
        public int ID { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? email { get; set; }
        public int telephone { get; set; }
        public int identityNumber { get; set; }

    }
}
