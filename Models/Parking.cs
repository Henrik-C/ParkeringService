namespace ParkeringService.Models
{
    public class Parking
    {
        public string Numberplate { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public DateTime TimeOfParking { get; set; }


        public Parking()
        {
            TimeOfParking = DateTime.Now;
        }
    }
}
