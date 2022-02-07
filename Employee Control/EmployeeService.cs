using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Control
{
    class EmployeeService
    {


        private EmployeeService()
        {
            employees = new List<Employee>();
        }
        static EmployeeService _service;
        
        public static EmployeeService CreateService()
        {
            if(_service == null)
                _service = new EmployeeService();

            return _service;
        }
        private List<Employee> employees;
        public List<Employee> Search(SearchingEmployee srchEmp)
        {
            IEnumerable<Employee> result = employees;
            if (!string.IsNullOrEmpty(srchEmp.SearchName))
                result = result.Where(w => w.Name.Contains(srchEmp.SearchName));
            if (!string.IsNullOrEmpty(srchEmp.SearchLastname))
                result = result.Where(w => w.Surname.Contains(srchEmp.SearchLastname));
            if (srchEmp.SearchIsWorking.HasValue)
                result = result.Where(w => w.IsWorking == srchEmp.SearchIsWorking.Value);
            return result.ToList();

        }
        public void Insert(Employee newEmployee)
        {                     
            
            employees.Add(newEmployee);

        }
        public void Update(Employee updEmployee)
        {
            Employee tmp = new Employee();
            tmp = employees.Find(w => w.EmployeeId == updEmployee.EmployeeId);
            tmp = updEmployee;

            

        }
        public List<Employee> Delete(string id)
        {
            Employee deleteEmp;
            deleteEmp = employees.Find(w => w.EmployeeId == id);
            employees.Remove(deleteEmp);
            return employees;
        }
    }
}
