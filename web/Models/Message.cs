using System;
using System.Collections.Generic;

namespace web.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string UserID { get; set; }
        public int GroupID { get; set; }
        public DateTime Date { get; set; }
    }
}