using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeSerivice.Controllers
{
   // [Authorize]
    public class AspNetUsersController : ApiController
    {
        mmb_dbEntities entities; 

        AspNetUsersController()
        {
            entities = new mmb_dbEntities();
        }
        
      
        public IEnumerable<AspNetUser> getUsers() 
        {
            return entities.AspNetUsers.ToList();
        }
    }
}
