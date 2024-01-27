using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightService : IFlightService
    {
        private ICollection _source;

        // Constructeur
        public FlightService(ICollection source)
        {
            _source = source;
        }

        // Implémentation de l'interface
        public void ShowFlights(string filterType, string filterValue)
        {
            foreach (var flight in _source.Cast<Flight>()) // Supposant que _source contient des objets de type Flight
            {
                // Ajoutez ici la logique pour filtrer et afficher les vols selon les paramètres
                Console.WriteLine($"Flight to {flight.Destination}, Date: {flight.FlightDate}, ID: {flight.FlightId}");
            }
            if (filterType != "Destination" && filterType != "FlightDate" && filterType != "FlightId")
            {
                throw new ArgumentException("Unknown filter");
            }
        }
    }
}