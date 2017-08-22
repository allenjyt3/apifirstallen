using apifirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apifirst.Controllers
{
    public class Sample1Controller : ApiController
    {
        [HttpGet]
        // [Route("allen")]
        public string GetStrr(int id)
        {
            return "Hi Anju ";
        }
        [HttpPost]
        // [Route ("Posting")]
        public Samplemodel1 PostStrr(Samplemodel1 obj1)
        {
            Samplemodel1 obj = new Samplemodel1();
            obj.id = 1;
            obj.name = "AlluArjun";
            return obj1;
        }


        [HttpPut]
       [Route("Updating")]
        public Samplemodel1 PutStrr()
        {
            Samplemodel1 obj = new Samplemodel1();
            obj.id = 2;
            obj.name = "AromalSir";
            return obj;
        }
        [HttpDelete]
       [Route("Deleting")]
        public Samplemodel1 DeleteStr()
        {
            Samplemodel1 obj2 = new Samplemodel1();
            return obj2;
        }


      
    }

}
