using FlightAPI.Models;

namespace FlightAPI.Repository
{
    public class FlightRepository : IFlightRepository
    {
        private static List<Flight> flights = new List<Flight>()
        {
            new Flight { Id = 1, FlightCode = "AI101", Seat = 120, FlightType = "Domestic", Company = "Air India" },
            new Flight { Id = 2, FlightCode = "IN202", Seat = 150, FlightType = "International", Company = "Indigo" }
        };

        public List<Flight> GetAllFlights()
        {
            return flights;
        }

        public Flight GetFlight(int id)
        {
            return flights.FirstOrDefault(f => f.Id == id);
        }

        public void AddFlight(Flight flight)
        {
            flights.Add(flight);
        }

        public void EditFlight(Flight flight)
        {
            var existing = flights.FirstOrDefault(f => f.Id == flight.Id);
            if (existing != null)
            {
                existing.FlightCode = flight.FlightCode;
                existing.Seat = flight.Seat;
                existing.FlightType = flight.FlightType;
                existing.Company = flight.Company;
            }
        }

        public void DeleteFlight(int id)
        {
            var flight = flights.FirstOrDefault(f => f.Id == id);
            if (flight != null)
            {
                flights.Remove(flight);
            }
        }
    }
}