namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

            #region MiddleWare
            /*
            //Inline middlewear because  we use anonymous type
            app.Use(async (context, next) =>
            {
                //can add response or not
                await context.Response.WriteAsync("1)Middleware 1\n");
                //can call next middlewear or not "short circuit"
                await next.Invoke();
            });
            app.Use(async (context, next) =>
            {
                //can add response or not
                //await context.Response.WriteAsync("2)Middleware 1\n");
                //can call next middlewear or not "short circuit"
                await next.Invoke();
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("3)Middleware 3\n");
            });
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("4)Middleware 4\n");
                await next.Invoke();
            });*/
            #endregion
        }

    }
}