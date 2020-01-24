using UnityEngine;

namespace PingPongArchitecture.Shared.AttributePoints
{
    public class HitPointComponent : MonoBehaviour, IHaveHitPoints
    {
        protected IProcessHitPoints _iProcessHitpoints;
        [SerializeField] int _hitpoints = 100;
        [SerializeField] int _maxHitpoints = 100;

        public int Add(in int amount) => _hitpoints = _iProcessHitpoints.Add(_hitpoints, amount, _maxHitpoints);

        public int Subtract(in int amount) => _hitpoints = _iProcessHitpoints.Subtract(_hitpoints, amount);

        protected void Start()
        {
            _iProcessHitpoints = _iProcessHitpoints ?? new HitPointSystem();    
        }
    }
}