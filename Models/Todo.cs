using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace taskApi.Models
{
    public class Todo
    {
        public int id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }
        public TodoStatus Status { get; set; }

    }
}
