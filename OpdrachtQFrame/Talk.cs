using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtQFrame
{
    public class Talk
    {
        List<Talk> talks;

        public int? IdTalk { get; set; }
        public string? NameTalk { get; set; }
        public int? DurationTalk { get; set; }
        public bool? UsedTalk { get; set; }
     

    }

}
