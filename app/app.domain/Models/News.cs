using app.persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app.domain
{
    public class News : Entity
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Link { get; set; }
        public string Status { get; set; }
    }
}
