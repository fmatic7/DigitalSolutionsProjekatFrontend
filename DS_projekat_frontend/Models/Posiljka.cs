namespace DS_projekat_frontend.Models
{
    public class Posiljka
    {
        public Guid Id { get; set; }
        public string Naziv { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // "Na putu", "Isporučeno", "U skladištu"
        public DateTime DatumKreiranja { get; set; }
        public DateTime? DatumIsporuke { get; set; }
    }
}
