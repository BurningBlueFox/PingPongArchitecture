using UnityEngine;
using PingPongArchitecture.Shared.Character2D;
using PingPongArchitecture.Shared.UI;
using PingPongArchitecture.Shared.AttributePoints;

namespace PingPongArchitecture.ExampleGame1
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] Transform _player;
        [SerializeField] Transform _UI;
        ISideScrollerCharacter2D _character;
        IHaveHitPoints _playerHealth;
        IShowValue _healthbar;
        private void Start()
        {
            _character = _player.GetComponent(typeof(ISideScrollerCharacter2D)) as ISideScrollerCharacter2D;

            _playerHealth = _player.GetComponent(typeof(IHaveHitPoints)) as IHaveHitPoints;
            _healthbar = _UI.GetComponent(typeof(IShowValue)) as IShowValue;

            _healthbar.Setup(_playerHealth);
        }
    }
}