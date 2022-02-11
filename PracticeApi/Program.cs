using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.RegularExpressions;
namespace PracticeApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //List<User> users = new List<User>()
            //{
            //    new() {Id = Guid.NewGuid(), UserName = "Oleg", Email = "oleggtv@gmail.com"},
            //    new() {Id = Guid.NewGuid(), UserName = "Andry", Email = "batmangtv@gmail.com"},
            //    new() {Id = Guid.NewGuid(), UserName = "Svitlana", Email = "svetlanagtv@gmail.com"}
            //};
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseHttpsRedirection();
            app.UseAuthorization();
            

            app.MapControllers();

            //app.Run(async (context) =>
            //{
            //    var request = context.Request;
            //    var response = context.Response;
            //    var path = request.Path;
            //    if (path == "/users" && request.Method == "GET")
            //    {
            //        await GetAllPeople(response);
            //    }
            //});
            app.Run();
            //async Task GetAllPeople(HttpResponse response)
            //{
            //    await response.WriteAsJsonAsync(users);
            //}
        }
    }
}
