namespace GrabTaxi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CarType { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }
        public int NumberOfCars { get; set; }
        public int NumberOfPassengers { get; set; }
        public string Message { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }
    }
}
