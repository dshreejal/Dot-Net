using Microsoft.AspNetCore.Mvc;
using EntityFrameWorkCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkCore.Controllers
{
    public class StudentController : Controller
    {
        //setting context class on controller
        private readonly StudentContext sc;
        public StudentController(StudentContext sc)
        {
            this.sc = sc;
        }
        //this method is used for creating form in view. it uses get
        [HttpGet]
        public IActionResult InsertStudent()
        {
            return View();
        }
        [HttpPost]
        //accept form data and insert into database table
        public IActionResult InsertStudent(AddStudent s)
        {
            if (ModelState.IsValid)
            {
                var st = new StudentModel()
                {
                    Id = Guid.NewGuid(), //auto generated
                    Name = s.Name,
                    Gender = s.Gender,
                    Address = s.Address,
                    Faculty = s.Faculty
                };
                sc.Students.Add(st);
                sc.SaveChanges();
                return RedirectToAction("Index");
            }
            // If model state is not valid, return to the view with validation errors
            return View(s);
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var students = await sc.Students.ToListAsync();
            return View(students);
        }

        [HttpGet]
        public async Task< IActionResult> Edit(Guid id)
        {
            var student = await sc.Students.FindAsync(id);
            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(StudentModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var student = await sc.Students.FindAsync(viewModel.Id);

                if (student is not null)
                {
                    student.Name = viewModel.Name;
                    student.Gender = viewModel.Gender;
                    student.Address = viewModel.Address;
                    student.Faculty = viewModel.Faculty;

                    await sc.SaveChangesAsync();

                }

                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var student = await sc.Students.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if(student is not null)
            {
                sc.Students.Remove(student);
                await sc.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }
    }
}
