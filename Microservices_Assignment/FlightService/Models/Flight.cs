namespace FlightService.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public string FlightNumber { get; set; } = string.Empty;

        public string Source { get; set; }

        public string Destination { get; set; }
    }
}