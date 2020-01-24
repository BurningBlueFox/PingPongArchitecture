namespace PingPongArchitecture.Shared.AttributePoints
{
    public interface IHaveHitPoints
    {
        int Subtract(in int amount);
        int Add(in int amount);
    }
}