using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDemo.Bll.Demo;
using WebApiDemo.Interface.Demo;

namespace WebApiDemo.Factory.Demo
{
    public class DemoFactory
    {
        public static IDemo GetDemoBusiness()
        {
            return new DemoBusiness();
        }
    }
}
