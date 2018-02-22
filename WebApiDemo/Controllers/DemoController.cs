using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using WebApiDemo.Factory.Demo;
using WebApiDemo.Model.Response;

namespace WebApiDemo.Controllers
{
    public class DemoController : ApiController
    {
        [HttpGet]
        public BaseResponse GetSayHello()
        {
            var business = DemoFactory.GetDemoBusiness();        
            return new BaseResponse() { IsSuccess = true, Message = "Success", Data = business.SayHello()};
        }
    }
}
