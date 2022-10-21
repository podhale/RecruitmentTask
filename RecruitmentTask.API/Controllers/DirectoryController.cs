using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecruitmentTask.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DirectoryController : ControllerBase
    {
        public DirectoryController()
        {

        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<>), StatusCodes.Status200OK)]
        public
    }
}
