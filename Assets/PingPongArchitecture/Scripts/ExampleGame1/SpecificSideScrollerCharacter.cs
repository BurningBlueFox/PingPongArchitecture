using PingPongArchitecture.Inputs;
using UnityEngine;
using PingPongArchitecture.Shared.Character2D;

namespace PingPongArchitecture.ExampleGame1
{
    public class SpecificSideScrollerCharacter : SideScrollerCharacter2DComponent, ICheckForGround2D
    {
        protected IProcessCheckForGround2D _iProcessCheckForGround;
        [SerializeField] protected LayerMask _bitmask;
        [SerializeField] protected float _groundCheckDistance = 0.7f;

        public virtual bool IsOnGround() => _iProcessCheckForGround.IsOnGround(_transform.position, _groundCheckDistance, _bitmask);
        
        
        public override void Jump()
        {
            if(IsOnGround()) base.Jump();
        }

        public override void MoveToPosition(in Vector2 pos)
        {
            if (IsOnGround()) base.MoveToPosition(pos);
        }
        protected void Start()
        {
            base.Start();
            _iProcessCheckForGround = _iProcessCheckForGround ?? new CheckForGround2DSystem();
        }

    }
}