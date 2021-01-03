using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StarCinema.Models
{
    public class Movie
    {
        [Key]
        public int movie_id { get; set; }


        [Required]
        [StringLength(100)]
        [DisplayName("Name")]
        public string movie_name { get; set; }



        [Required]
        [StringLength(100)]
        [DisplayName("Time")]
        public string runtime { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Release Date")]
        public string release_date { get; set; }


        [Required]
        [StringLength(100)]
        [DisplayName("Rating")]
        public string rating { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Image")]
        public string image_path { get; set; }

    }
}