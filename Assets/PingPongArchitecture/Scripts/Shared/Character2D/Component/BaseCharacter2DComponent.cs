using UnityEngine;

namespace PingPongArchitecture.Shared.Character2D
{
    public class BaseCharacter2DComponent : MonoBehaviour, IMovable2D
    {
        protected Transform _transform;
        [SerializeField]
        protected IProcessMove2D _iProcessMove;

        public virtual void MoveToPosition(in Vector2 pos) => _iProcessMove.Move(ref _transform, in pos);
        protected void Awake()
        {
            _transform = this.transform;
        }
    }
}