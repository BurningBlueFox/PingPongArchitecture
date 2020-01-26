using System;
using UnityEngine;

namespace PingPongArchitecture.Shared.AttributePoints
{
    public class HitPointComponent : MonoBehaviour, IHaveHitPoints
    {
        protected IProcessHitPoints _iProcessHitpoints;
        [SerializeField] int _hitpoints = 100;
        [SerializeField] int _maxHitpoints = 100;

        public event Action OnValueChange;

        public int GetMaxValue() => _maxHitpoints;

        public int GetValue() => _hitpoints;

        public int Add(in int amount)
        {
            _hitpoints = _iProcessHitpoints.Add(_hitpoints, amount, _maxHitpoints);
            OnValueChange.Invoke();
            return _hitpoints;
        }

        public int Subtract(in int amount)
        {
            _hitpoints = _iProcessHitpoints.Subtract(_hitpoints, amount);
            OnValueChange.Invoke();
            return _hitpoints;
        }

        protected void Awake()
        {
            _iProcessHitpoints = _iProcessHitpoints ?? new HitPointSystem();    
        }
#if UNITY_EDITOR
        private void Update()
        {
            if (Input.GetKey(KeyCode.P))
                Subtract(1);
        }
#endif
    }
}