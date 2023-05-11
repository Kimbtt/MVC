using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMvcProject.Models;

namespace FirstMvcProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employeeList = new List<Employee>();
            Employee employee = new Employee();
            employee.ID = 1;
            employee.Name = "KIm";
            employee.Salary = 1000;
            employeeList.Add(employee);
            
            Employee employee2 = new Employee();
            employee2.ID = 2;
            employee2.Name = "Bui";
            employee2.Salary = 6000;
            employeeList.Add(employee2);
            ViewData["Age"] = 20;
            ViewBag.Job = "Engineer";
            string company2 = "Hello";
            TempData["Company"] = company2;
            return View(employeeList);

        }
        public JsonResult GetDateWithJson()
        {
            string JsonDate = DateTime.Today.ToShortDateString();
            return Json(JsonDate);
        }

        public ActionResult AddEmployee()
        {
            Employee emp = new Employee();
            return View(emp);
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            string textValue = "";
            if (ModelState.IsValid)
                textValue = "Model State is Valid";
            else
                textValue = "model State is not Valide";
            return View(employee);
        }

        public ActionResult UpdateEmployee()
        {
            Employee employee = new Employee();
            employee.ID = 1;
            string company = (string)TempData["Company"];
            
            employee.Name = company;
            employee.Salary = 1000;
            return View(employee);
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee employee)
        {
            
            return View(employee);
        }
    }
}