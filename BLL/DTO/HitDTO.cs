using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Entities;

namespace BLL.DTO
{
    public class HitDTO
    {
        public int id { get; set; }
        public string largeImageURL { get; set; }
        public string fullHDURL { get; set; }
        public string imageURL { get; set; }
        public int imageWidth { get; set; }
        public int imageHeight { get; set; }
        public int imageSize { get; set; }

        public HitDTO(Hit hit)
        {
            id = hit.id;
            largeImageURL = hit.largeImageURL;
            fullHDURL = hit.fullHDURL;
            imageURL = hit.imageURL;
            imageWidth = hit.imageWidth;
            imageHeight = hit.imageHeight;
            imageSize = hit.imageSize;
        }
    }
}
