using Server.Data;
using Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Server.Controllers
{
    public class UsersController : ApiController
    {
        public IEnumerable<User> Get()
        {
            return MockUsersStore.Users;
        }
        public IHttpActionResult Get(int id)
        {
            var user = MockUsersStore.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound();

            return Ok(user);
        }

        public IHttpActionResult Post([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User is null");
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            if (user.Id <= 0)
                return BadRequest("Id must be greater than 0");


            System.Diagnostics.Debug.WriteLine(
                $"Received user: Id={user.Id}, Name={user.Name}"
            );

            
            MockUsersStore.Users.Add(user);

            // החזרת קוד סטטוס 201 Created
            return StatusCode(HttpStatusCode.Created);
        }
    }
}
