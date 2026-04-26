using FlightAPI.Models;

namespace FlightAPI.Repository
{
    public interface IFlightRepository
    {
        List<Flight> GetAllFlights();
        Flight GetFlight(int id);
        void AddFlight(Flight flight);
        void EditFlight(Flight flight);
        void DeleteFlight(int id);
    }
}