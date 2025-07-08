using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4003projectsetup.Data.Entities
{
    [Table("MailingList")]
    public class MailingList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ReferralSource { get; set; }
        public DateTime SignupDate { get; set; } = DateTime.Now;
    }
}
