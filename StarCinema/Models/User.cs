using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StarCinema.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }

        [StringLength(25)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name is required.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid Last Name.")]
        [DisplayName("Last Name")]
        public string last_name { get; set; }

        [StringLength(25)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name is required.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid First Name.")]
        [DisplayName("First Name")]
        public string first_name { get; set; }

        [StringLength(15)]
        [Required]
      
        [DisplayName("Phone No.")]
        public string phone { get; set; }
        [StringLength(100)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is required.")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email Address")]
        [DisplayName("Email")]
        public string email { get; set; }

        [StringLength(100)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is required.")]
        [DisplayName("Password")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Input needs at least 1 Uppercase, Lowecase and Special Character.")]
        [DataType(DataType.Password)]
        public string password { get; set; }

      
        [Required]
        [StringLength(100)]
        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Password and Confirm Password does not match")]
        public string confirm_password { get; set; }


    }
}