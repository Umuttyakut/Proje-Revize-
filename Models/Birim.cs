using System.ComponentModel.DataAnnotations;

namespace Proje_Revize_.Models
{
    public class Birim
    {
        [Key]
        public int BirimID { get; set; }
        public string BirimAd { get; set;}
        public IList<Personel> Personels { get;}
    }
}
