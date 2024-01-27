using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dans le fichier Flight.cs
namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        // Propriétés de l'entité Flight
        public string Destination { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        // Ajoutez d'autres propriétés si nécessaire
    }
}
