using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kros.KORM;
using Microsoft.AspNetCore.Mvc;
using Sample.KormAutoincrement.Domains;

namespace Sample.KormAutoincrement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IDatabase _database;

        public UsersController(IDatabase database)
        {
            _database = database;
        }

        [HttpGet]
        public IEnumerable<User> Get()
            => _database.Query<User>().ToList();

        [HttpPost]
        public async Task<IActionResult> Post(User user)
        {
            await _database.AddAsync(user);

            return Ok(new { user.Id });
        }
    }
}
