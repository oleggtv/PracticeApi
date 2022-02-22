using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticeApi.Services;
using PracticeApi.Repository;

//namespace PracticeApi.Controllers
namespace PracticeApi
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        //private readonly IUserRepository _userRepository;
        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet]
        public List<User> GetAll()
        {
            var users = _userService.GetAll();
            return users;
        }

        [HttpGet("{id}")]
        public User GetUser(Guid id)
        {
            var user = _userService.GetUser(id);
            return user;
        }

        [HttpPost]
        public List<User> AddUser(User user)
        {
            var users = _userService.AddUser(user);
            return users;
        }

        //[HttpPut("{id}")]
        //public List<User> PutUser(User user)
        //{
        //    var users = _userService.ReplaceUser(user);
        //    return users;
        //}
    }
}
