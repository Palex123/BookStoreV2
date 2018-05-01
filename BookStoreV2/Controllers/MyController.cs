using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BookStoreV2.Controllers
{
    public class MyController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            string ip = requestContext.HttpContext.Request.UserHostAddress;
            var responce = requestContext.HttpContext.Response;
            responce.Write("<h2>Ваш IP Адрес: " + ip + "</h2>");

        }
    }
}