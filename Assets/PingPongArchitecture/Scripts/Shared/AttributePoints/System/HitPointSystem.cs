using UnityEngine;

namespace PingPongArchitecture.Shared.AttributePoints
{
    public class HitPointSystem : IHaveHitPoints
    {
        public int Add(in int hitPoints, in int amount, in int max) => Mathf.Min(hitPoints + amount, max);
        
        public int Subtract(in int hitPoints, in int amount) => Mathf.Max(hitPoints - amount, 0);
    }
}