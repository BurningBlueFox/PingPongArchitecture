using System;

namespace PingPongArchitecture.Shared.Common
{
    public interface IHaveIntValue
    {
        event Action OnValueChange;
        int GetValue();
        int GetMaxValue();
    }
}