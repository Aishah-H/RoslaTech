namespace RoslaTechs.Models
{
    public class CarbonFootprint
    {
        public int Id { get; set; }
        public int electricityUsage { get; set; }
        public int vehicleMiles { get; set; }
        public int flightHours { get; set; }

        public string Message { get; set; } = "Sorry this page is still under construction";
    }
}
