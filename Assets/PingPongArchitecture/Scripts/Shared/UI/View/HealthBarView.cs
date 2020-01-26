using PingPongArchitecture.Shared.Common;

namespace PingPongArchitecture.Shared.UI
{
    public class HealthBarView : IProcessValue
    {
        public float GetNormalizedValue(IHaveIntValue objWithIntValue)
        {
            if (objWithIntValue.GetValue() <= 0) return 0f;

            return (float)objWithIntValue.GetValue() / (float)objWithIntValue.GetMaxValue();
        }
    }
}