using UnityEngine;

namespace PingPongArchitecture.Shared.AttributePoints
{
    public class HitPointComponent : MonoBehaviour, IHaveHitPoints
    {
        protected IHaveHitPoints _iHaveHitpoints;
        [SerializeField] int _hitpoints = 100;
        [SerializeField] int _maxHitpoints = 100;

        public int Add(in int hitPoints, in int amount, in int max) => _hitpoints = _iHaveHitpoints.Add(hitPoints, amount, max);

        public int Subtract(in int hitPoints, in int amount) => _hitpoints = _iHaveHitpoints.Subtract(hitPoints, amount);

        protected void Start()
        {
            _iHaveHitpoints = _iHaveHitpoints ?? new HitPointSystem();    
        }
    }
}