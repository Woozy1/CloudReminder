using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int GroupID { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime EventDate { get; set; }
    }
}