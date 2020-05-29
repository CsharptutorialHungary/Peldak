using System;
using System.Collections.Generic;

namespace TCPCommon
{
    [Serializable]
    public class Message
    {
        public DateTime ResponseTime { get; set; }
        public List<int> Szamok { get; set; }
    }
}
