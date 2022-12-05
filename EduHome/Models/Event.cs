using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduPage.Models
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }
}
