using PingPongArchitecture.Shared.Character2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PingPongArchitecture.ExampleGame1
{
    public class EnemyComponent : SideScrollerCharacter2DComponent
    {
        [SerializeField]Transform _target;

        protected new void Awake()
        {
            base.Awake();
            _inputAction.Dispose();
        }
        protected new void Update()
        {
            float move = 0.001f;
            if (_target.position.x < _transform.position.x) move *= -1f;

            MoveToPosition(new Vector2(move, _transform.position.y));
        }
    }
}