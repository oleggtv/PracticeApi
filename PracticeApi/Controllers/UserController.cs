using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PracticeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        List<User> users = new List<User>()
            {
                new() {Id = Guid.NewGuid(), UserName = "Oleg", Email = "oleggtv@gmail.com"},
                new() {Id = Guid.NewGuid(), UserName = "Andry", Email = "batmangtv@gmail.com"},
                new() {Id = Guid.NewGuid(), UserName = "Svitlana", Email = "svetlanagtv@gmail.com"}
            };
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }
        [HttpGet(Name = "GetUser")]
        public List<User> Get()
        {
            //    //Request request = context.Request;
            //    //var response = context.Response;
            //    var path = Request.Path;
            //    if (path == "/users" && Request.Method == "GET")
            //    {
            //        return await GetAllPeople(Response);
            //    }
            return users;
            //    //.ToArray();
        }
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        async Task GetAllPeople(HttpResponse response)
        {
            await response.WriteAsJsonAsync(users);
        }
    }
}
