﻿using System.ComponentModel.DataAnnotations;

namespace Proje_Revize_.Models
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }

        public int BirimId { get; set; }
        public Birim Birim { get; set; }
    }
}
