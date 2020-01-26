using PingPongArchitecture.Shared.Common;
using System;

namespace PingPongArchitecture.Shared.AttributePoints
{
    public interface IHaveHitPoints : IHaveIntValue
    {
        int Subtract(in int amount);
        int Add(in int amount);
    }
}