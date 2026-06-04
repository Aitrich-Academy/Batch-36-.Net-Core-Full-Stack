using System.ComponentModel.DataAnnotations;

namespace MachineTest_Blazor.Model
{
    public class Customer
    {
        public int ID { get; set; }

        [Required(ErrorMessage=" FullName Required")] 
        public string FullName { get; set; }

        [Required(ErrorMessage = " Email required")]
        [EmailAddress(ErrorMessage ="Enter a valid MailId")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = " Rating required")]
        [Range(1,5,ErrorMessage ="Between 1-5")]
        public int Rating { get; set; }
        
        public string Comments  { get; set; }

    }
}
