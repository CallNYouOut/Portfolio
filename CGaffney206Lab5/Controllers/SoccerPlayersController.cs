using Microsoft.AspNetCore.Mvc;
using CGaffney206Lab5.Models;
using CGaffney206Lab5.Repositories;

namespace CGaffney206Lab5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoccerPlayersController : ControllerBase
    {
        private readonly ISoccerPlayerRepository repo;

        public SoccerPlayersController(ISoccerPlayerRepository repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<SoccerPlayer>))]
        public async Task<IEnumerable<SoccerPlayer>> GetSoccerPlayers(string? position)
        {
            if (string.IsNullOrWhiteSpace(position))
            {
                return await repo.RetrieveAllAsync();
            }
            else 
            {
                return (await repo.RetrieveAllAsync()).Where(player => player.Position == position);
            }
        }
        [HttpGet("{id}", Name = nameof(GetSoccerPlayers))] // named route
        [ProducesResponseType(200, Type = typeof(SoccerPlayer))]
        [ProducesResponseType(404)]
        public async Task<IActionResult> GetSoccerPlayers(int id)
        {
            SoccerPlayer? player = await repo.RetrieveAsync(id);
            if (player == null)
            {
                return NotFound();
            }
            return Ok(player);
        }
        [HttpPost]
        [ProducesResponseType(201, Type = typeof(SoccerPlayer))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Create([FromBody] SoccerPlayer c)
        {
            if (c == null)
            {
                return BadRequest();
            }
            SoccerPlayer? addedSoccerPlayer = await repo.CreateAsync(c);
            if (addedSoccerPlayer == null)
            {
                return BadRequest("Repository failed to create soccer player");
            }
            else
            {
                return CreatedAtRoute(
                    routeName: nameof(GetSoccerPlayers),
                    routeValues: new { id = addedSoccerPlayer.PlayerId },
                    value: addedSoccerPlayer);
            }
        }
        [HttpPut("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Update(int id, [FromBody] SoccerPlayer player)
        {
            if (player == null || player.PlayerId == null)
            {
                return BadRequest();
            }
            SoccerPlayer? existing = await repo.RetrieveAsync(id);
            if (existing == null)
            {
                return NotFound();
            }
            await repo.UpdateAsync(id, player);
            return new NoContentResult();
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Delete(int id)
        {
            SoccerPlayer? existing = await repo.RetrieveAsync(id);
            if (existing == null)
            {
                return NotFound();
            }
            bool? deleted = await repo.DeleteAsync(id);
            if (deleted.HasValue && deleted.Value)
            {
                return new NoContentResult();
            }
            else
            {
                return BadRequest($"Customer {id} was found but failted to delete!");
            }
        }

    }
}
