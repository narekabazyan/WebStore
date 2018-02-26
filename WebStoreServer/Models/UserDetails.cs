using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStoreServer.Models
{
    public class UserDetails 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,StringLength(60)]
        public string Username { get; set; }
        [Required,StringLength(60)]
        public string FirstName { get; set; }
        [Required,StringLength(60)]
        public string LastName { get; set; }
        // Foreign Key
        public int UserId { get; set; }
        // Navigation property
        public User User { get; set; }
    }
}