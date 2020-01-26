using UnityEngine;
using PingPongArchitecture.Inputs;

namespace PingPongArchitecture.Shared.Character2D
{
    public class SideScrollerCharacter2DComponent : BaseCharacter2DComponent, ISideScrollerCharacter2D
    {
        protected IProcessJump2D _iProcessJump;
        [SerializeField] protected SideScroller2DInput_Default _inputAction;
        [SerializeField] [Range(0.01f, 1f)] protected float _velocityDampening = 0.1f;
        [SerializeField] [Range(5f, 15f)] protected float _jumpForce = 10f;

        protected Rigidbody2D _rigidbody;
        float moveAxis;

        public virtual void Jump() => _iProcessJump.Jump(ref _rigidbody, in _jumpForce, ForceMode2D.Impulse);

        protected virtual void SetInputs()
        {
            _inputAction = new SideScroller2DInput_Default();
            _inputAction.Player.Move.Enable();
            _inputAction.Player.Jump.performed += ctx => this.Jump();
            _inputAction.Player.Jump.Enable();
            _inputAction.Enable();
        }

        protected new void Awake()
        {
            base.Awake();
            _rigidbody = GetComponent<Rigidbody2D>();
            SetInputs();
        }
        protected void Update()
        {
            moveAxis = _inputAction.Player.Move.ReadValue<float>() * _velocityDampening;
            MoveToPosition(new Vector2(moveAxis, _transform.position.y));
        }
        protected new void Start()
        {
            base.Start();
            _iProcessJump = _iProcessJump ?? new Jump2DSystem();
        }

        protected void OnEnable() => _inputAction.Enable();

        protected void OnDisable() => _inputAction.Disable();
    }
}