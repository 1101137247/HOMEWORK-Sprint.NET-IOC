
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    public class NewEmployeeDao : IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee();
            employee1.Id = "riven";
            employee1.Name = "雷玟";
            employee1.Age = 21;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee1.Id = "anne";
            employee1.Name = "安妮";
            employee1.Age = 12;
            employees.Add(employee2);

            return employees;

        }
        public Employee GetEmployeeById(string id)
        {
            Employee employees = new Employee();
            employees.Id = "anne";
            employees.Name = "安妮";
            employees.Age = 12;

            return employees;
        }


    }
}
