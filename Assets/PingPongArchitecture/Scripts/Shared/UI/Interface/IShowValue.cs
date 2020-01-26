using PingPongArchitecture.Shared.Common;
using System;

namespace PingPongArchitecture.Shared.UI
{
    public interface IShowValue
    {
        void Setup(IHaveIntValue objWithIntValue);
        void UpdateView();
    }
}