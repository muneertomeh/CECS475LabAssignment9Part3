using CECS475LabAssignment9Part3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CECS475LabAssignment9Part3.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>
            {
                new Employee
                {
                    ID = 1,
                    Name= "Brian Nguyen",
                    JoiningDate = DateTime.Now,
                    Age = 21
                },
                new Employee
                {
                    ID =2,
                    Name="Brian Smith",
                    JoiningDate = DateTime.Now.ToUniversalTime(),
                    Age = 25
                },
            };

            return employeeList;
        }
        public ActionResult Employees()
        {
            var employeeList = from e in this.GetEmployees() select e;
            return View(employeeList);
        }
    }
}