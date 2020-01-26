using UnityEngine;
using UnityEngine.UI;
using PingPongArchitecture.Shared.Common;
using System;

namespace PingPongArchitecture.Shared.UI
{
    public class HealthBarComponent : MonoBehaviour, IShowValue
    {
        [SerializeField] Image _healthBar;
        IHaveIntValue _valueToDisplay;
        IProcessValue _valueView;

        public void Setup(IHaveIntValue objWithIntValue)
        {
            _valueToDisplay = objWithIntValue;
            objWithIntValue.OnValueChange += () => { UpdateView(); };
        }

        public void UpdateView()
        {
            _healthBar.fillAmount = _valueView.GetNormalizedValue(_valueToDisplay);
        }

        private void Awake()
        {
            _valueView = _valueView ?? new HealthBarView();
        }
    }
}