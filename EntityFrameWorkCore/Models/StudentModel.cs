using EntityFrameWorkCore.Models;
using System.ComponentModel.DataAnnotations;


namespace EntityFrameWorkCore.Models
{
    /*
     * Entity framework is a bridge to connect with external data source in asp .net core MVC
     * It uses object-relational mapper, which means all operations of database are done by creating class and object.
     * To use entity framework core following package needs to be installed
     * 1. Microsoft.EntityFrameworkCore.SqlServer and Microsoft.EntityFrameworkCore.Tools
     */
    public class StudentModel
    {
        //this class is used to set the column of table

        public Guid Id { get; set; } //auto id geenration

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
