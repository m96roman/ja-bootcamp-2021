using ImageHandler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageHandler.Handlers
{
    public class UserModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext modelBindingContext)
        {
            if (modelBindingContext.ModelType == typeof(UserModel))
            {
                HttpRequestBase request = controllerContext.HttpContext.Request;
                string firtsName = request.Form.Get("FirstName");
                string lastName = request.Form.Get("LastName");

                return new UserModel()
                {
                    FirstAndLastName = firtsName + " " + lastName
                };
            }
            else
            {
                return base.BindModel(controllerContext, modelBindingContext);
            }
        }
    }
}