using BLL.DTO;
using BLL.Entities;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace BLL.Services
{
    public class HitsService : IHitsService
    {
        //private string requrestURL = "https://pixabay.com/api/?key=39206396-a3d0261b98314ee7c13677bfd&q=yellow+flowers&image_type=photo&pretty=true";
        private string requrestURL;
        private List<HitDTO>? Hits { get; set; }

        public HitsService()
        {
            requrestURL = @"https://pixabay.com/api/?key=39206396-a3d0261b98314ee7c13677bfd&q=";
            Hits = new List<HitDTO>();
        }

        public async Task<ActionResult<IEnumerable<HitDTO>>> GetAllHitsAsync(string? request)
        {
            request = string.IsNullOrEmpty(request) ? "yellow+flowers" : request;
            WebClient wc = new WebClient();
            string tmp = await wc.DownloadStringTaskAsync(new Uri($"{requrestURL}{request}"));
            List<Hit> tempHits = new List<Hit>(JsonSerializer.Deserialize<HitsCollection>(tmp).hits);
            tempHits.ForEach(hit => Hits.Add(new HitDTO(hit)));
            if (Hits == null) return null;
            return Hits;
        }
    }
}
