using System;
using System.Collections.Generic;

namespace web.Models
{
    public class ViewModel
    {
        
        public ICollection<Event>? Events { get; set; }
        public ICollection<GroupUser>? GroupUsers { get; set; }
    }
}