using System.ComponentModel.DataAnnotations;

namespace EntityFrameWorkCore.Models
{
    //this model class stores the data sent from form and return the data when required
    public class AddStudent
    {
        public Guid Id { get; set; }//auto id generation with primary key

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }


        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Faculty is required")]
        public string Faculty { get; set; }
    }
}
