using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeesApp.Web.Controllers;

public class MyLogFilter(ILogger<MyLogFilter> logger) : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        logger.LogInformation("starta");
    }

    public override void OnActionExecuted(ActionExecutedContext context)
    {
        logger.LogWarning($"hejdå");
    }
}
