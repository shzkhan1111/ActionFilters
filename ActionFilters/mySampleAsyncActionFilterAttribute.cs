using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilters
{
    public class mySampleAsyncActionFilterAttribute : Attribute , IAsyncActionFilter
    {
        string _name;
        public mySampleAsyncActionFilterAttribute(string name)
        {
            _name = name;
        }

        /// <summary>
        /// for asyc action filter
        /// </summary>
        /// <param name="context">
        /// context in which it is getting exec
        /// </param>
        /// <param name="next">
        /// next delegate
        /// next action that needs to get executeed 
        /// //like middlwware pipel;ine 
        /// </param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine($"before Exec async call - {_name}");
            await next();
            Console.WriteLine($"after Exec async call - {_name}");
        }
    }
}
