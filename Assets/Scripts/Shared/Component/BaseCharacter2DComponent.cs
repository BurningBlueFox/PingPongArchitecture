using UnityEngine;

namespace PingPongArchitecture.Shared.Character2D
{
    public abstract class BaseCharacter2DComponent : MonoBehaviour, IMovable2D
    {
        [SerializeField]
        protected IMovable2D _iMovable;

        public void Move(ref Transform transform, in Vector2 vel) => _iMovable.Move(ref transform, in vel);
    }
}