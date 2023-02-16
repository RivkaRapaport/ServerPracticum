//using MyProject.WebAPI.Middlewares;

//namespace MyProject.WebAPI.Middlewares
//{
//    public class TrakMiddleware
//    {
//        private readonly RequestDelegate _next;
//        public TrakMiddleware(RequestDelegate next)
//        {
//            _next = next;
//        }
//        public async Task InvokeAsync(HttpContext context)
//        {
//            var guid= Guid.NewGuid().ToString();
//            Console.WriteLine($"Request {guid} started the pipeline");
//            context.Items.Add("ReqSeq", guid);
//            await _next(context);
//            Console.WriteLine($"Request {guid} ended the pipeline");
//        }
//    }
//}
//public static class TrakMiddlewareExtension
//{
//    public static IApplicationBuilder UseTrak(this IApplicationBuilder _applicationBuilder)
//    {
//         _applicationBuilder.UseMiddleware<TrakMiddleware>();
//        return _applicationBuilder;
//    }
//}
