using PingPongArchitecture.Inputs;
using UnityEngine;

namespace PingPongArchitecture.Shared.Character2D
{
    public class SpecificSideScrollerCharacter : SideScrollerCharacter2DComponent, ICheckForGround2D
    {
        protected ICheckForGround2D _iCheckForGround;
        [SerializeField] protected LayerMask _bitmask;
        [SerializeField] protected float _groundCheckDistance = 0.7f;

        public virtual bool IsOnGround(in Vector2 center, in float distanceBias, in int bitmask) => _iCheckForGround.IsOnGround(center, distanceBias, bitmask);
        
        
        public override void Jump(ref Rigidbody2D rigidbody, in float force, in ForceMode2D forceMode = ForceMode2D.Impulse)
        {
            if(IsOnGround(_transform.position, _groundCheckDistance, _bitmask)) base.Jump(ref rigidbody, force, forceMode);
        }

        public override void Move(ref Transform transform, in Vector2 vel)
        {
            if (IsOnGround(_transform.position, _groundCheckDistance, _bitmask)) base.Move(ref transform, vel);
        }
        protected void Start()
        {
            base.Start();
            _iCheckForGround = _iCheckForGround ?? new CheckForGround2DSystem();
        }

    }
}