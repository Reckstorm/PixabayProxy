using BLL.DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IHitsService
    {
        Task<ActionResult<IEnumerable<HitDTO>>> GetAllHitsAsync(string? request);
    }
}
