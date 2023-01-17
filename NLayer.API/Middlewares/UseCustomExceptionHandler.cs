namespace NLayer.API.Middlewares
{
    public static class UseCustomExceptionHandler
    {
        public static void UserCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run;
            });
        }
    }
}
