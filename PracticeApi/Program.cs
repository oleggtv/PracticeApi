using System.Text.RegularExpressions;
namespace PracticeApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Person> users = new List<Person>()
            {
                new() {Id = Guid.NewGuid(), UserName = "Oleg", Email = "oleggtv@gmail.com"},
                new() {Id = Guid.NewGuid(), UserName = "Andry", Email = "batmangtv@gmail.com"},
                new() {Id = Guid.NewGuid(), UserName = "Svitlana", Email = "svetlanagtv@gmail.com"}
            };
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.Run(async (context) =>
            {
                var request = context.Request;
                var response = context.Response;
                var path = request.Path;
                if (path == "/users" && request.Method == "GET")
                {
                    await GetAllPeople(response);
                }
            });
            app.Run();
            async Task GetAllPeople(HttpResponse response)
            {
                await response.WriteAsJsonAsync(users);
            }
        }
    }
}
