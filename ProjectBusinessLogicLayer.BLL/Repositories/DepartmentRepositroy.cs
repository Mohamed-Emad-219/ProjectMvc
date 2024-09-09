using Microsoft.EntityFrameworkCore;
using ProjectBusinessLogicLayer.BLL.Interfacies;
using ProjectDataAccessLayer.DAL.Data;
using ProjectDataAccessLayer.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogicLayer.BLL.Repositories
{
    public class DepartmentRepositroy : IDpartmentrepository
    {
        private readonly ProjectDbContext _dbcontext;// pointer to NULL
        public DepartmentRepositroy( ProjectDbContext dbContext)
        {
            //   _dbcontext = new ProjectDbContext();// vaild but not good because will create obj in each operation
            _dbcontext = dbContext;
        }
        public int Add(Department department)
        {
            _dbcontext.Add(department);
            return _dbcontext.SaveChanges();
        }

        public int Delete(Department department)
        {
            _dbcontext.Remove(department);
            return _dbcontext.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        {
            return _dbcontext.Departments.AsNoTracking().ToList();// asnotracking because we don't make any opr=erations on data = increase performance
        }

        public Department GetDepartmentById(int id)
        {
            //  var department = _dbcontext.Departments.Where(d => d.Id == id).FirstOrDefault();
            var department = _dbcontext.Departments.Find(id);// find op search in cache if found return it else ssearch in database
            return department;
        }

        public int Update(Department department)
        {
            _dbcontext.Update(department);
            return _dbcontext.SaveChanges();
         }
    }
}
