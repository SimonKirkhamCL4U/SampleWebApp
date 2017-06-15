using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Entities;
using Dapper;

namespace API.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/values
        public IEnumerable<User> Get()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersDB"].ConnectionString))
            {
                return connection.Query<User>("SELECT [ID], [Forename], [Surname] FROM [Si-Test-DB].[dbo].[Users]");
            }                
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

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
