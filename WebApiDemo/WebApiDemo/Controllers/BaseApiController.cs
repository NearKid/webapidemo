using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemo.Filter;

namespace WebApiDemo.Controllers
{
    /// <summary>
    /// 控制器基类
    /// </summary>
    [ApiExceptionFilter]
    public class BaseApiController : ApiController
    {
    }
}
