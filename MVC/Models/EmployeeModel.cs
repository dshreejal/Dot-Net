namespace MVC.Models
{
    //model is used to store data and db logic. it is used by controller or view to provide some services.
    //In .net model is a c# class that normally contains properties
    public class EmployeeModel
    {
        public int Id{get; set;}

        public string Name { get; set; }

        public string Department { get; set; }

        public double Salary { get; set; }
    }
}
