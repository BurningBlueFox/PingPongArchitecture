namespace PingPongArchitecture.Shared.AttributePoints
{
    public interface IHaveHitPoints
    {
        int Subtract(in int hitPoints, in int amount);
        int Add(in int hitPoints, in int amount, in int max);
    }
}