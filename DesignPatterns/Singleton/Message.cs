using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Message
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedTime { get; set; }

        public Message(string id, string text)
        {
            Id = id;
            Text = text;
            CreatedTime = DateTime.Now;
        }
    }
}
