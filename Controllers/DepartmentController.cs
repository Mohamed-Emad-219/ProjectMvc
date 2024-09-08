using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectBusinessLogicLayer.BLL.Interfacies;
using ProjectBusinessLogicLayer.BLL.Repositories;
using ProjectDataAccessLayer.DAL.Data;

namespace ProjectMvc.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDpartmentrepository _departmentRepositroy;
        public DepartmentController(IDpartmentrepository departmentRepositroy)
        {
            //_departmentRepositroy = new DepartmentRepositroy(new ProjectDbContext(new DbContextOptions<ProjectDbContext>)));//invaild
            _departmentRepositroy = departmentRepositroy;
        }


        public IActionResult Index()
        {
            _departmentRepositroy.GetAll();
            return View();
        }
    }
}
