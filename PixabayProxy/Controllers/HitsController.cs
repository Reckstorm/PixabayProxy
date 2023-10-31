using BLL.DTO;
using BLL.Interfaces;
using BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace PixabayProxy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HitsController : ControllerBase
    {
        private IHitsService _hitsService;
        public HitsController()
        {
            _hitsService = new HitsService();
        }

        [HttpPost("GetHits")]
        public async Task<ActionResult<IEnumerable<HitDTO>>> GetAllAsync(string? request)
        {
            return Ok(await _hitsService.GetAllHitsAsync(request));
        }
    }
}
