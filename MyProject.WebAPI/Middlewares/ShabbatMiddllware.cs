//namespace MyProject.WebAPI.Middlewares
//{
//    public class ShabbatMiddllware
//    {
//        private readonly RequestDelegate _requestDelegate;
//        public ShabbatMiddllware(RequestDelegate requestDelegate)
//        {
//            _requestDelegate = requestDelegate;
//        }
//        public  async Task InvokeAsync(HttpContext context)
//        {
//            if(DateTime.Now.DayOfWeek==DayOfWeek.Saturday)
//            {
//                context.Response.StatusCode = StatusCodes.Status400BadRequest;
//            }
//            else
//            {
//                context.Response.StatusCode = StatusCodes.Status200OK;
//                var guid = Guid.NewGuid().ToString();
//                Console.WriteLine($"Request {guid} started the pipeline");
//                context.Items.Add("ReqS", guid);
//                await _requestDelegate(context);
//                Console.WriteLine($"Reques {guid} ended the pipeline");
//            }
//        }
//    }
//    public static class ShabbatMiddllwareExtension
//    {
//        public static IApplicationBuilder UseShabbat(this IApplicationBuilder _applicationBuilder)
//        {
//            _applicationBuilder.UseMiddleware<ShabbatMiddllware>();
//            return _applicationBuilder;
//        }
//    }
//}
