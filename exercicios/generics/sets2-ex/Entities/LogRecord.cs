using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sets2_ex.Entities
{
    public class LogRecord
    {
        public string Username { get; set;}
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();  
        }

        public override bool Equals(object? obj)
        {   
            if (!(obj is LogRecord))
            {
                return base.Equals(obj);
            }
            LogRecord other = obj as LogRecord;
            return Username.Equals(other.Username);
        }
    }
}