using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models
{
    public class LogCustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled)
            {
                var exceptionMessage = filterContext.Exception.Message;
                var stackTrace = filterContext.Exception.StackTrace;
                var controllerName = filterContext.RouteData.Values["controller"].ToString();
                var actionName = filterContext.RouteData.Values["action"].ToString();

                string Message = "Date :" + DateTime.Now.ToString() + ", Controller: " + controllerName + ", Action:" + actionName +
                                 "Error Message : " + exceptionMessage
                                 + Environment.NewLine + "Stack Trace : " + stackTrace;
                //saving the data in a text file called Log.txt
                //You can also save this in a dabase
                File.AppendAllText(@"C:\Users\kateryna.fedak\Source\Repos\m96roman\ja-bootcamp-2021\MVC\MVC-Day1\WebApplication1\Log\Log.txt", Message);

                filterContext.ExceptionHandled = true;
                filterContext.Result = new ViewResult()
                {
                    ViewName = "Error"
                };
            }
        }
    }
}