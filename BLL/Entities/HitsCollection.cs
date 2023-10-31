using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    public class HitsCollection
    {
        public int total { get; set; }
        public int totalHits { get; set; }
        public List<Hit> hits { get; set; }
    }
}
