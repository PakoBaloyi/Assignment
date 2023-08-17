using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace Assignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        //adding user dbContext
         private readonly PeopleContext peopleContext;
        public AccountsController(PeopleContext peopleContext)
        {
            this.peopleContext = peopleContext;
        }
    }
}
