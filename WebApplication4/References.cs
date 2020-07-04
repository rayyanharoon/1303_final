using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4
{
    public class References
    {
        public long ReferenceId { get; set; }
        public string Description { get; set; }
        public List<string> Urls { get; set; }
    }
}
