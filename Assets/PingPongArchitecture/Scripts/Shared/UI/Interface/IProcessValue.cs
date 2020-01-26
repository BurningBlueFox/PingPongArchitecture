using PingPongArchitecture.Shared.Common;
namespace PingPongArchitecture.Shared.UI
{
    public interface IProcessValue
    {
        float GetNormalizedValue(IHaveIntValue objWithIntValue);
    }
}