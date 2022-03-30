using Blog.BLL.Extensions;
using Blog.DAL.Domains;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Blog.BLL.Handlers
{
    public class LoggedInUserFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var user = context.HttpContext.Session.GetObjectFromJson<User>("User");
            if (user == null)
            {
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary { { "Controller", "Account" }, { "Action", "LogIn" } });
            }

            base.OnActionExecuting(context);
        }
    }
}