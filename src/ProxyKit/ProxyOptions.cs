using System;

namespace ProxyKit
{
    public class ProxyOptions
    {
        public TimeSpan? WebSocketKeepAliveInterval { get; set; }

        public int? WebSocketBufferSize { get; set; }
    }
}
