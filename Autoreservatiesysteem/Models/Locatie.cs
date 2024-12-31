namespace Autoreservatiesysteem.Models
{
    public class Locatie
    {
        public int Id { get; set; }
        public string Naam { get; set; } = default!;
        public string Straat { get; set; } = default!;
        public string Huisnummer { get; set; } = default!;
        public string Postcode { get; set; } = default!;
        public string Gemeente { get; set; } = default!;

        public List<Auto> Autos { get; set; } = new List<Auto>();
    }
}
