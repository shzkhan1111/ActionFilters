using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters
{

    /// <summary>
    /// Attribute now I can make it an attribute
    /// </summary>
    public class MySampleActionFilterAttribute : Attribute, IActionFilter, IOrderedFilter
    {
        private string _name;
        public MySampleActionFilterAttribute(string name, int order = 0)
        {
            _name = name;
            Order = order;
        }

        //IOrderedFilter  
        public int Order { get; set; }

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
