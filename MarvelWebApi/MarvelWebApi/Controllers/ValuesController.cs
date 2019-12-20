using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Marvel.models;
using Marvel.DAL;


namespace MarvelWebApi.Controllers
{
    public class ValuesController : ApiController
    {

        private DataLayer p = new DataLayer();
        //// GET api/values
        //Find Roles
        [HttpGet]
        [Route("api/Values/GetMarvelCharacters")]
        public IHttpActionResult GetMarvelCharacters()
        {
            var result = p.LoadInformation();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        //    // GET api/values
        //    public IEnumerable<string> Get()
        //    {
        //        return new string[] { "value1", "value2" };
        //    }

        //    // GET api/values/5
        //    public string Get(int id)
        //    {
        //        return "value";
        //    }

        //    // POST api/values
        //    public void Post([FromBody]string value)
        //    {
        //    }

        //    // PUT api/values/5
        //    public void Put(int id, [FromBody]string value)
        //    {
        //    }

        //    // DELETE api/values/5
        //    public void Delete(int id)
        //    {
        //    }
    }
}
