using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Playlist_api.Model;
using Playlist_api.Servises;

namespace Playlist_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayListController : ControllerBase
    {
        private readonly MongodBServises _mongodbServises;
        public PlayListController(MongodBServises mongodbServises)
        {
            _mongodbServises = mongodbServises;
        }
        [HttpGet]
        public async Task<List<Playlist>> get()
        {
            return await _mongodbServises.GetAsync();
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Playlist plylist)
        {
            await _mongodbServises.CreateAsync(plylist);
            return Ok(plylist);
        }
        [HttpGet("{id:length(24)}")]

        public async Task<ActionResult<Playlist>> Getbyid(string id)
        {
            var empol = await _mongodbServises.GetbyidAsync(id);
            if (empol is null)
            {
                return NotFound();
            }
            return Ok(empol);
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<ActionResult> Delete(string id)
        {
            var songs = await _mongodbServises.GetbyidAsync(id);
            if(songs is null)
            {
                return NotFound(id);
            }
            await _mongodbServises.RemoveAsync(id);
            return NoContent();
        }

        [HttpPut]
        public async Task<IActionResult> Upadtedata(string id , Playlist updateplaylist)
        {
            var del = await _mongodbServises.GetbyidAsync(id);

            if(del is null)
            {
                return NotFound();
            }
              
             await _mongodbServises.updateAsync(id,updateplaylist); 
            return NoContent(); 
        }

    }
   
}
