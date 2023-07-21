using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
    public class Email{
        
        [Key]
        public int Id { get; set; }
        public string ? Emails { get; set; }
        public ICollection<Login> ? Logins { get; set; }

    }
