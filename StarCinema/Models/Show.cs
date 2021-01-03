using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StarCinema.Models
{
    public class Show
    {
        [Key]
        public int show_id { get; set; }


        [Required]
        [StringLength(100)]
        public string show_name { get; set; }



        [Required]
        [StringLength(100)]
        public string runtime { get; set; }



        [Required]
        [StringLength(100)]
        public string rating { get; set; }

        [Required]
        [StringLength(100)]
        public string image_path { get; set; }
    }
}