using System;
using System.IO;
using System.Web.Mvc;

namespace WebApplication.Models
{
    public class CustomExceptionLogFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            var exceptionMessage = filterContext.Exception.Message;
            var stackTrace = filterContext.Exception.StackTrace;
            var controllerName = filterContext.RouteData.Values["controller"].ToString();
            var actionName = filterContext.RouteData.Values["action"].ToString();

            string Message = "Date :" + DateTime.Now.ToString() + ", Controller: " + controllerName + ", Action:" + actionName +
                             "Error Message : " + exceptionMessage
                             + Environment.NewLine + "Stack Trace : " + stackTrace;

            File.AppendAllText($@"{Directory.GetCurrentDirectory()}\Logger.txt", Message);

            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
        }
    } 
}