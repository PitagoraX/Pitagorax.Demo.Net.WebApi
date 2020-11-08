
using System.ComponentModel.DataAnnotations;

namespace Pitagorax.Demo.WebApi.Model
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
