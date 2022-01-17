using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// This is where I give you all the information about my people
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        /// <summary>
        /// Set the values in the Constructor
        /// </summary>
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Corey", Id = 1 });
            people.Add(new Person { FirstName = "Sure", LastName = "Storm", Id = 2 });
            people.Add(new Person { FirstName = "Bilbo", LastName = "Baggins", Id = 3 });
        }

        /// <summary>
        /// Gets a list of First Names
        /// </summary>
        /// <returns></returns>
        [Route("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> output = new List<string>();

            foreach(var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }
        /// <summary>
        /// Gets a list of First Names
        /// </summary>
        /// <param name="userId">The unique identifier for this person</param>
        /// <param name="age">We want to know how old they are</param>
        /// <returns>A list of first names</returns>
        [Route("api/People/GetFirstNamesWithParams/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNamesWithParams(int userId, int age)
        {
            List<string> output = new List<string>();

            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST: api/People
        public void Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
            
        }
    }
}
