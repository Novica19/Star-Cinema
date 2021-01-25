using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StarCinema.Models
{
    public class CreditCard
    {
        [Key]
        public int card_id { get; set; }

        [Required]
        [RegularExpression(@"[5][1-5][0-9]{14}|4[0-9]{15}|[3][4|7][0-9]{13}$", ErrorMessage = "Only Visa,Master and American Express is accepted.")]
        [StringLength(16)]
        [Display(Name = "Card Number")]
        public string card_num { get; set; }

        [Required]
        [StringLength(16)]
        [Display(Name = "Card Type")]
        public string card_type { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Invalid Name.")]
        [Display(Name = "Name on Card")]
        public string card_name { get; set; }

        [Required]
        [StringLength(12)]
        [RegularExpression(@"(0[1-9]|10|11|12)/(201[6-9]|20[2-3][0-9])$", ErrorMessage = "Year from 2016 to 2030 and month 01 to 12.")]
        [Display(Name = "Card Expiry")]
        public string card_expiry { get; set; }

        [Display(Name = "Card CVV")]
        public decimal card_cvv { get; set; }


    }
}