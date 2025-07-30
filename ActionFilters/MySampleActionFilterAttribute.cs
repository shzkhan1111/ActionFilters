using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters
{

    /// <summary>
    /// Attribute now I can make it an attribute
    /// </summary>
    public class MySampleActionFilterAttribute : Attribute , IActionFilter
    {
        private string _name;
        public MySampleActionFilterAttribute(string name)
        {
            _name = name;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"OnActionExecuted - {_name}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($"OnActionExecuted - {_name}");
        }
    }
}
