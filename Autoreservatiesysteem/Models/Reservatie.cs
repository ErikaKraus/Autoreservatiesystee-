namespace Autoreservatiesysteem.Models
{
    public class Reservatie
    {
        public int Id { get; set; }
        public DateTime BeginTijdstip { get; set; }
        public DateTime EindTijdstip {get; set;}
        public string Reden { get; set; } = default!;
        public bool Goedgekeurd { get; set; }
        public bool Teruggebracht { get; set; }

        //Navigatie
        public CustomUser Gebruiker { get; set; } = default!;
        public Auto Auto { get; set; } = default!;
    }
}
