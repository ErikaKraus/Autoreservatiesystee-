namespace Autoreservatiesysteem.Models
{
    public class Auto
    {
        public int Id {  get; set; }
        public string Nummerplaat { get; set; } = default!;
        public string Merk {  get; set; } = default!;
        public string Model { get; set; } = default!;
        public Brandstof Brandstof { get; set; }
        public Transmissie Transmissie { get; set; }
        public Status Status { get; set; }

        //Navigatie
        public List<Reservatie> Reservaties { get; set; } = new List<Reservatie>();
        public List<Locatie> Locaties { get; set; } = new List<Locatie>();

    }

    public enum Brandstof
    {
        Benzine, Diesel, Elektrisch
    }

    public enum Transmissie
    {
        Automaat, Handgeschakeld
    }

    public enum Status
    {
        Beschikbaar, Onderhoud, Gereserveerd
    }
}
