using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDemo.Dal.Demo;
using WebApiDemo.Interface.Demo;

namespace WebApiDemo.Bll.Demo
{
    public class DemoBusiness : IDemo
    {
        public string SayHello()
        {
            return new DemoDal().SayHello();
        }
    }
}
