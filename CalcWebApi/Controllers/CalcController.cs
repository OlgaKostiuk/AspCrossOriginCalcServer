using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using CalcWebApi.Models;

namespace CalcWebApi.Controllers
{
    //[EnableCors(origins: "http://localhost:56239", headers: "*", methods: "*")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CalcController : ApiController
    {
        [HttpPost]
        public Calc Calculate(Calc values)
        {
            values.CalcRes();
            return values;
        }
        //// GET: api/Calc
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET: api/Calc/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Calc
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Calc/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Calc/5
        //public void Delete(int id)
        //{
        //}
    }
}
