using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StarCinema.Models
{
    public class Bilet
    {
        [Key]
        public int id_bilet { get; set; }
        public int cena { get; set; }
        public string e_mail { get; set; }
        public DateTime vreme_na_rezervacija { get; set; }
        public int id_proekcija { get; set; }
        public int id_film { get; set; }
        public int broj_sala { get; set; }
        public int broj_sediste { get; set; }
        public int broj_red { get; set; }
    }
}