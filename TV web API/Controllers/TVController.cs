using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TV_web_API.Model;
using TV_web_API.Servise;

namespace TV_web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TVController : ControllerBase
    {
        private readonly MongodbServicescs _mongodbServicescs;

        public TVController(MongodbServicescs mongodbServicescs)
        {
            _mongodbServicescs = mongodbServicescs;
        }

        [HttpGet]

        public async Task<List<tvsChannelcs>> Get()
        {
           return await _mongodbServicescs.GetAsync();
        }

    }
}
