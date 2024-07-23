using System.ComponentModel.DataAnnotations;

namespace cartmngr_api.Models
{
    public class Signin
    {
        [Required]
        public string userName { get; set; } = string.Empty;
        [Required]
        public string passWord { get; set; } = string.Empty;
    }
}
