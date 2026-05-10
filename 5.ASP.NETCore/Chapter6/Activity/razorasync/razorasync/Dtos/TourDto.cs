namespace razorasync.Dtos
{
    public class TourDto
    {
        public int Id { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
        public int AvailableSlots { get; set; }
    }
}
