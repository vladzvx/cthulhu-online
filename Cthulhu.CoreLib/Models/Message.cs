using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Models
{
    public class Message
    {
        public DateTime dateTime { get; set; } = DateTime.UtcNow;
        public string Text { get; set; }
    }
}
