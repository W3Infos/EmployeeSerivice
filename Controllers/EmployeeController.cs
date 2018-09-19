using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeSerivice.Controllers
{
    [Authorize]
    public class EmployeeController : ApiController
    {
        mmb_dbEntities entities;
        EmployeeController()
        {
            
            entities = new mmb_dbEntities();
        }
         public IEnumerable<Employee> GetEmployeeDetails()
         {
             return entities.Employees.ToList();
                
         }
    }
}
