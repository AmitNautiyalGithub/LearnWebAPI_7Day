using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeVM;

namespace WebApiTest.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public Employee Get()
        {
            return new Employee
            {
                EmployeeName = "Amit",
                EmployeeCode = "001",
                Salary = "$4500"
            };

            //return new string[] { "value1", "value2" };
        }

        public IList<Employee> Get(string id)
        {
            return new List<Employee>()
            {
                new Employee
                {
                    EmployeeName = "Amit",
                    EmployeeCode = "001",
                    Salary = "$4500"
                },
                 new Employee
                {
                    EmployeeName = "Sumit",
                    EmployeeCode = "002",
                    Salary = "$5000"
                }
            };

            //return new string[] { "value1", "value2" };
        }




        // GET api/values/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
