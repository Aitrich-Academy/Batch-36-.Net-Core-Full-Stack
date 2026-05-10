using System.ComponentModel.DataAnnotations;

namespace razorasync.Model
{
    public class Tour
    {
        public int Id { get; set; }

        public string Destination { get; set; }

       
        public decimal Price { get; set; }


        public int AvailableSlots { get; set; }
    }
}
