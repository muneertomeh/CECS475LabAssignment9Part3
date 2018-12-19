using CECS475LabAssignment9Part3.Controllers;
using CECS475LabAssignment9Part3.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace CECS475LabAssignment9Part3.Tests.Controllers
{
    [TestClass]
    public class EmployeeControllerTest
    {
        [TestMethod]
        public void TestIndex()
        {
            EmployeeController empController = new EmployeeController();
            ViewResult viewResult = empController.Index() as ViewResult;
            Assert.IsNotNull(viewResult);
        }
        [TestMethod]
        public void TestEmployeesList()
        {
            EmployeeController empController = new EmployeeController();
            IList<Employee> employeesList = empController.GetEmployees() as IList<Employee>;
          
        }

        [TestMethod]
        public void TestEmployees()
        {
            EmployeeController empController = new EmployeeController();
            ViewResult theResult = empController.Employees() as ViewResult;
            Assert.IsNotNull(theResult);
        }


    }
}
