using System;
using System.Runtime.Serialization;

namespace TarkovMarket.Exceptions;

[Serializable]
public class TarkovMarketException : Exception
{
    public TarkovMarketException() { }
    
    public TarkovMarketException(string message) : base(message) { }
    
    public TarkovMarketException(string message, Exception inner) : base(message, inner) { }
    
    protected TarkovMarketException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
