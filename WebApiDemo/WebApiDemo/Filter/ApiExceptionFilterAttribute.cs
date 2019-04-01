using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http.Filters;

namespace WebApiDemo.Filter
{
    /// <summary>
    /// 统一异常处理
    /// </summary>
    public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        /// <summary>
        /// 统一异常处理
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response = new HttpResponseMessage(HttpStatusCode.BadRequest) {
                Content = new StringContent(actionExecutedContext.Exception.Message, Encoding.UTF8, "text/plain")
            };
            base.OnException(actionExecutedContext);
        }
    }
}