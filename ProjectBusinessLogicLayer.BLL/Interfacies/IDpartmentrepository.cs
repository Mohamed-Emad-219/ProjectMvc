using ProjectDataAccessLayer.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBusinessLogicLayer.BLL.Interfacies
{
    public interface IDpartmentrepository
    {
        IEnumerable<Department> GetAll();
        Department GetDepartmentById(int id);
        int Add(Department department);
        int Update(Department department);
        int Delete(Department department);
    }
}
