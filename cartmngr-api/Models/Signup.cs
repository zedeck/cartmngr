using System.ComponentModel.DataAnnotations;

namespace cartmngr_api.Models
{
    public class Signup
    {
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Is not a valid email address")]
        public string email { get; set; } = string.Empty;
        [Required]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Is not a valid mobile number")]
        public string mobileNumber { get; set; } = string.Empty;
        [Required]
        public string userName { get; set; } = string.Empty;
        [Required]
        [RegularExpression("^(?=.*[A-Z].*[A-Z])(?=.*[!@#$&*])(?=.*[0-9].*[0-9])(?=.*[a-z].*[a-z].*[a-z]).{8}$", ErrorMessage = "Password strength does not meet requirements")]
        public string passWord { get; set; } = string.Empty;
       

    }
}
