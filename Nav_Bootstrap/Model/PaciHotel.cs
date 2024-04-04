using System.ComponentModel.DataAnnotations;

namespace Nav_Bootstrap.Modell
{
    public class PaciHotel

    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="A név mező kitöltése kötelező!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="A helyszín mező kitöltése kötelező!")]
        public string Location { get; set; }
        [Required(ErrorMessage ="Az ár mező kitöltése kötelező!")]
        public int Price { get; set; }
        public double Rating { get; set; }
        public string LovakSzama { get; set; } = "Nincs információ!";
        [Required(ErrorMessage ="A fizetési lehetőség kiválasztása kötelező!")]
        public bool CardorNot { get; set; } = false;

    }
}
