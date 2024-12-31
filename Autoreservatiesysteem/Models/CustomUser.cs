using Microsoft.AspNetCore.Identity;

namespace Autoreservatiesysteem.Models
{
    public class CustomUser: IdentityUser<int>
    {
        //Is onderdeel van Identity: id, e-mail, telefoonnummer, 
        public string Voornaam { get; set; } = default!;
        public string Naam { get; set; } = default!;
        public string Dienstnummer { get; set; } = default!;

        //Navigatie
        public List<Reservatie> Reservaties { get; set; } = new List<Reservatie>();
    }
}
